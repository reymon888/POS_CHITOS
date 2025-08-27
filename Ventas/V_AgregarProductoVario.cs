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
    public partial class V_AgregarProductoVario : Form
    {
        public string DescripcionProducto { get; private set; }
        public float PrecioProducto { get; private set; }
        public V_AgregarProductoVario()
        {
            InitializeComponent();
        }

        private void B_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TB_DescripcionProducto.Text))
            {
                MessageBox.Show("La descripción del producto es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }


            // Asignar los valores a las propiedades y cerrar el formulario
            DescripcionProducto = TB_DescripcionProducto.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
