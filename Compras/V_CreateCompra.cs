using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Compras;
using POS_CHITOS.Inventario;
using POS_CHITOS;
//using POS_CHITOS.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_CHITOS.Ventas;

namespace POS_CHITOS
{
    public partial class V_CreateCompra : Form
    {
        private readonly ComprasService _compraService;
        private readonly ProveedoresService _proveedoresService;
        private readonly inventarioService _inventarioService;
        private readonly CortesService _corteService;
        private readonly int _idCompra;
        private readonly int _idUsuario;  // User ID of the logged-in user
        public V_CreateCompra(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;  // Asignar el ID del usuario logueado correctamente
            var context = new POSContext(new DbContextOptions<POSContext>());
            _compraService = new ComprasService(context);
            _proveedoresService = new ProveedoresService(context);
            _inventarioService = new inventarioService(context);
            _corteService = new CortesService(context);

            // Configurar autocompletes
            ConfigurarAutoCompleteProveedor();
            ConfigurarAutoCompleteProducto();






            // Suscribir los eventos de doble clic
            DGV_DetallesCompras.CellDoubleClick += DGV_DetallesCompras_CellDoubleClick;

            // Inicialmente, deshabilitamos los botones ya que no hay una fila seleccionada
            B_CambiarPrecio.Enabled = false;
            B_ModificarCantidad.Enabled = false;
            B_EliminarProducto.Enabled = false;
        }

