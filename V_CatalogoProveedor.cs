using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Inventario;
using POS_CHITOS.PI;
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
    public partial class V_CatalogoProveedor : Form
    {
        private readonly int _idProveedor;
        private readonly ProveedoresInventarioService _proveedoresInventarioService;
        private readonly inventarioService _inventarioService;
        public V_CatalogoProveedor(int idProveedor)
        {
            InitializeComponent();

            _idProveedor = idProveedor;
            var context = new POSContext(new DbContextOptions<POSContext>());
            _proveedoresInventarioService = new ProveedoresInventarioService(context);
            _inventarioService = new inventarioService(context);
            // Cargar datos del proveedor y catálogo
            CargarDatosProveedor();
            CargarCatalogoProveedor();
            PersonalizarTablaCatalogo();
        }

        private void V_CatalogoProveedor_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatosProveedor()
        {
            // Obtener los datos básicos del proveedor (ejemplo)
            var proveedor = _proveedoresInventarioService.ObtenerProveedorPorId(_idProveedor);
            if (proveedor != null)
            {
                TB_Proveedor.Text = proveedor.NombreProveedor;
                TB_Telefono.Text = proveedor.TelefonoProveedor;
                TB_Correo.Text = proveedor.CorreoElectronico;
                TB_Direccion.Text = proveedor.DireccionProveedor;
            }
        }

        private void CargarCatalogoProveedor()
        {
            var catalogo = _proveedoresInventarioService.ObtenerProductosPorProveedor(_idProveedor);
            DGV_Catalogo.DataSource = catalogo;
        }

        private void PersonalizarTablaCatalogo()
        {
            try
            {
                var catalogo = _proveedoresInventarioService.ObtenerProductosPorProveedor(_idProveedor);
                DGV_Catalogo.DataSource = catalogo;

                // Configurar los nombres de las columnas y ocultar las que no necesitas
                if (DGV_Catalogo.Columns["IdPI"] != null)
                    DGV_Catalogo.Columns["IdPI"].HeaderText = "ID";

                if (DGV_Catalogo.Columns["IdProveedor"] != null)
                    DGV_Catalogo.Columns["IdProveedor"].Visible = false; // Ocultar columna de Proveedor

                if (DGV_Catalogo.Columns["CodigoProducto"] != null)
                {
                    DGV_Catalogo.Columns["CodigoProducto"].HeaderText = "Código Producto";
                    DGV_Catalogo.Columns["CodigoProducto"].Width = 150;
                }

                if (DGV_Catalogo.Columns["DescripcionProducto"] != null)
                {
                    DGV_Catalogo.Columns["DescripcionProducto"].HeaderText = "Nombre del Producto";
                    DGV_Catalogo.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Ocupar espacio sobrante
                }

                if (DGV_Catalogo.Columns["PrecioCompra"] != null)
                {
                    DGV_Catalogo.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                    DGV_Catalogo.Columns["PrecioCompra"].Visible = false; // Ocultar columna de Precio Compra
                }
                //poner invisible la columna de precio compra


                if (DGV_Catalogo.Columns["Estado"] != null)
                {
                    DGV_Catalogo.Columns["Estado"].HeaderText = "Estado";
                    DGV_Catalogo.Columns["Estado"].Width = 100;
                }

                // Configurar la fuente de las celdas
                DGV_Catalogo.DefaultCellStyle.Font = new Font("Arial", 14);

                // Configurar el encabezado
                DGV_Catalogo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

                // Configurando colores y estilos de las celdas
                DGV_Catalogo.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Fondo blanco para las celdas
                DGV_Catalogo.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua
                DGV_Catalogo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro para los encabezados
                DGV_Catalogo.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Texto blanco para los encabezados

                DGV_Catalogo.EnableHeadersVisualStyles = false; // Desactivar estilos predeterminados

                // Alternar colores de las filas
                DGV_Catalogo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro para las filas alternas
                DGV_Catalogo.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);

                // Centrar el texto en las celdas
                DGV_Catalogo.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_Catalogo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Eliminar bordes de las celdas y encabezados
                DGV_Catalogo.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DGV_Catalogo.RowHeadersVisible = false;

                // Limpiar la selección inicial del `DataGridView`
                DGV_Catalogo.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el catálogo del proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void B_AgregarProducto_Click(object sender, EventArgs e)
        {
            // Abrir la ventana de selección de productos del inventario
            var seleccionarProductosForm = new V_AgregarInventarioCatalogo(_inventarioService, _idProveedor);
            if (seleccionarProductosForm.ShowDialog() == DialogResult.OK)
            {
                var productosSeleccionados = seleccionarProductosForm.ProductosSeleccionados;

                // Llamar a un método para agregar los productos al catálogo del proveedor
                foreach (var producto in productosSeleccionados)
                {
                    var nuevoProductoProveedor = new ProveedoresInventario
                    {
                        IdProveedor = _idProveedor,
                        CodigoProducto = producto.CodigoProducto,
                        PrecioCompra = producto.PrecioCompra,
                        Estado = "Activo"
                    };


                    _proveedoresInventarioService.AgregarProductoAProveedor(nuevoProductoProveedor);
                }

                // Recargar el catálogo
                CargarCatalogoProveedor();
            }
        }

        private void B_DarBaja_Click(object sender, EventArgs e)
        {
            // usar el service public void CambiarEstadoCatalogo(int idProveedor, string nuevoEstado) para cambiar el estado del catálogo seleccionado de Activo a Inactivo y viceversa
            // Cambiar el estado del catálogo seleccionado y preguntar si esta seguro y asi
            // Cambiar el estado del catálogo seleccionado y preguntar si esta seguro y asi
            if (DGV_Catalogo.SelectedRows.Count > 0)
            {
                var confirmacion = MessageBox.Show("¿Estás seguro de cambiar el estado del producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    var idPI = (int)DGV_Catalogo.SelectedRows[0].Cells["IdPI"].Value;
                    var estadoActual = DGV_Catalogo.SelectedRows[0].Cells["Estado"].Value.ToString();
                    var nuevoEstado = estadoActual == "Activo" ? "Inactivo" : "Activo";

                    _proveedoresInventarioService.CambiarEstadoProducto(idPI, nuevoEstado);
                    CargarCatalogoProveedor();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto del catálogo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Metodo para atajos que no sea keydown y use control al inicio
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarProducto.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_DarBaja.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarProveedor.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                CargarCatalogoProveedor();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }





        private void TB_BuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            //Cada que escriba el nombre de un producto en el textbox se va a buscar en la base de datos y se va a mostrar en el datagridview y si borro todo volver a cargar todos los productos
            if (e.KeyCode == Keys.Enter)
            {
                var nombreProducto = TB_BuscarProveedor.Text;
                if (string.IsNullOrWhiteSpace(nombreProducto))
                {
                    CargarCatalogoProveedor();
                }
                else
                {
                    var productos = _proveedoresInventarioService.ObtenerProductosPorProveedor(_idProveedor);
                    var productosFiltrados = productos.Where(p => p.DescripcionProducto.ToLower().Contains(nombreProducto.ToLower())).ToList();
                    DGV_Catalogo.DataSource = productosFiltrados;
                }
            }
        }

        //buscar idproveedor por nombre

    }
}
