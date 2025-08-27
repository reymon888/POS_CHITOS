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
    public partial class V_AgregarSalidasEfectivo : Form
    {
        private readonly SalidaEfectivoService _salidaEfectivoService;
        private readonly CortesService _corteService;
        private readonly int _idUsuario; // Usuario logueado
        private readonly int _idCorte; // Corte actual en curso
        public V_AgregarSalidasEfectivo(int idUsuario, SalidaEfectivoService salidaEfectivoService)
        {
            InitializeComponent();

            _idUsuario = idUsuario;


            var context = new POSContext(new DbContextOptions<POSContext>());
            _salidaEfectivoService = new SalidaEfectivoService(context);
            _corteService = new CortesService(context);
        }

        private void B_RegistrarSalida_Click(object sender, EventArgs e)
        {
            string concepto = TB_Concepto.Text;
            if (float.TryParse(TB_Monto.Text, out float monto) && monto > 0)
            {
                // Obtener el idCorte vigente
                var corteVigente = _corteService.ObtenerCorteNoRealizado(_idUsuario);
                if (corteVigente == null)
                {
                    MessageBox.Show("No hay un corte de caja activo. No se puede registrar la salida de efectivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Registrar la salida de efectivo con el idCorte actual
                _salidaEfectivoService.RegistrarSalidaEfectivo(_idUsuario, concepto, monto, corteVigente.IdCorte);

                MessageBox.Show("Salida de efectivo registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
