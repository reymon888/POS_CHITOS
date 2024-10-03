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
    public partial class V_CreateInventario : Form
    {
        readonly inventarioService _inventarioService;

        public V_CreateInventario()
        {
            InitializeComponent();
            var context = new POSContext(new DbContextOptions<POSContext>());  // Asegúrate de que el contexto esté bien configurado
            _inventarioService = new inventarioService(context);

            TB_CodigoProducto.Focus();

            //aparecer en el centro
            StartPosition = FormStartPosition.CenterScreen;

            //no se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //cambiar el nombre de la ventana a nuevo producto 
            this.Text = "Nuevo Producto";
            this.ResumeLayout(false);


        }




        private void B_CrearProducto_Click(object sender, EventArgs e)
        {
            string CodigoProducto = TB_CodigoProducto.Text;
            string DescripcionProducto = TB_DescripcionProducto.Text;
            int Stock = Convert.ToInt32(TB_Stock.Text);
            float PrecioVenta = float.Parse(TB_PrecioVenta.Text);
            string Estante = TB_Estante.Text;

            //Validar que los campos no esten vacios
            if (string.IsNullOrEmpty(CodigoProducto) || string.IsNullOrEmpty(DescripcionProducto) || string.IsNullOrEmpty(TB_Stock.Text) || string.IsNullOrEmpty(TB_PrecioVenta.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos.");
                return;
            }

            //Validar que el stock y el precio sean mayores a 0
            if ( PrecioVenta <= 0)
            {
                MessageBox.Show("El precio deben ser mayores a 0.");
                return;
            }

            //Validar que el producto no exista
            var producto = _inventarioService.ObtenerProductoPorCodigo(CodigoProducto);
            if (producto != null)
            {
                MessageBox.Show("El producto ya existe.");
                return;
            }

            //Crear el producto
            _inventarioService.crearProducto(CodigoProducto, DescripcionProducto, Stock, PrecioVenta, Estante);
            MessageBox.Show("Producto creado correctamente, recarga la ventana.");
            this.Close();


        }

        private void TB_Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo numeros, no simbolos ni letras
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TB_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Acepta numeros y un punto para los decimales
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !TB_PrecioVenta.Text.Contains("."))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            //Cerrar la ventana
            this.Close();

        }
    }
}
