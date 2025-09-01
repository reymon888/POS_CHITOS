using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
           if(string.IsNullOrWhiteSpace(TB_Nombre.Text))
            { MessageBox.Show("El nombre es obligatorio."/*, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning*/);
                TB_Nombre.Focus(); return; }
            try
            {
                if (Mode == ClienteFormMode.Create) {
                    _svc.Crear(new clientes
                    {
                        Nombre = TB_Nombre.Text.Trim(),
                        Telefono = TB_Telefono.Text.Trim(),
                        RFC = TB_RFC.Text.Trim(),
                        Email = TB_CE.Text.Trim(),
                        Direccion = TB_Direccion.Text.Trim(),
                        Activo = true
                    });

                    
                }
                else
                {
                    _svc.Actualizar(new clientes
                    {
                        IdCliente = _id!.Value,
                        Nombre = TB_Nombre.Text.Trim(),
                        Telefono = TB_Telefono.Text.Trim(),
                        RFC = TB_RFC.Text.Trim(),
                        Email = TB_CE.Text.Trim(),
                        Direccion = TB_Direccion.Text.Trim(),
                        Activo = true // o mantener el estado actual si es necesario
                    });
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar el cliente: " + ex.Message /*, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error*/);
            }
        }
    }
}
