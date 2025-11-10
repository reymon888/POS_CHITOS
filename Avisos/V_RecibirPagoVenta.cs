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
        private float totalVenta;
        public V_RecibirPagoVenta(float totalVenta)
        {
            InitializeComponent();
            this.totalVenta = totalVenta;
            TB_TotalCobrar.Text = totalVenta.ToString("C2");
            TB_PagoRecibido.KeyPress += TB_PagoRecibido_KeyPress;
            //Desactivar las funcionalidades del marco de la ventana 

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // sin resize
            this.MaximizeBox = false;   // quita maximizar
            this.MinimizeBox = false;   // quita minimizar
            this.ControlBox = false;   // quita botón Cerrar y menú del sistema
            this.StartPosition = FormStartPosition.CenterScreen;
        }
         

        private void B_Confirmar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TB_PagoRecibido.Text, out float pagoRecibido) && pagoRecibido >= totalVenta)
            {
                PagoRecibido = pagoRecibido;
                Cambio = pagoRecibido - totalVenta;

                // Mostrar la ventana de cambio aquí
                using (var mostrarCambio = new V_MostrarCambio(Cambio))
                {
                    mostrarCambio.ShowDialog();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un pago válido y que sea mayor o igual al total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
