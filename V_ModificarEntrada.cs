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
    public partial class V_ModificarEntrada : Form
    {
        private readonly int _idEntrada;
        private readonly EntradaEfectivoService _entradaEfectivoService;
        public V_ModificarEntrada(int idEntrada, string concepto, float monto, EntradaEfectivoService entradaEfectivoService)
        {
            InitializeComponent();
            _idEntrada = idEntrada;
            _entradaEfectivoService = entradaEfectivoService;



            //Asignar los valores a los controles
            TB_Concepto.Text = concepto;
            TB_Monto.Text = monto.ToString();

            //Centrar el formulario
            StartPosition = FormStartPosition.CenterScreen;

            //No se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }



        private void ModificarEntrada()
        {
            //Obtener los valores modificados del formulario
            string nuevoConcepto = TB_Concepto.Text;
            if (float.TryParse(TB_Monto.Text, out float nuevoMonto) && nuevoMonto > 0)
            {
                //Llamar al método para modificar la entrada de efectivo
                _entradaEfectivoService.ModificarEntrada(_idEntrada, nuevoConcepto, nuevoMonto);

                MessageBox.Show("Entrada de efectivo modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //Cerrar la ventana después de modificar la entrada
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            ModificarEntrada();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            //Preguntar al usuario si desea cancelar la modificación
            var respuesta = MessageBox.Show("¿Está seguro que desea cancelar la modificación de la entrada de efectivo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close(); //Cerrar la ventana
            }
        }
    }
}
