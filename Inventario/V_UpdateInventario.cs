using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Inventario;
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
        public V_UpdateInventario(string codigoProducto, inventarioService inventarioService)
        {
            InitializeComponent();

            _inventarioService = inventarioService;

            _CodigoProducto = codigoProducto;  // Asigna el código del producto a la propiedad privada
            TB_CodigoProducto.Text = codigoProducto;  // Muestra el código del producto en el TextBox

           

            //aparecer en el centro
            StartPosition = FormStartPosition.CenterScreen;

            //no se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            this.ResumeLayout(false);


            // Forzar el foco en el campo de descripción
            TB_DescripcionProducto.Focus();

            CargarCategorias();
            // Llama a la función para cargar los datos del producto
            mostrarDatosProducto();
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

       private void validar()
        {
            // Validar que los campos no estén vacíos excepto stock
            if (TB_CodigoProducto.Text == "" || TB_DescripcionProducto.Text == "" || TB_PrecioVenta.Text == "")
            {
                CustomMessageBox.Show("Todos los campos son obligatorios.", "Advertencia");
            }
            else
            {
                // validar si el stock no tiene un valor numérico, que se tome como un 0
                if (string.IsNullOrEmpty(TB_Stock.Text))
                {
                    TB_Stock.Text = "0";
                }
                else
                {
                    // Validar que el precio de venta sea mayor o igual al precio de compra del producto y preguntarle al usuario si desea continuar
                    if (float.Parse(TB_PrecioVenta.Text) < float.Parse(TB_PrecioCompra.Text))
                    {
                        DialogResult dialogResult = CustomMessageBox.Show("El precio de venta es menor al precio de compra, ¿Desea continuar?", "Advertencia");
                        if (dialogResult == DialogResult.Yes)
                        {
                            modificarProducto();
                        }
                    }
                    else
                    {
                        modificarProducto(); // Si no hay discrepancias, modificar directamente el producto
                    }
                }
            }
        }

        private void B_ModificarProducto_Click(object sender, EventArgs e)
        {
            validar();
        }

        private void modificarProducto()
        {
            try
            {
                // Validar los datos
                if (string.IsNullOrWhiteSpace(TB_CodigoProducto.Text) || string.IsNullOrWhiteSpace(TB_DescripcionProducto.Text) || string.IsNullOrWhiteSpace(TB_PrecioVenta.Text))
                {
                    CustomMessageBox.Show("Todos los campos son obligatorios.", "Advertencia");
                    return;
                }

                // Obtener la categoría seleccionada correctamente
                int? idCategoria = (CB_Categoria.SelectedValue != null && (int)CB_Categoria.SelectedValue > 0)
                    ? (int?)CB_Categoria.SelectedValue
                    : null;  // Si la categoría es "Sin Asignar", establecer null

                // Intentar modificar el producto en la base de datos
                _inventarioService.modificarProducto(TB_CodigoProducto.Text, TB_DescripcionProducto.Text, Convert.ToInt32(TB_Stock.Text), float.Parse(TB_PrecioVenta.Text), TB_Estante.Text.Trim(), idCategoria);

                CustomMessageBox.Show("Producto modificado correctamente.", "Confirmación");
                this.DialogResult = DialogResult.OK;  // Establecer resultado para indicar éxito
                this.Close();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error al modificar el producto: {ex.Message}", "Error");
            }
        }

        // Mostrar los datos del producto
        private void mostrarDatosProducto()
        {
            var producto = _inventarioService.ObtenerProductoPorCodigo(_CodigoProducto);
            if (producto != null)
            {
                TB_DescripcionProducto.Text = producto.DescripcionProducto;
                TB_Stock.Text = producto.Stock.ToString();
                TB_PrecioVenta.Text = producto.PrecioVenta.ToString();
                TB_Estante.Text = producto.Estante;

                // Mostrar el último precio de compra
                TB_PrecioCompra.Text = producto.PrecioCompra.ToString();

                // Asignar la categoría seleccionada (si es null, selecciona 'Sin Asignar')
                CB_Categoria.SelectedValue = producto.IdCategoria ?? 0;
            }
            else
            {
                CustomMessageBox.Show("Producto no encontrado.", "Error");
            }
        }



        private void CargarCategorias()
        {
            var categorias = _inventarioService.ObtenerCategoriasHabilitadas();
            categorias.Insert(0, new CategoriaInventario { IdCategoria = 0, NombreCategoria = "Sin Asignar" });

            // Asignar la lista de categorías al ComboBox
            CB_Categoria.DataSource = categorias;

            // Establecer el DisplayMember y ValueMember
            CB_Categoria.DisplayMember = "NombreCategoria";  // Lo que se mostrará en el ComboBox
            CB_Categoria.ValueMember = "IdCategoria";        // El valor subyacente de cada ítem
        }

        private void B_ModificarProducto_Click_1(object sender, EventArgs e)
        {
            validar();
        }
    }
}
