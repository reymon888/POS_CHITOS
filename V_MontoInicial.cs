using POS_CHITOS.Avisos;
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
    public partial class V_MontoInicial : Form
    {
        private readonly int _idUsuario;
        private readonly CortesService _cortesService;
        public V_MontoInicial(int idUsuario, CortesService cortesService)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _cortesService = cortesService;

            // Centrar la ventana
            this.StartPosition = FormStartPosition.CenterScreen;
            // No cambiar tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResumeLayout(false);
          

        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mejor usa decimal para dinero y TryParse con cultura
                if (!decimal.TryParse(TB_MontoInicial.Text,
                                      System.Globalization.NumberStyles.Number,
                                      System.Globalization.CultureInfo.CurrentCulture,
                                      out var montoInicial))
                {
                    MessageBox.Show("Monto inválido.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var corteVigente = _cortesService.ObtenerCorteNoRealizado(_idUsuario);
                if (corteVigente != null)
                {
                    MessageBox.Show("Ya tienes un corte abierto.", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _cortesService.CrearCorteNuevo(_idUsuario, (float)montoInicial);

                // <<< CLAVE: devolver OK para que Main sepa que ya abrió
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el corte de caja: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void V_MontoInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
           

        }

        private void V_MontoInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
