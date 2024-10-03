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
    public partial class V_menuInventario : Form
    {
        private readonly inventarioService _inventarioService;
        private string selectedCodigoProducto;
        private BindingList<inventario> bindingList;

        public V_menuInventario(POSContext context)
        {
            InitializeComponent();


            _inventarioService = new inventarioService(context);

            //Mostrar el inventario en la tabla
            CargarInventario();

            //Deshabilitar botones
            B_ModificarProducto.Enabled = false;
            B_DarBaja.Enabled = false;

            //Forzar la deseleccion de cualquier fila
            DGV_Inventario.ClearSelection();
            


        }

        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarInventario();

        }

        private void B_AgregarProducto_Click(object sender, EventArgs e)
        {
            V_CreateInventario createInventario = new V_CreateInventario();
            createInventario.ShowDialog();
            CargarInventario();
        }

        public void CargarInventario()
        {
            try
            {
                // Forzar la obtención de datos actualizados desde la base de datos
                var inventario = _inventarioService.listarInventario();

                // Limpiar el DataSource antes de volver a asignar
                DGV_Inventario.DataSource = null;

                DGV_Inventario.DataSource = inventario;

                // Configurar los nombres de las columnas, etc.
                if (DGV_Inventario.Columns["CodigoProducto"] != null)
                {
                    DGV_Inventario.Columns["CodigoProducto"].HeaderText = "Codigo";
                    DGV_Inventario.Columns["CodigoProducto"].Width = 150;  // Ancho personalizado en píxeles
                }

                if (DGV_Inventario.Columns["DescripcionProducto"] != null)
                {
                    DGV_Inventario.Columns["DescripcionProducto"].HeaderText = "Descripcion";
                    DGV_Inventario.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Ocupa el espacio sobrante
                }

                if (DGV_Inventario.Columns["Stock"] != null)
                {
                    DGV_Inventario.Columns["Stock"].HeaderText = "Stock";
                    DGV_Inventario.Columns["Stock"].Width = 100;  // Ancho personalizado en píxeles
                }

                if (DGV_Inventario.Columns["PrecioVenta"] != null)
                {
                    DGV_Inventario.Columns["PrecioVenta"].HeaderText = "Precio Venta";
                    DGV_Inventario.Columns["PrecioVenta"].Width = 150;  // Ancho personalizado en píxeles
                }

                if (DGV_Inventario.Columns["PrecioCompra"] != null)
                {
                    DGV_Inventario.Columns["PrecioCompra"].HeaderText = "Ultimo Precio Compra";
                    DGV_Inventario.Columns["PrecioCompra"].Width = 150;  // Ancho personalizado en píxeles
                }

                if (DGV_Inventario.Columns["Estante"] != null)
                {
                    DGV_Inventario.Columns["Estante"].HeaderText = "Estante";
                    DGV_Inventario.Columns["Estante"].Width = 100;  // Ancho personalizado en píxeles
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

                VerificarPreciosInventario();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void DGV_Inventario_SelectionChanged(object sender, EventArgs e)
        {
            //Habilitar botones si hay una fila seleccionada y guardar el id del producto seleccionado
            if (DGV_Inventario.SelectedRows.Count > 0)
            {
                B_ModificarProducto.Enabled = true;
                B_DarBaja.Enabled = true;
                selectedCodigoProducto = DGV_Inventario.SelectedRows[0].Cells["CodigoProducto"].Value.ToString();
            }
            else
            {
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
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar.");
            }
        }

        private void B_DarBaja_Click(object sender, EventArgs e)
        {
            //Eliminar el producto seleccionado
            if (!string.IsNullOrEmpty(selectedCodigoProducto))
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro de que desea dar de baja este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        _inventarioService.eliminarProducto(selectedCodigoProducto);
                        CargarInventario();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al dar de baja el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para dar de baja.");
            }
        }

        private void TB_BuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // Filtrar los productos por nombre y/o codigo pero que se vaya reduciendo la tabla conforme se escribe

            var productos = _inventarioService.listarInventario();
            var filteredProductos = productos.Where(p => p.DescripcionProducto.ToLower().Contains(TB_BuscarProducto.Text.ToLower()) || p.CodigoProducto.ToLower().Contains(TB_BuscarProducto.Text.ToLower())).ToList();
            bindingList = new BindingList<inventario>(filteredProductos);
            DGV_Inventario.DataSource = bindingList;



        }
        // Verificar que el precio de venta no sea menor al precio de compra
        //private void VerificarPreciosInventario()
        //{
        //    var inventario = _inventarioService.listarInventario();

        //    foreach (var producto in inventario)
        //    {
        //        if (producto.PrecioVenta < producto.PrecioCompra)
        //        {
        //            MessageBox.Show($"El producto {producto.DescripcionProducto} tiene un precio de venta ({producto.PrecioVenta:C}) menor al precio de la última compra ({producto.PrecioCompra:C}).",
        //                            "Advertencia de Precio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //    }
        //}

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

    }
    }

