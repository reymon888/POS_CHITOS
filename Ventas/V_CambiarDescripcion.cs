using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Ventas
{
    public partial class V_CambiarDescripcion : Form
    {// Propiedad para obtener el nuevo nombre ingresado
        public string NuevoNombre { get; private set; }
        public V_CambiarDescripcion(string descripcionActual)
        {
            InitializeComponent();
            // Inicializar el TextBox con la descripción actual
            TB_Nombre.Text = descripcionActual;

            // Enfocar el TextBox para que el usuario pueda empezar a editar
            TB_Nombre.Focus();
            TB_Nombre.SelectAll(); // Seleccionar todo el texto para facilitar la edición
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            // Validar que el nuevo nombre no esté vacío
            if (!string.IsNullOrEmpty(TB_Nombre.Text.Trim()))
            {
                // Guardar el nuevo nombre
                NuevoNombre = TB_Nombre.Text.Trim();

                // Retornar resultado OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Mostrar mensaje de advertencia si el nombre está vacío
                MessageBox.Show("Por favor ingrese un nombre válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
