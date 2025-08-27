using Microsoft.EntityFrameworkCore;
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




            this.ResumeLayout(false);


            CargarCategorias();


          


        }
        private void RegistrarProducto()
        {
            // Obtener valores de los campos y eliminar espacios antes y después con Trim
            string CodigoProducto = TB_CodigoProducto.Text.Trim();
            string DescripcionProducto = TB_DescripcionProducto.Text.Trim();
            string Estante = TB_Estante.Text.Trim();

            // Validar que el código de producto no esté vacío
            if (string.IsNullOrEmpty(CodigoProducto))
            {
                MessageBox.Show("El código de producto es obligatorio.");
                return;
            }

            // Validar que la descripción no esté vacía
            if (string.IsNullOrEmpty(DescripcionProducto))
            {
                MessageBox.Show("La descripción del producto es obligatoria.");
                return;
            }

            // Si el campo Stock está vacío, asignar 0
            int Stock;
            if (string.IsNullOrEmpty(TB_Stock.Text.Trim()))
            {
                Stock = 0;
            }
            else if (!int.TryParse(TB_Stock.Text.Trim(), out Stock))
            {
                MessageBox.Show("El valor de Stock debe ser un número entero.");
                return;
            }

            // Validar que el precio no esté vacío y sea un valor numérico mayor que 0
            float PrecioVenta;
            if (string.IsNullOrEmpty(TB_PrecioVenta.Text.Trim()) || !float.TryParse(TB_PrecioVenta.Text.Trim(), out PrecioVenta) || PrecioVenta <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor a 0.");
                return;
            }

            // Validar que el producto no exista
            var producto = _inventarioService.ObtenerProductoPorCodigo(CodigoProducto);
            if (producto != null)
            {
                MessageBox.Show("El producto ya existe.");
                return;
            }

            // Obtener la categoría seleccionada
            int? idCategoria = CB_Categoria.SelectedValue != null && int.TryParse(CB_Categoria.SelectedValue.ToString(), out int id)
    ? (id > 0 ? id : (int?)null)
    : (int?)null;


            // Crear el producto en el inventario, pasando idCategoria como nullable
            _inventarioService.crearProducto(CodigoProducto, DescripcionProducto, Stock, PrecioVenta, Estante, idCategoria);
            MessageBox.Show("Producto creado correctamente.");
            this.Close();
        }


        private void B_CrearProducto_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
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

        private void CargarCategorias()
        {
            var categorias = _inventarioService.ObtenerCategoriasHabilitadas();
            categorias.Insert(0, new CategoriaInventario { IdCategoria = 0, NombreCategoria = "Sin Asignar" });

            CB_Categoria.DataSource = categorias;
            CB_Categoria.DisplayMember = "NombreCategoria";
            CB_Categoria.ValueMember = "IdCategoria";

            // Establecer un valor predeterminado si lo deseas
            CB_Categoria.SelectedIndex = 0;
        }



    }
}
