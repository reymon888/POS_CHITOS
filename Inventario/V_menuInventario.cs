using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Inventario;
using POS_CHITOS.Usuarios;
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
    public partial class V_menuInventario : Form
    {
        private readonly inventarioService _inventarioService;
        private string selectedCodigoProducto;
        private BindingList<inventario> bindingList;
        private readonly CategoriaInventarioService _categoriaService;
        private List<InventarioDTO> _productos;  // Lista de productos completa
        private Usuario _usuarioActual;  // Usuario actual

        public V_menuInventario(int idUsuario, POSContext context)
        {
            InitializeComponent();


            _inventarioService = new inventarioService(context);
            _usuarioActual = context.Usuarios.Find(idUsuario);


            //Mostrar el inventario en la tabla
            CargarInventario();
            // Configurar los permisos según el rol del usuario

            //Deshabilitar botones
            B_ModificarProducto.Enabled = false;
            B_DarBaja.Enabled = false;

            //Forzar la deseleccion de cualquier fila
            DGV_Inventario.ClearSelection();

            // Suscribir el evento para el buscador
            TB_BuscarProducto.TextChanged += TB_BuscarProducto_TextChanged;
            ConfigurarPermisos();
            B_ProductosBajos.Enabled = false;
            activarbotonpreciosbajos();
            llenarcombobox();

        }

        // Método para configurar los permisos según el rol del usuario
        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarProducto.Enabled = false;
                B_DarBaja.Enabled = false;
                B_AgregarProducto.Enabled = false;
                B_CategoriasInventario.Enabled = false;
                B_ActualizarTabla.Enabled = false;
            }
        }
        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarInventario();
            CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado
        }

        private void B_AgregarProducto_Click(object sender, EventArgs e)
        {
            V_CreateInventario createInventario = new V_CreateInventario();
            createInventario.ShowDialog();
            CargarInventario();
            CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado
        }

        void personalizartabla()
        {
            // Configurar los nombres de las columnas, etc.
            if (DGV_Inventario.Columns["CodigoProducto"] != null)
            {
                DGV_Inventario.Columns["CodigoProducto"].HeaderText = "Codigo";
                DGV_Inventario.Columns["CodigoProducto"].Width = 180;  // Ancho personalizado en píxeles
            }

            if (DGV_Inventario.Columns["DescripcionProducto"] != null)
            {
                DGV_Inventario.Columns["DescripcionProducto"].HeaderText = "Descripcion";
                DGV_Inventario.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Ocupa el espacio sobrante
            }

            if (DGV_Inventario.Columns["Stock"] != null)
            {
                DGV_Inventario.Columns["Stock"].HeaderText = "Stock";
                DGV_Inventario.Columns["Stock"].Width = 80;  // Ancho personalizado en píxeles
            }

            if (DGV_Inventario.Columns["PrecioVenta"] != null)
            {
                DGV_Inventario.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                DGV_Inventario.Columns["PrecioVenta"].Width = 120;  // Ancho personalizado en píxeles
            }

            if (DGV_Inventario.Columns["PrecioCompra"] != null)
            {
                DGV_Inventario.Columns["PrecioCompra"].HeaderText = "Precio Compra";
                DGV_Inventario.Columns["PrecioCompra"].Width = 120;  // Ancho personalizado en píxeles
            }

            if (DGV_Inventario.Columns["Estante"] != null)
            {
                DGV_Inventario.Columns["Estante"].HeaderText = "Estante";
                DGV_Inventario.Columns["Estante"].Width = 100;  // Ancho personalizado en píxeles
            }

            if (DGV_Inventario.Columns["NombreCategoria"] != null)
            {
                DGV_Inventario.Columns["NombreCategoria"].HeaderText = "Categoria";
                DGV_Inventario.Columns["NombreCategoria"].Width = 220;  // Ancho personalizado en píxeles
            }

            if (DGV_Inventario.Columns["Estado"] != null)
            {
                DGV_Inventario.Columns["Estado"].HeaderText = "Estado";
                DGV_Inventario.Columns["Estado"].Width = 100;  // Ancho personalizado en píxeles
            }




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

        private void CargarInventario(List<InventarioDTO> productos = null)
        {
            try
            {
                // Si no se pasan productos, carga todos los productos
                if (productos == null)
                {
                    productos = _inventarioService.listarInventarioDTO();
                    _productos = productos; // Guardar la lista completa para uso en búsquedas

                }

                // Limpiar el DataSource antes de volver a asignar
                DGV_Inventario.DataSource = null;

                // Asignar el DataSource con la lista de productos
                DGV_Inventario.DataSource = productos;

                // Aplicar la personalización de la tabla después de asignar el DataSource
                personalizartabla();
                activarbotonpreciosbajos();



                // Verificar precios si es la carga completa del inventario
                if (productos == _productos)
                {
                    //VerificarPreciosInventario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Metodo de si existe algun producto con precio de compra mayor a precio de venta, se active el boton de productos bajos

        void activarbotonpreciosbajos()
        {
            try
            {
                var productos = _inventarioService.ObtenerProductosConPrecioCompraMayorVenta();
                if (productos.Count > 0)
                {
                    B_ProductosBajos.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos con precios bajos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DGV_Inventario_SelectionChanged(object sender, EventArgs e)
        {
            // Habilitar botones si hay una fila seleccionada y guardar el id del producto seleccionado
            if (DGV_Inventario.SelectedRows.Count > 0)
            {
                var selectedRow = DGV_Inventario.SelectedRows[0];
                var cellValue = selectedRow.Cells["CodigoProducto"].Value;

                if (cellValue != null)  // Verificar que el valor no sea null
                {
                    selectedCodigoProducto = cellValue.ToString();

                    // Verificar el rol del usuario antes de habilitar los botones
                    if (_usuarioActual.Rol != "Cajero")
                    {
                        B_ModificarProducto.Enabled = true;
                        B_DarBaja.Enabled = true;
                    }
                }
                else
                {
                    // Si el valor es null, deshabilitar los botones por seguridad
                    B_ModificarProducto.Enabled = false;
                    B_DarBaja.Enabled = false;
                }
            }
            else
            {
                // Si no hay filas seleccionadas, deshabilitar los botones
                B_ModificarProducto.Enabled = false;
                B_DarBaja.Enabled = false;
            }

        }

        private void B_ModificarProducto_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(selectedCodigoProducto))
            {
                V_UpdateInventario updateInventario = new V_UpdateInventario(selectedCodigoProducto, _inventarioService);

                // Recargar la tabla solo si la modificación fue exitosa
                if (updateInventario.ShowDialog() == DialogResult.OK)
                {
                    CargarInventario();  // Recargar datos si se cerró con éxito
                    CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.");
            }
        }

        private void B_DarBaja_Click(object sender, EventArgs e)
        {
            //Cambiar estado de producto de Habilitado'a'Deshabilitado' y viceversa y mostrar mensaje del customMessageBox
            try
            {
                var producto = _inventarioService.ObtenerProductoPorCodigo(selectedCodigoProducto);
                string mensaje = producto.Estado == "Habilitado" ? "¿Desea dar de baja el producto?" : "¿Desea habilitar el producto?";
                DialogResult result = CustomMessageBox.Show(mensaje, "Confirmación");

                if (result == DialogResult.Yes)
                {
                    _inventarioService.CambiarEstadoProducto(selectedCodigoProducto);
                    CargarInventario();
                    CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cambiar el estado del producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TB_BuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {



        }


        // Verificar que el precio de venta no sea menor al precio de compra
        private void VerificarPreciosInventario()
        {
            var inventario = _inventarioService.listarInventario();

            bool hayDiscrepancia = inventario.Any(producto => producto.PrecioVenta < producto.PrecioCompra);

            if (hayDiscrepancia)
            {
                MessageBox.Show("Algunos productos tienen un precio de venta menor al precio de la última compra.",
                                "Advertencia de Precios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void B_CategoriasInventario_Click(object sender, EventArgs e)
        {
            // Crear el servicio de categoría antes de abrir la ventana
            var context = new POSContext(new DbContextOptions<POSContext>());
            var categoriaService = new CategoriaInventarioService(context);

            // Abrir el formulario de categorias de inventario pasando el servicio
            V_MenuCategoriasInventario categoriasInventario = new V_MenuCategoriasInventario(categoriaService);
            categoriasInventario.ShowDialog();

        }

        private void TB_BuscarProducto_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox
            string filtro = TB_BuscarProducto.Text.ToLower().Trim();

            // Si el campo está vacío, recargar todos los productos
            if (string.IsNullOrEmpty(filtro))
            {
                // Recargar el inventario completo
                if (DGV_Inventario.DataSource != _productos) // Verifica si ya está mostrando todos los productos
                {
                    CargarInventario();
                    CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado
                }
                return;
            }

            // Si la lista de productos no es nula, aplicar el filtro
            if (_productos != null)
            {
                var productosFiltrados = _productos
                    .Where(p =>
                        (p.CodigoProducto?.ToLower().Contains(filtro) ?? false) ||
                        (p.DescripcionProducto?.ToLower().Contains(filtro) ?? false))
                    .ToList();

                // Actualizar la tabla con los productos filtrados
                DGV_Inventario.DataSource = null; // Limpia el DataSource antes de actualizar
                DGV_Inventario.DataSource = productosFiltrados;

                // Aplicar la personalización de la tabla después de asignar el nuevo DataSource
                personalizartabla();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Metodo para atajos de los botones con control
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarProducto.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarProducto.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.B))
            {
                B_DarBaja.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarProducto.Focus();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.C))
            {
                B_CategoriasInventario.PerformClick();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }

        private void B_ProductosBajos_Click(object sender, EventArgs e)
        {
            //Mostrar en la tabla los productos que su precio de compra sea mayor a su precio de venta
            try
            {
                var productos = _inventarioService.ObtenerProductosConPrecioCompraMayorVenta();
                CargarInventario(productos);
                CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los productos con precios bajos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void llenarcombobox()
        {
            CB_Filtros.Items.Add("Todos");
            CB_Filtros.Items.Add("Habilitados");
            CB_Filtros.Items.Add("Deshabilitados");

            // Establecer estilo no editable
            CB_Filtros.DropDownStyle = ComboBoxStyle.DropDownList;

            // Desconectar el evento para evitar errores al configurar el índice inicial
            CB_Filtros.SelectedIndexChanged -= CB_Filtros_SelectedIndexChanged;
            CB_Filtros.SelectedIndex = 0; // Establecer "Todos" como predeterminado
            CB_Filtros.SelectedIndexChanged += CB_Filtros_SelectedIndexChanged;
        }

        private void CB_Filtros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //metodo para filtrar los productos, uno donde muestre todos, otro donde muestro los deshabilitados y otro donde muestro los habilitados en un combobox llamado CB_Filtros
            if (CB_Filtros.SelectedIndex == 0)
            {
                CargarInventario();

            }
            else if (CB_Filtros.SelectedIndex == 1)
            {
                var productos = _inventarioService.ObtenerProductosPorEstado("Habilitado");
                CargarInventario(productos);
            }
            else if (CB_Filtros.SelectedIndex == 2)
            {
                var productos = _inventarioService.ObtenerProductosPorEstado("Deshabilitado");
                CargarInventario(productos);
            }




        }

        private void V_menuInventario_Load(object sender, EventArgs e)
        {

        }

        private void B_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(selectedCodigoProducto))
                {
                    MessageBox.Show("Seleccione un producto para eliminar.");
                    return;
                }

                // Confirmar la eliminación
                var confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    _inventarioService.EliminarProducto(selectedCodigoProducto);
                    CargarInventario(); // Actualizar el inventario después de la eliminación
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se puede eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