        private void B_AgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedorSeleccionado = _proveedoresService.ObtenerProveedorPorNombre(TB_Proveedor.Text);
                if (proveedorSeleccionado == null)
                {
                    MessageBox.Show("El proveedor ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validar si el usuario logueado existe en la base de datos
                var usuario = _compraService.ObtenerUsuarioPorId(_idUsuario);
                if (usuario == null)
                {
                    MessageBox.Show("El usuario no existe. Verifica el ID del usuario logueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el CheckBox está marcado, usar la fecha y hora actual, de lo contrario, usar la seleccionada en el DTP
                var nuevaFechaCompra = DateTime.Now;

                var detallesCompraDTO = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                if (detallesCompraDTO == null || detallesCompraDTO.Count == 0)
                {
                    MessageBox.Show("No se pueden guardar cambios sin productos en la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el corte no realizado
                var corteVigente = _corteService.ObtenerCorteNoRealizado(_idUsuario);
                if (corteVigente == null)
                {
                    MessageBox.Show("No hay un corte de caja activo. No se puede registrar la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir List<DetalleCompraDTO> a List<DetalleCompra>
                List<DetalleCompra> detallesCompra = detallesCompraDTO.Select(d => new DetalleCompra
                {
                    CodigoProducto = d.CodigoProducto,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    idCompra = 0
                }).ToList();

                string folioCompraOriginal = TB_FolioCompra.Text;

                // Registrar la compra con el idCorte dinámico y la fecha correspondiente
                _compraService.RegistrarCompra(proveedorSeleccionado.idProveedor, nuevaFechaCompra, detallesCompra, _idUsuario, "Realizada", folioCompraOriginal, corteVigente.IdCorte);

                MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                var detailedError = ex.InnerException != null ? ex.InnerException.Message : "Sin detalles adicionales.";
                MessageBox.Show($"Error al registrar la compra: {ex.Message}\nDetalles: {detailedError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConfigurarAutoCompleteProveedor()
        {
            var proveedores = _proveedoresService.listarProveedores().Select(p => p.NombreProveedor).ToList();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(proveedores.ToArray());
            TB_Proveedor.AutoCompleteCustomSource = autoComplete;
            TB_Proveedor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Proveedor.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void ConfigurarAutoCompleteProducto()
        {
            var productos = _inventarioService.listarInventario()
                                              .Select(p => p.CodigoProducto + " - " + p.DescripcionProducto)
                                              .ToList();
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(productos.ToArray());
            TB_Producto.AutoCompleteCustomSource = autoComplete;
            TB_Producto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TB_Producto.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void ConfigurarEstiloTabla()
        {
            if (DGV_DetallesCompras.Columns["CodigoProducto"] != null)
            {
                DGV_DetallesCompras.Columns["CodigoProducto"].HeaderText = "Codigo";
                DGV_DetallesCompras.Columns["CodigoProducto"].Width = 200;
            }
            if (DGV_DetallesCompras.Columns["DescripcionProducto"] != null)
            {
                DGV_DetallesCompras.Columns["DescripcionProducto"].HeaderText = "Descripcion";
                DGV_DetallesCompras.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (DGV_DetallesCompras.Columns["Cantidad"] != null)
            {
                DGV_DetallesCompras.Columns["Cantidad"].HeaderText = "Cantidad";
                DGV_DetallesCompras.Columns["Cantidad"].Width = 150;
            }
            if (DGV_DetallesCompras.Columns["PrecioUnitario"] != null)
            {
                DGV_DetallesCompras.Columns["PrecioUnitario"].HeaderText = "Precio C/U";
                DGV_DetallesCompras.Columns["PrecioUnitario"].Width = 180;
            }

            if (DGV_DetallesCompras.Columns["Total"] != null)
            {
                DGV_DetallesCompras.Columns["Total"].HeaderText = "Total";
                DGV_DetallesCompras.Columns["Total"].Width = 180;
            }

            //Formato de dinero para la columna de Total y Precio Unitario
            DGV_DetallesCompras.Columns["Total"].DefaultCellStyle.Format = "C2";
            DGV_DetallesCompras.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2";


            DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            DGV_DetallesCompras.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_DetallesCompras.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesCompras.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesCompras.EnableHeadersVisualStyles = false;
            DGV_DetallesCompras.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_DetallesCompras.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesCompras.ClearSelection();

            //Poner el contenido de la tabla en medio
            DGV_DetallesCompras.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Eliminar el contorno de las celdas
            DGV_DetallesCompras.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_DetallesCompras.RowHeadersVisible = false;
        }




        private void ModificarCantidadProducto(DetalleCompraDTO detalleSeleccionado)
        {
            // Preguntar por la nueva cantidad y validar que sea válida
            string nuevaCantidadTexto = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la nueva cantidad para el producto seleccionado:",
                "Modificar Cantidad",
                detalleSeleccionado.Cantidad.ToString());

            if (int.TryParse(nuevaCantidadTexto, out int nuevaCantidad) && nuevaCantidad > 0)
            {
                // Actualizar la cantidad y recalcular el total
                detalleSeleccionado.Cantidad = nuevaCantidad;
                detalleSeleccionado.Total = nuevaCantidad * detalleSeleccionado.PrecioUnitario;

                // Refrescar la tabla y calcular el total
                ActualizarTablaDetalles((List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource);
            }
            else
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_CancelarCompra_Click(object sender, EventArgs e)
        {
            //Preguntar si desea cancelar la compra y cerrar la ventana
            if (CustomMessageBox.Show("¿Está seguro que desea cancelar la compra?", "Cancelar Compra") == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void TB_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var productoTexto = TB_Producto.Text;
                var codigoProducto = productoTexto.Split(' ')[0];

                var productoSeleccionado = _inventarioService.ObtenerProductoPorCodigo(codigoProducto);

                if (productoSeleccionado != null)
                {
                    var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                    var detalleExistente = detallesCompra?.FirstOrDefault(d => d.CodigoProducto == codigoProducto);

                    if (detalleExistente != null)
                    {
                        DialogResult result = CustomMessageBox.Show(
                            $"El producto {detalleExistente.DescripcionProducto} ya está en la lista. ¿Desea modificar la cantidad?",
                            "Producto existente");

                        if (result == DialogResult.Yes)
                        {
                            ModificarCantidadProducto(detalleExistente);
                        }
                    }
                    else
                    {
                        // Solicitar el precio de compra al usuario con CustomInputBox
                        float precioCompra;
                        if (CustomInputBox.Show("Ingrese el precio de compra para el producto seleccionado:", "Precio de Compra", productoSeleccionado.PrecioCompra, out precioCompra) == DialogResult.OK)
                        {
                            if (precioCompra <= 0)
                            {
                                CustomMessageBox.Show("Por favor ingrese un precio de compra válido.", "Error");
                                return;
                            }

                            // Solicitar la cantidad del producto al usuario
                            float cantidad;
                            if (CustomInputBox.Show("Ingrese la cantidad para el producto seleccionado:", "Cantidad", 1, out cantidad) == DialogResult.OK)
                            {
                                if (cantidad > 0)
                                {
                                    // Agregar el producto a los detalles con el precio de compra ingresado
                                    AgregarProductoADetalles(productoSeleccionado, (int)cantidad, precioCompra);
                                    ConfigurarEstiloTabla();
                                    TB_Producto.Text = "";
                                    TB_Producto.Focus();
                                }
                                else
                                {
                                    CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
                                }
                            }
                        }
                    }
                }
                else
                {
                    CustomMessageBox.Show("Producto no encontrado.", "Error");
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void AgregarProductoADetalles(inventario producto, int cantidad, float precioCompra)
        {
            var nuevoDetalle = new DetalleCompraDTO
            {
                CodigoProducto = producto.CodigoProducto,
                DescripcionProducto = producto.DescripcionProducto,
                Cantidad = cantidad,
                PrecioUnitario = precioCompra,
                Total = cantidad * precioCompra
            };

            // Actualizar el precio de compra del producto en el inventario
            producto.PrecioCompra = precioCompra;
            //_inventarioService.ActualizarProducto(producto);

            var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
            if (detallesCompra == null)
            {
                detallesCompra = new List<DetalleCompraDTO>();
            }

            detallesCompra.Add(nuevoDetalle);
            ActualizarTablaDetalles(detallesCompra);
        }

        private void ActualizarTablaDetalles(List<DetalleCompraDTO> detallesCompra)
        {
            DGV_DetallesCompras.DataSource = null;
            DGV_DetallesCompras.DataSource = detallesCompra;
            ConfigurarEstiloTabla();

            // Llamar a la función para recalcular el total
            CalcularTotalCompra();
        }


        private void CalcularTotalCompra()
        {
            var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
            if (detallesCompra != null)
            {
                var totalCompra = detallesCompra.Sum(d => d.Total);
                TB_TotalCompra.Text = totalCompra.ToString("C2");
            }
        }

        private void B_EliminarProducto_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesCompras.SelectedRows.Count > 0)
            {
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[DGV_DetallesCompras.SelectedRows[0].Index];

                // Usar CustomMessageBox para confirmar la eliminación
                if (CustomMessageBox.Show($"¿Está seguro que desea eliminar el producto {detalleSeleccionado.CodigoProducto}?", "Eliminar Producto") == DialogResult.Yes)
                {
                    detallesCompra.Remove(detalleSeleccionado);
                    ActualizarTablaDetalles(detallesCompra);
                }
            }
            else
            {
                CustomMessageBox.Show("Seleccione un producto para eliminar de la compra.", "Advertencia");
            }
        }

        private void B_ModificarCantidad_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesCompras.SelectedRows.Count > 0)
            {
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[DGV_DetallesCompras.SelectedRows[0].Index];

                // Pedir la nueva cantidad usando CustomInputBox
                float nuevaCantidad;
                if (CustomInputBox.Show("Ingrese la nueva cantidad para el producto seleccionado:", "Modificar Cantidad", detalleSeleccionado.Cantidad, out nuevaCantidad) == DialogResult.OK)
                {
                    if (nuevaCantidad > 0)
                    {
                        detalleSeleccionado.Cantidad = (int)nuevaCantidad;
                        detalleSeleccionado.Total = detalleSeleccionado.Cantidad * detalleSeleccionado.PrecioUnitario;

                        // Refrescar la tabla y recalcular el total
                        ActualizarTablaDetalles(detallesCompra);
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor, ingrese una cantidad válida.", "Error");
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("Seleccione un producto para modificar su cantidad.", "Advertencia");
            }
        }



        private void B_CambiarPrecio_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesCompras.SelectedRows.Count > 0)
            {
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[DGV_DetallesCompras.SelectedRows[0].Index];

                // Pedir el nuevo precio usando CustomInputBox
                float nuevoPrecio;
                if (CustomInputBox.Show("Ingrese el nuevo precio para el producto seleccionado:", "Modificar Precio", detalleSeleccionado.PrecioUnitario, out nuevoPrecio) == DialogResult.OK)
                {
                    if (nuevoPrecio > 0)
                    {
                        detalleSeleccionado.PrecioUnitario = nuevoPrecio;
                        detalleSeleccionado.Total = detalleSeleccionado.Cantidad * nuevoPrecio;

                        // Refrescar la tabla y recalcular el total
                        ActualizarTablaDetalles(detallesCompra);
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor, ingrese un precio válido.", "Error");
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("Seleccione un producto para modificar su precio.", "Advertencia");
            }
        }



        private void DGV_DetallesCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que la columna seleccionada sea la de Cantidad
            if (e.ColumnIndex == DGV_DetallesCompras.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[e.RowIndex];

                // Reutilizar el método de modificar cantidad
                ModificarCantidadProducto(detalleSeleccionado);
            }

            // Verificar que la columna seleccionada sea la de Precio
            if (e.ColumnIndex == DGV_DetallesCompras.Columns["PrecioUnitario"].Index && e.RowIndex >= 0)
            {
                B_CambiarPrecio_Click(sender, e);  // Reutilizar el código del botón para cambiar el precio
            }
        }



        private void DGV_DetallesCompras_SelectionChanged(object sender, EventArgs e)
        {
            // Habilitar/deshabilitar botones según si hay una fila seleccionada
            bool filaSeleccionada = DGV_DetallesCompras.SelectedRows.Count > 0;
            B_CambiarPrecio.Enabled = filaSeleccionada;
            B_ModificarCantidad.Enabled = filaSeleccionada;
            B_EliminarProducto.Enabled = filaSeleccionada;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Instanciar la ventana de selección de productos
            V_SeleccionarInventario seleccionarProductoForm = new V_SeleccionarInventario(_inventarioService);

            if (seleccionarProductoForm.ShowDialog() == DialogResult.OK)
            {
                // Convertir InventarioDTO a inventario
                var productoSeleccionadoDTO = seleccionarProductoForm.ProductoSeleccionado;
                var productoSeleccionado = new inventario
                {
                    CodigoProducto = productoSeleccionadoDTO.CodigoProducto,
                    DescripcionProducto = productoSeleccionadoDTO.DescripcionProducto,
                    PrecioVenta = productoSeleccionadoDTO.PrecioVenta,
                    Stock = productoSeleccionadoDTO.Stock
                };

                // Solicitar la cantidad del producto al usuario usando el CustomInputBox
                float cantidad;
                if (CustomInputBox.Show("Ingrese la cantidad para el producto seleccionado:", "Cantidad", 1, out cantidad) == DialogResult.OK)
                {
                    if (cantidad > 0)
                    {
                       

                        float precioCompra;
                        if (CustomInputBox.Show("Ingrese el precio de compra para el producto seleccionado:", "Precio de Compra", productoSeleccionado.PrecioCompra, out precioCompra) == DialogResult.OK)
                        {
                            if (precioCompra <= 0)
                            {
                                CustomMessageBox.Show("Por favor ingrese un precio de compra válido.", "Error");
                                return;
                            }

                            // Agregar el producto a los detalles con el precio de compra ingresado
                            AgregarProductoADetalles(productoSeleccionado, (int)cantidad, precioCompra);
                        }

                      
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
                    }
                }
            }
        }

        //Metodo para atajos de teclado 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarCompra.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.O))
            {
                B_CambiarPrecio.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.E))
            {
                B_EliminarProducto.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.C))
            {
                B_ModificarCantidad.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_DetallesCompras.Focus();
                return true;
            }
            if (keyData == (Keys.Escape))
            {
                B_CancelarCompra.Focus();
                return true;
            }
         
            if (keyData == (Keys.Control | Keys.S))
            {
                button3.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }


}


