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
            rb_contado.Checked = true;
            logicaVenta();




        }


        void logicaVenta()
        {
            // Aqui se trabajara la logica de la venta, tener en cuenta cada parametro si el rb es contado o credito, si es credito se desactivan los parametros de contado y se activa los de credito y viceversa
            pCredito.Enabled = false;
            pCredito.Visible = false;
            pContado.Enabled = true;
            pContado.Visible = true;


            if (rb_contado.Checked)
            {
                // Logica para venta al contado, activar el pContado y desactivar el pCredito
                pContado.Enabled = true;
                pCredito.Enabled = false;
                pContado.Visible = true;
                pCredito.Visible = false;

            }
            else if (rb_credito.Checked)
            {
                // Logica para venta a credito, activar el pCredito y desactivar el pContado
                pContado.Enabled = false;
                pCredito.Enabled = true;
                pContado.Visible = false;
                pCredito.Visible = true;




            }


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

        private void rb_contado_CheckedChanged(object sender, EventArgs e)
        {
            logicaVenta();
        }

        private void rb_credito_CheckedChanged(object sender, EventArgs e)
        {
            logicaVenta();
        }

        private void pContado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
