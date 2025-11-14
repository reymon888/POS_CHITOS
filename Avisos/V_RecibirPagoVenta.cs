using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS
{
    public partial class V_RecibirPagoVenta : Form
    {
        public float PagoRecibido { get; private set; }
        public float Cambio { get; private set; }
        public string MetodoPago { get; private set; } = "EFECTIVO";
        private readonly float totalVenta;
        public V_RecibirPagoVenta(float totalVenta)
        {
            InitializeComponent();
            this.totalVenta = totalVenta;

            TB_TotalCobrar.Text = totalVenta.ToString("C2");

            // Llenar combo
            CB_TipoPago.Items.Clear();
            CB_TipoPago.Items.AddRange(new object[] { "EFECTIVO", "TARJETA", "TRANSFERENCIA" });
            CB_TipoPago.SelectedIndex = 0;

            // Eventos
            CB_TipoPago.SelectedIndexChanged += CB_TipoPago_SelectedIndexChanged;
            TB_PagoRecibido.KeyPress += TB_PagoRecibido_KeyPress;
            TB_PagoRecibido.TextChanged += TB_PagoRecibido_TextChanged;

            // Ajustes de ventana
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            // Estado inicial (efectivo)
            ModoEfectivo();
        }
        private void ModoEfectivo()
        {
            MetodoPago = "EFECTIVO";
            TB_PagoRecibido.Enabled = true;
            TB_PagoRecibido.Text = "";     // vacío para que el cajero escriba
            TB_Cambio.Text = "$0.00";
            TB_PagoRecibido.Focus();
        }

        private void ModoNoEfectivo(string metodo)
        {
            MetodoPago = metodo;           // "TARJETA" o "TRANSFERENCIA"
            TB_PagoRecibido.Enabled = false;
            TB_PagoRecibido.Text = totalVenta.ToString("0.00"); // igual al total
            TB_Cambio.Text = "$0.00";      // sin cambio
        }


        private void B_Confirmar_Click(object sender, EventArgs e)
        {
            if (MetodoPago == "EFECTIVO")
            {
                if (!float.TryParse(TB_PagoRecibido.Text, out float pago) || pago < totalVenta)
                {
                    MessageBox.Show("Ingrese un pago en EFECTIVO mayor o igual al total.",
                        "Pago inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PagoRecibido = pago;
                Cambio = pago - totalVenta;
            }
            else // TARJETA o TRANSFERENCIA
            {
                PagoRecibido = totalVenta;
                Cambio = 0f;
            }

            // Sin modal de “mostrar cambio”; ya lo ves en TB_Cambio
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TB_PagoRecibido_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Permitir solo números, un punto y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox)?.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pContado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void CB_TipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sel = CB_TipoPago.SelectedItem?.ToString() ?? "EFECTIVO";
            if (sel == "EFECTIVO") ModoEfectivo();
            else ModoNoEfectivo(sel);
        }

        private void TB_PagoRecibido_TextChanged(object sender, EventArgs e)
        {
            if (MetodoPago != "EFECTIVO")
            {
                TB_Cambio.Text = "$0.00";
                return;
            }

            if (float.TryParse(TB_PagoRecibido.Text, out float pago))
            {
                var cambio = Math.Max(0f, pago - totalVenta);
                TB_Cambio.Text = cambio.ToString("C2");
            }
            else
            {
                TB_Cambio.Text = "$0.00";
            }
        }
    }
}
