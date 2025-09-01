using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Clientes
{
    public enum ClienteFormMode { Create, Edit }
    public partial class V_UpsertCliente : Form
    {
        private readonly clientesService _svc;
        private readonly int? _id;
        public ClienteFormMode Mode { get; }

        public V_UpsertCliente(POSContext ctx, int? idCliente = null)
        {
            InitializeComponent();
            _svc = new clientesService(ctx);
            _id = idCliente;
            Mode = idCliente.HasValue ? ClienteFormMode.Edit : ClienteFormMode.Create;

            // UI Segun modo
            lblTitulo.Text = Mode == ClienteFormMode.Create ? "Agregar Cliente" : "Editar Cliente";
            B_Guardar.Text = Mode == ClienteFormMode.Create ? "Crear" : "Guardar";

            // Reglas de captura
            TB_Telefono.MaxLength = 10;
            TB_Telefono.KeyPress += TB_Telefono_KeyPress;   // solo números
            TB_RFC.CharacterCasing = CharacterCasing.Upper; // RFC en mayúsculas

            if (Mode == ClienteFormMode.Edit)
                CargarCliente(_id!.Value);

            TB_Nombre.Focus();
        }

        private void CargarCliente(int id)
        {
            var c = _svc.Obtener(id);
            TB_Nombre.Text = c.Nombre;
            TB_Telefono.Text = c.Telefono;
            TB_RFC.Text = c.RFC;
            TB_CE.Text = c.Email;
            TB_Direccion.Text = c.Direccion;

        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            if (!TryBuildModel(out var model, out var msg))
            {
                MessageBox.Show(msg);
                return;
            }

            try
            {
                if (Mode == ClienteFormMode.Create)
                {
                    _svc.Crear(model);
                    // Toast.Show(this, "Cliente creado con éxito", ToastType.Success);
                }
                else
                {
                    _svc.Actualizar(model);
                    // Toast.Show(this, "Cliente actualizado", ToastType.Success);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el cliente: " + ex.Message);
            }
        }
        

        private void TB_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // ---- Validaciones ----

        private static bool IsValidEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email)) return true; // opcional
            // regex simple y suficiente para UI
            return Regex.IsMatch(email.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        private bool TryBuildModel(out clientes model, out string error)
        {
            error = string.Empty;
            model = new clientes();

            string nombre = TB_Nombre.Text.Trim();
            string dir = TB_Direccion.Text.Trim();
            string rfc = TB_RFC.Text.Trim().ToUpperInvariant();
            string email = TB_CE.Text.Trim();

            // Mantén solo dígitos por si pegaron con espacios o guiones
            string telDigits = new string((TB_Telefono.Text ?? "").Where(char.IsDigit).ToArray());

            if (string.IsNullOrWhiteSpace(nombre))
            {
                error = "El nombre es obligatorio.";
                TB_Nombre.Focus(); return false;
            }

            if (string.IsNullOrWhiteSpace(telDigits))
            {
                error = "El teléfono es obligatorio.";
                TB_Telefono.Focus(); return false;
            }

            if (telDigits.Length != 10)
            {
                error = "El teléfono debe tener exactamente 10 dígitos.";
                TB_Telefono.Focus(); return false;
            }

            if (string.IsNullOrWhiteSpace(dir))
            {
                error = "La dirección es obligatoria.";
                TB_Direccion.Focus(); return false;
            }

            if (!IsValidEmail(email))
            {
                error = "El email no es válido (debe contener @ y dominio).";
                TB_CE.Focus(); return false;
            }

            model = new clientes
            {
                IdCliente = _id ?? 0,   // ignorado en Crear
                Nombre = nombre,
                Telefono = telDigits,
                RFC = rfc,
                Email = email,
                Direccion = dir,
                Activo = true
            };

            return true;
        }
    }
}
