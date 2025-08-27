using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Avisos
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message, string title)
        {
            InitializeComponent();
            lblMessage.Text = message;
            this.Text = title;

            // Establecer la fuente y el tamaño de letra del label


            //Que no se pueda cambiar el tamaño de la ventana y que no aparezca el boton de maximizar ni minimizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResumeLayout(false);

            this.StartPosition = FormStartPosition.CenterScreen;
            B_OK.Click += new EventHandler(B_OK_Click);

        }

        // Método estático para mostrar el MessageBox personalizado
        public static DialogResult Show(string message, string title)
        {
            CustomMessageBox messageBox = new CustomMessageBox(message, title);
            return messageBox.ShowDialog();
        }



        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes; // Cambiar de OK a Yes
            this.Close();
        }
    }
}
