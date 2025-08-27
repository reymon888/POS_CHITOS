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
    public partial class V_ModificarSalidaEfectivo : Form
    {
        private readonly int _idSalida;
        private readonly SalidaEfectivoService _salidaEfectivoService;
        public V_ModificarSalidaEfectivo(int idSalida,string concepto, float monto, SalidaEfectivoService salidaEfectivoService)
        {
            InitializeComponent();


            //Centrar el formulario
            this.StartPosition = FormStartPosition.CenterScreen;
            _idSalida = idSalida;
            _salidaEfectivoService = salidaEfectivoService;

            //Llenar los campos
            TB_Concepto.Text = concepto;
            TB_Monto.Text = monto.ToString();
        }

        private void B_ModificarSalida_Click(object sender, EventArgs e)
        {
            //Modificar la salida de efectivo por medio del service
            string nuevoConcepto = TB_Concepto.Text;
            if (float.TryParse(TB_Monto.Text, out float nuevoMonto) && nuevoMonto > 0)
            {
                _salidaEfectivoService.ModificarSalida(_idSalida, nuevoConcepto, nuevoMonto);

                MessageBox.Show("Salida de efectivo modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //Cerrar la ventana después de modificar la salida
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            //Cerrar la ventana
            this.Close();
        }
    }
}
