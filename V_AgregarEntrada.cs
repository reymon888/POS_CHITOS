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
        private readonly CortesService _corteService;
        private readonly int _idUsuario; // Usuario logueado
        private readonly int _idCorte; // Corte actual en curso
        public V_AgregarEntrada(int idUsuario, EntradaEfectivoService entradaEfectivoService)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
         

            var context = new POSContext(new DbContextOptions<POSContext>());
            _entradaEfectivoService = new EntradaEfectivoService(context);
            _corteService = new CortesService(context);

            //Centrar el formulario
            StartPosition = FormStartPosition.CenterScreen;

            //No se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


        }


        private void B_CrearProducto_Click(object sender, EventArgs e)
        {
            string concepto = TB_Concepto.Text;

            if (float.TryParse(TB_Monto.Text, out float monto) && monto > 0)
            {
                // Obtener el corte activo del usuario actual
                var corteVigente = _corteService.ObtenerCorteNoRealizado(_idUsuario);

                if (corteVigente == null)
                {
                    MessageBox.Show("No hay un corte de caja activo para este usuario. No se puede registrar la entrada de efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Registrar la entrada de efectivo vinculada al corte activo
                _entradaEfectivoService.RegistrarEntradaEfectivo(_idUsuario, concepto, monto, corteVigente.IdCorte);

                MessageBox.Show("Entrada de efectivo registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
