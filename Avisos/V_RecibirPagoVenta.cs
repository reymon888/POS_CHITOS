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
    }
}
