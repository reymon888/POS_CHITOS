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
    public partial class V_MostrarCambio : Form
    {
        public V_MostrarCambio(float cambio)
        {
            InitializeComponent();
            TB_Cambio.Text = cambio.ToString("C2");
            //centrar ventana y no permitir cambiar tamaño
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        private void B_Confirmar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_Cambio_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
