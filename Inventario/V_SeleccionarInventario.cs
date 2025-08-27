using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Inventario
{
    public partial class V_SeleccionarInventario : Form
    {
        private readonly inventarioService _inventarioService;
        private List<InventarioDTO> _productos;  // Lista completa de productos
        private string selectedCodigoProducto;  // Para almacenar el producto seleccionado

        // Propiedad pública para devolver el producto seleccionado
        public InventarioDTO ProductoSeleccionado { get; private set; }
        public V_SeleccionarInventario(inventarioService inventarioService)
        {
            InitializeComponent();

            _inventarioService = inventarioService;

            // Cargar los productos en la tabla al abrir la ventana
            CargarProductos();

            // Suscribir el evento para el filtro
            TB_BuscarProducto.TextChanged += TB_BuscarProducto_TextChanged;

            // Asegurarse de que ningún producto esté seleccionado al inicio
            DGV_Inventario.ClearSelection();


        }

        private void CargarProductos(List<InventarioDTO> productosFiltrados = null)
        {
            // Obtener la lista de productos desde el servicio si no se pasa una lista filtrada
            _productos = productosFiltrados ?? _inventarioService.listarInventarioDTO();

            // Asignar la lista al DataGridView
            DGV_Inventario.DataSource = null;
            DGV_Inventario.DataSource = _productos;

            // Configurar las columnas del DataGridView
            ConfigurarColumnas();
        }

        private void ConfigurarColumnas()
        {
            DGV_Inventario.AutoGenerateColumns = false;
            DGV_Inventario.Columns.Clear();

            // Columna de Código
            DGV_Inventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CodigoProducto",
                HeaderText = "Código",
                Width = 150
            });

            // Columna de Descripción
            DGV_Inventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DescripcionProducto",
                HeaderText = "Descripción",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Columna de Precio
            DGV_Inventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecioVenta",
                HeaderText = "Precio",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Columna de Stock
            DGV_Inventario.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stock",
                HeaderText = "Stock",
                Width = 80
            });

            personalizarTabla();    
        }

        private void TB_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            // Filtrar los productos conforme el usuario va escribiendo
            string filtro = TB_BuscarProducto.Text.ToLower();

            var productosFiltrados = _productos
                .Where(p => p.CodigoProducto.ToLower().Contains(filtro) ||
                            p.DescripcionProducto.ToLower().Contains(filtro))
                .ToList();

            // Actualizar la tabla con los productos filtrados
            CargarProductos(productosFiltrados);
        }

        private void B_Aceptar_Click(object sender, EventArgs e)
        {
            if (DGV_Inventario.SelectedRows.Count > 0)
            {
                // Obtener el producto seleccionado
                ProductoSeleccionado = (InventarioDTO)DGV_Inventario.SelectedRows[0].DataBoundItem;

                // Aquí puedes pasar el producto seleccionado de vuelta al formulario de ventas
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto.", "Producto no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void personalizarTabla() {
            // Configurar la fuente de las celdas
            DGV_Inventario.DefaultCellStyle.Font = new Font("Arial", 14);




            // Configurar el encabezado
            DGV_Inventario.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            // Configurando el fondo y el color de texto de las celdas normales
            DGV_Inventario.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Fondo blanco para las celdas
            DGV_Inventario.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua

            // Configurando el fondo y el color de texto de los encabezados de las columnas
            DGV_Inventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro para los encabezados
            DGV_Inventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Texto blanco para los encabezados

            // Asegurando que la tabla no use colores predeterminados del sistema para garantizar la consistencia
            DGV_Inventario.EnableHeadersVisualStyles = false;

            // Otras configuraciones visuales que podrías querer ajustar
            DGV_Inventario.BorderStyle = BorderStyle.None; // Sin borde (opcional)
            DGV_Inventario.GridColor = Color.FromArgb(200, 200, 200); // Color del grid ajustado para mejor contraste (opcional)
            DGV_Inventario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Estilo del borde del encabezado

            //alternar colores de las filas una blanca y otra gris claro




            DGV_Inventario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro para las filas alternas
            DGV_Inventario.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua
            DGV_Inventario.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 140, 153); // Fondo verde agua para la fila seleccionada

            // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
            DGV_Inventario.EnableHeadersVisualStyles = false;  // Desactivar los estilos visuales del sistema para los encabezados
            DGV_Inventario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro igual al normal
            DGV_Inventario.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco igual al normal


            // No tener el DGV seleccionado
            DGV_Inventario.ClearSelection();

            //Poner el contenido de la tabla en medio
            DGV_Inventario.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Inventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Eliminar el contorno de las celdas
            DGV_Inventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_Inventario.RowHeadersVisible = false;
        }
    }
}
