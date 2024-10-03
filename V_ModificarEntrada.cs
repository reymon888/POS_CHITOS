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
        }

        private void B_ModificarEntrada_Click(object sender, EventArgs e)
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
    }
}
