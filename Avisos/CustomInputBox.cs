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
    public partial class CustomInputBox : Form
    {
        public float Resultado { get; private set; }
        public CustomInputBox(string message, string title, float valorInicial)
        {
            InitializeComponent();

            lblMessage.Text = message;
            this.Text = title;
            TB_Input.Text = valorInicial.ToString();

            // Ajustes de diseño
            lblMessage.Font = new Font("Segoe UI", 14);


            // Evitar cambiar tamaño de la ventana y quitar botones maximizar/minimizar
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            TB_Input.Focus();
        }

        public static DialogResult Show(string message, string title, float valorInicial, out float resultado)
        {
            CustomInputBox inputBox = new CustomInputBox(message, title, valorInicial);
            DialogResult dialogResult = inputBox.ShowDialog();
            resultado = inputBox.Resultado;
            return dialogResult;
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            if (float.TryParse(TB_Input.Text, out float valor))
            {
                Resultado = valor;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void TB_Input_KeyDown(object sender, KeyEventArgs e)
        {
            //Solo permtiri numeros no decimales y la tecla de retroceso
            if (!char.IsControl((char)e.KeyCode) && !char.IsDigit((char)e.KeyCode))
            {
                e.Handled = true;
            }

        }
    }
}
