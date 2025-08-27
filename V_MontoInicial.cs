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
                float montoInicial = float.Parse(TB_MontoInicial.Text);

                // Verificar si ya existe un corte abierto para este usuario
                var corteVigente = _cortesService.ObtenerCorteNoRealizado(_idUsuario);

                if (corteVigente != null)
                {
                    MessageBox.Show("Ya tienes un corte abierto. No se puede crear un nuevo corte hasta que cierres el actual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el nuevo corte
                _cortesService.CrearCorteNuevo(_idUsuario, montoInicial);

                MessageBox.Show("Nuevo corte de caja creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el corte de caja: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
