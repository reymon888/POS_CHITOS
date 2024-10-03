using Microsoft.EntityFrameworkCore;
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
    public partial class V_AgregarEntrada : Form
    {
        private readonly EntradaEfectivoService _entradaEfectivoService;
        private readonly int _idUsuario; // Usuario logueado
        private readonly int _idCorte; // Corte actual en curso
        public V_AgregarEntrada(int idUsuario, EntradaEfectivoService entradaEfectivoService)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
         

            var context = new POSContext(new DbContextOptions<POSContext>());
            _entradaEfectivoService = new EntradaEfectivoService(context);
        }
       

        private void B_CrearProducto_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox u otros controles
            string concepto = TB_Concepto.Text;
            if (float.TryParse(TB_Monto.Text, out float monto) && monto > 0)
            {
                // Registrar la entrada de efectivo
                // Ejemplo de cómo estás llamando al método:
                _entradaEfectivoService.RegistrarEntradaEfectivo(_idUsuario, concepto, monto, 1);


                MessageBox.Show("Entrada de efectivo registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra la ventana después de registrar la entrada
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
