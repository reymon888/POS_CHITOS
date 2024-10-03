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
    public partial class V_UpdateInventario : Form
    {
        readonly inventarioService _inventarioService;
        readonly string _CodigoProducto;
        public V_UpdateInventario(string codigoProducto,inventarioService inventarioService )
        {
            InitializeComponent();
            
            _inventarioService = inventarioService;

            _CodigoProducto = codigoProducto;  // Asigna el código del producto a la propiedad privada
            TB_CodigoProducto.Text = codigoProducto;  // Muestra el código del producto en el TextBox

            // Llama a la función para cargar los datos del producto
            mostrarDatosProducto();

            //aparecer en el centro
            StartPosition = FormStartPosition.CenterScreen;

            //no se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //cambiar el nombre de la ventana a nuevo producto 
            this.Text = "Nuevo Producto";
            this.ResumeLayout(false);


            // Forzar el foco en el campo de descripción
            TB_DescripcionProducto.Focus();


        }

        private void TB_PrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar que solo se ingresen numeros y punto y que al inicio tenga el simbolo de dolar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            //Validar que solo se pueda ingresar un punto
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        void validar()
        {
            //Validar que los campos no esten vacios excepto stock
            if (TB_CodigoProducto.Text == "" || TB_DescripcionProducto.Text == "" || TB_PrecioVenta.Text == "")
            {
                MessageBox.Show("Todos los campos son obligatorios.");
            }
            else
            {
                //validar si el stock no tiene un valor numerico, que se tome como un 0
                if (string.IsNullOrEmpty(TB_Stock.Text))
                {
                    TB_Stock.Text = "0";
                }
                modificarProducto();
            }







        }

        private void B_ModificarProducto_Click(object sender, EventArgs e)
        {
            validar();
        }

        void modificarProducto()
        {
            try
            {
                // Validar los datos
                if (string.IsNullOrWhiteSpace(TB_CodigoProducto.Text) || string.IsNullOrWhiteSpace(TB_DescripcionProducto.Text) || string.IsNullOrWhiteSpace(TB_PrecioVenta.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                // Intentar modificar el producto en la base de datos
                _inventarioService.modificarProducto(TB_CodigoProducto.Text, TB_DescripcionProducto.Text, Convert.ToInt32(TB_Stock.Text), float.Parse(TB_PrecioVenta.Text), TB_Estante.Text.Trim());
                MessageBox.Show("Producto modificado correctamente.");

                this.DialogResult = DialogResult.OK;  // Establecer resultado para indicar éxito
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}");
            }
        }


        //mostrar los datos del producto
        private void mostrarDatosProducto()
        {
            var producto = _inventarioService.ObtenerProductoPorCodigo(_CodigoProducto);
            if (producto != null)
            {
                TB_DescripcionProducto.Text = producto.DescripcionProducto;
                TB_Stock.Text = producto.Stock.ToString();
                TB_PrecioVenta.Text = producto.PrecioVenta.ToString();
                TB_Estante.Text = producto.Estante;
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }




    }
}
