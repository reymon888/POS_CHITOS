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

namespace POS_CHITOS.PI
{
    public partial class V_AgregarInventarioCatalogo : Form
    {
        public List<InventarioDTO> ProductosSeleccionados { get; private set; } = new List<InventarioDTO>();
        private readonly inventarioService _inventarioService;
        private readonly ProveedoresInventarioService _proveedoresInventarioService;
        private readonly int _idProveedor;
        public V_AgregarInventarioCatalogo(inventarioService inventarioService, int idProveedor)
        {
            InitializeComponent();
            _inventarioService = inventarioService;
            var context = new POSContext(new DbContextOptions<POSContext>());
            _proveedoresInventarioService = new ProveedoresInventarioService(context);
            _idProveedor = idProveedor;
            CargarInventarioFiltrado(idProveedor);
        }

        private void CargarInventarioFiltrado(int idProveedor)
        {
            try
            {
                // Obtener el inventario completo
                var inventario = _inventarioService.listarInventarioDTO();

                // Obtener los productos ya asociados con el proveedor
                var catalogoProveedor = _proveedoresInventarioService.ObtenerProductosPorProveedor(idProveedor);
                var codigosProductosCatalogo = catalogoProveedor.Select(p => p.CodigoProducto).ToList();

                // Filtrar el inventario excluyendo los productos ya en el catálogo
                var inventarioFiltrado = inventario.Where(p => !codigosProductosCatalogo.Contains(p.CodigoProducto)).ToList();

                // Asignar el inventario filtrado al DataGridView
                DGV_Inventario.DataSource = inventarioFiltrado;

                // Configurar las columnas visibles y su tamaño
                // Replace the problematic lines with the correct assignment syntax
                DGV_Inventario.Columns["CodigoProducto"].HeaderText = "Código Producto";
                DGV_Inventario.Columns["CodigoProducto"].Width = 150;

                DGV_Inventario.Columns["DescripcionProducto"].HeaderText = "Nombre del Producto";
                DGV_Inventario.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DGV_Inventario.Columns["Stock"].HeaderText = "Stock";
                DGV_Inventario.Columns["Stock"].Width = 80;

                DGV_Inventario.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                DGV_Inventario.Columns["PrecioCompra"].Width = 120;

                DGV_Inventario.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                DGV_Inventario.Columns["PrecioVenta"].Width = 120;

                DGV_Inventario.Columns["Estante"].Visible = false;
                DGV_Inventario.Columns["Estado"].Visible = false;
                DGV_Inventario.Columns["NombreCategoria"].Visible = false;
                DGV_Inventario.Columns["CodigoProducto"].HeaderText = "Código Producto";
                DGV_Inventario.Columns["CodigoProducto"].Width = 150;

                DGV_Inventario.Columns["DescripcionProducto"].HeaderText = "Nombre del Producto";
                DGV_Inventario.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                DGV_Inventario.Columns["Stock"].HeaderText = "Stock";
                DGV_Inventario.Columns["Stock"].Width = 80;

                DGV_Inventario.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                DGV_Inventario.Columns["PrecioCompra"].Width = 120;

                DGV_Inventario.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                DGV_Inventario.Columns["PrecioVenta"].Width = 120;

                // Ocultar columnas no relevantes para esta vista
                DGV_Inventario.Columns["Estante"].Visible = false;
                DGV_Inventario.Columns["Estado"].Visible = false;
                DGV_Inventario.Columns["NombreCategoria"].Visible = false;

                // Estilo de las celdas
                DGV_Inventario.DefaultCellStyle.Font = new Font("Arial", 14);
                DGV_Inventario.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                DGV_Inventario.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);

                // Configuración del encabezado
                DGV_Inventario.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                DGV_Inventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
                DGV_Inventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                DGV_Inventario.EnableHeadersVisualStyles = false;

                // Alternar colores de las filas
                DGV_Inventario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                DGV_Inventario.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
                DGV_Inventario.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 140, 153);

                // Ajustes adicionales
                DGV_Inventario.BorderStyle = BorderStyle.None;
                DGV_Inventario.GridColor = Color.FromArgb(200, 200, 200);
                DGV_Inventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                DGV_Inventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DGV_Inventario.RowHeadersVisible = false;

                // Alineación de contenido en el centro
                DGV_Inventario.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_Inventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Limpiar selección
                DGV_Inventario.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario filtrado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void B_AgregarProducto_Click(object sender, EventArgs e)
        {
            // Limpiar la lista para evitar duplicados si el botón se presiona varias veces
            ProductosSeleccionados.Clear();

            // Obtener los productos seleccionados
            foreach (DataGridViewRow row in DGV_Inventario.SelectedRows)
            {
                var producto = row.DataBoundItem as InventarioDTO;
                if (producto != null)
                {
                    ProductosSeleccionados.Add(producto);
                }
            }

            // Establece el resultado del diálogo como OK si al menos un producto fue seleccionado
            if (ProductosSeleccionados.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Cierra la ventana después de agregar los productos seleccionados
            this.Close();
        }

        private void B_DarBaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
