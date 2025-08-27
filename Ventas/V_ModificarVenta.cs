using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_CHITOS.Avisos;
using POS_CHITOS.Inventario;
using POS_CHITOS.Ventas;

namespace POS_CHITOS
{
    public partial class V_ModificarVenta : Form
    {
        private readonly VentasService _ventasService;
        private readonly int _folioVenta;
        private readonly inventarioService _inventarioService;
        public V_ModificarVenta(int folioVenta, POSContext context)
        {
            InitializeComponent();
            _folioVenta = folioVenta;
            _ventasService = new VentasService(context);
            _inventarioService = new inventarioService(context);

            ConfigurarAutoCompleteProducto();
            CargarVentaExistente();
            ConfigurarEstiloTabla();
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



        private void ModificarCantidadProducto(DetalleVentaDTO detalleSeleccionado)
        {
            // Obtener el producto del inventario
            var producto = _inventarioService.ObtenerProductoPorCodigo(detalleSeleccionado.CodigoProducto);

            if (producto != null)
            {
                // Obtener el stock actual del producto
                int stockDisponible = producto.Stock + detalleSeleccionado.Cantidad; // Sumamos la cantidad ya vendida

                // Solicitar la nueva cantidad al usuario usando CustomInputBox
                float nuevaCantidad;
                if (CustomInputBox.Show($"Stock disponible: {stockDisponible}\nIngrese la nueva cantidad para el producto seleccionado:",
                                         "Modificar Cantidad", detalleSeleccionado.Cantidad, out nuevaCantidad) == DialogResult.OK)
                {
                    // Validar la cantidad ingresada
                    if (nuevaCantidad > 0 && nuevaCantidad <= stockDisponible)
                    {
                        // Actualizar la cantidad y el total
                        detalleSeleccionado.Cantidad = (int)nuevaCantidad;
                        detalleSeleccionado.Total = detalleSeleccionado.Cantidad * detalleSeleccionado.PrecioUnitario;

                        // Refrescar la tabla y calcular el total
                        ActualizarTablaDetalles((List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource);
                    }
                    else if (nuevaCantidad > stockDisponible)
                    {
                        CustomMessageBox.Show($"La cantidad seleccionada excede el stock disponible ({stockDisponible}).", "Error");
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("No se pudo obtener la información del producto.", "Error");
            }
        }


        private void ConfigurarEstiloTabla()
        {
            if (DGV_DetallesVenta.Columns["CodigoProducto"] != null)
            {
                DGV_DetallesVenta.Columns["CodigoProducto"].HeaderText = "Codigo";
                DGV_DetallesVenta.Columns["CodigoProducto"].Width = 150;
            }
            if (DGV_DetallesVenta.Columns["DescripcionProducto"] != null)
            {
                DGV_DetallesVenta.Columns["DescripcionProducto"].HeaderText = "Descripcion";
                DGV_DetallesVenta.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (DGV_DetallesVenta.Columns["Cantidad"] != null)
            {
                DGV_DetallesVenta.Columns["Cantidad"].HeaderText = "Cantidad";
                DGV_DetallesVenta.Columns["Cantidad"].Width = 150;
            }
            if (DGV_DetallesVenta.Columns["PrecioUnitario"] != null)
            {
                DGV_DetallesVenta.Columns["PrecioUnitario"].HeaderText = "Precio c/u";
                DGV_DetallesVenta.Columns["PrecioUnitario"].Width = 150;
            }

            DGV_DetallesVenta.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            DGV_DetallesVenta.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_DetallesVenta.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_DetallesVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_DetallesVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesVenta.EnableHeadersVisualStyles = false;
            DGV_DetallesVenta.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_DetallesVenta.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_DetallesVenta.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_DetallesVenta.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesVenta.ClearSelection();

            //Poner el contenido de la tabla en medio
            DGV_DetallesVenta.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_DetallesVenta.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Eliminar el contorno de las celdas
            DGV_DetallesVenta.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_DetallesVenta.RowHeadersVisible = false;
        }

        private void AgregarProductoADetalles(inventario producto, int cantidad, float precioVenta)
        {
            var nuevoDetalle = new DetalleVentaDTO
            {
                CodigoProducto = producto.CodigoProducto,
                DescripcionProducto = producto.DescripcionProducto,
                Cantidad = cantidad,
                PrecioUnitario = precioVenta,
                Total = cantidad * precioVenta
            };


            //_inventarioService.ActualizarProducto(producto);

            var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
            if (detallesVenta == null)
            {
                detallesVenta = new List<DetalleVentaDTO>();
            }

            detallesVenta.Add(nuevoDetalle);
            ActualizarTablaDetalles(detallesVenta);
        }

        private void ActualizarTablaDetalles(List<DetalleVentaDTO> detallesVenta)
        {
            DGV_DetallesVenta.DataSource = null;
            DGV_DetallesVenta.DataSource = detallesVenta;
            ConfigurarEstiloTabla();

            // Llamar a la función para recalcular el total
            CalcularTotalVenta();
        }



        private void CalcularTotalVenta()
        {
            var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
            if (detallesVenta != null)
            {
                var totalVenta = detallesVenta.Sum(d => d.Total);
                TB_TotalVenta.Text = totalVenta.ToString("C2");
            }
        }

        private void CargarVentaExistente()
        {
            try
            {
                // Obtener la venta y sus detalles usando el folio de venta
                var venta = _ventasService.ObtenerVentaPorFolio(_folioVenta);

                if (venta != null)
                {
                    // Cargar los detalles de la venta en el DataGridView
                    DGV_DetallesVenta.DataSource = venta.DetallesVenta;

                    // Mostrar la fecha de la venta en el DateTimePicker (sin permitir modificar)
                    dateTimePicker1.Value = venta.FechaVenta;
                    dateTimePicker1.Enabled = false;

                    // Mostrar el total de la venta
                    TB_TotalVenta.Text = venta.TotalVenta.ToString("C2");
                }
                else
                {
                    MessageBox.Show("La venta no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_AgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var detallesVentaDTO = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;

                if (detallesVentaDTO == null || detallesVentaDTO.Count == 0)
                {
                    MessageBox.Show("No se pueden modificar ventas sin productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir List<DetalleVentaDTO> a List<DetalleVenta>
                List<DetalleVenta> detallesVenta = detallesVentaDTO.Select(d => new DetalleVenta
                {
                    CodigoProducto = d.CodigoProducto,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    DescripcionProducto = d.CodigoProducto == "0"
                        ? d.DescripcionProducto // Usar la descripción ingresada para productos varios
                        : _inventarioService.ObtenerProductoPorCodigo(d.CodigoProducto)?.DescripcionProducto ?? "Sin Descripción", // Para productos normales, obtener del servicio
                    FolioVenta = _folioVenta // Usar el folio de la venta existente
                }).ToList();

                // Obtener el total de la venta
                float totalVenta = detallesVenta.Sum(d => d.Cantidad * d.PrecioUnitario);

                // Mostrar la ventana para recibir el pago
                using (var recibirPago = new V_RecibirPagoVenta(totalVenta))
                {
                    if (recibirPago.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener los valores del pago recibido y el cambio
                        float pagoRecibido = recibirPago.PagoRecibido;
                        float cambio = recibirPago.Cambio;

                        // Llamar al método de modificación en el servicio de ventas con los nuevos parámetros
                        _ventasService.ModificarVenta(_folioVenta, detallesVenta, pagoRecibido, cambio);

                        MessageBox.Show("Venta modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los cambios de la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                    var detalleExistente = detallesVenta?.FirstOrDefault(d => d.CodigoProducto == codigoProducto);

                    // Si el producto ya existe en los detalles
                    if (detalleExistente != null)
                    {
                        DialogResult result = CustomMessageBox.Show(
                            $"El producto {detalleExistente.DescripcionProducto} ya está en la lista. Modifica la cantidad si deseas mas productos de este tipo",
                            "Producto existente");

                        if (result == DialogResult.Yes)
                        {
                            ModificarCantidadProducto(detalleExistente);
                        }
                    }
                    else
                    {
                        // Calcular el stock disponible
                        int stockDisponible = productoSeleccionado.Stock;

                        // Solicitar la cantidad al usuario usando CustomInputBox
                        float cantidad;
                        if (CustomInputBox.Show($"Stock disponible: {stockDisponible}\nIngrese la cantidad para el producto seleccionado:",
                                                 "Cantidad", 1, out cantidad) == DialogResult.OK)
                        {
                            if (cantidad > 0 && cantidad <= stockDisponible)
                            {
                                float precioVenta = productoSeleccionado.PrecioVenta;
                                AgregarProductoADetalles(productoSeleccionado, (int)cantidad, precioVenta);
                                ConfigurarEstiloTabla();
                                TB_Producto.Text = "";
                                TB_Producto.Focus();
                            }
                            else if (cantidad > stockDisponible)
                            {
                                CustomMessageBox.Show($"La cantidad seleccionada excede el stock disponible ({stockDisponible}).", "Error");
                            }
                            else
                            {
                                CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
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

        private void B_EliminarProducto_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (DGV_DetallesVenta.SelectedRows.Count > 0)
            {
                // Obtener el detalle seleccionado
                var detalleSeleccionado = (DetalleVentaDTO)DGV_DetallesVenta.SelectedRows[0].DataBoundItem;

                // Preguntar al usuario si está seguro de eliminar el producto
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro de eliminar el producto {detalleSeleccionado.DescripcionProducto}?",
                    "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el producto de los detalles
                    var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                    detallesVenta.Remove(detalleSeleccionado);
                    ActualizarTablaDetalles(detallesVenta);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_ModificarCantidad_Click(object sender, EventArgs e)
        {
            //Si hay una fila seleccionada en el DataGridView preguntar si desea cambiar la cantidad de productos

            if (DGV_DetallesVenta.SelectedRows.Count > 0)
            {
                // Obtener el detalle seleccionado
                var detalleSeleccionado = (DetalleVentaDTO)DGV_DetallesVenta.SelectedRows[0].DataBoundItem;
                ModificarCantidadProducto(detalleSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para modificar la cantidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Servicio_Click(object sender, EventArgs e)
        {
            // Instanciar la ventana para obtener la descripción del producto vario
            var agregarProductoVarioForm = new V_AgregarProductoVario();
            if (agregarProductoVarioForm.ShowDialog() == DialogResult.OK)
            {
                // Obtener la descripción ingresada en la ventana
                string descripcion = agregarProductoVarioForm.DescripcionProducto;

                // Validar que se ingresó una descripción válida
                if (string.IsNullOrWhiteSpace(descripcion))
                {
                    CustomMessageBox.Show("Debe ingresar una descripción válida para el producto vario.", "Error");
                    return;
                }

                // Solicitar la cantidad del producto vario usando CustomInputBox
                float cantidad;
                if (CustomInputBox.Show("Ingrese la cantidad para el producto vario:", "Cantidad", 1, out cantidad) != DialogResult.OK || cantidad <= 0)
                {
                    CustomMessageBox.Show("Por favor, ingrese una cantidad válida.", "Error");
                    return;
                }

                // Solicitar el precio del producto vario usando CustomInputBox
                float precioUnitario;
                if (CustomInputBox.Show("Ingrese el precio unitario para el producto vario:", "Precio Unitario", 0, out precioUnitario) != DialogResult.OK || precioUnitario <= 0)
                {
                    CustomMessageBox.Show("Por favor, ingrese un precio válido.", "Error");
                    return;
                }

                // Agregar el producto vario a los detalles con CódigoProducto = "0"
                AgregarProductoVarioADetalles(descripcion, (int)cantidad, precioUnitario);
            }
        }

        private void AgregarProductoVarioADetalles(string descripcion, int cantidad, float precioUnitario)
        {
            var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
            if (detallesVenta == null)
            {
                detallesVenta = new List<DetalleVentaDTO>();
            }

            // Crear el producto vario con CódigoProducto = "0" y la descripción proporcionada
            var productoVario = new DetalleVentaDTO
            {
                CodigoProducto = "0",
                DescripcionProducto = descripcion,
                Cantidad = cantidad,
                PrecioUnitario = precioUnitario,
                Total = cantidad * precioUnitario
            };

            detallesVenta.Add(productoVario);
            ActualizarTablaDetalles(detallesVenta);
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

                // Obtener los detalles de venta actuales
                var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;

                // Validar si el producto ya está en la lista
                var detalleExistente = detallesVenta?.FirstOrDefault(d => d.CodigoProducto == productoSeleccionado.CodigoProducto);
                if (detalleExistente != null)
                {
                    // Mostrar mensaje de que el producto ya está en la lista
                    CustomMessageBox.Show("El producto ya se encuentra en la lista de detalles de venta.", "Producto Duplicado");
               
                    return;
                }

                // Solicitar la cantidad del producto al usuario usando el CustomInputBox
                float cantidad;
                if (CustomInputBox.Show("Ingrese la cantidad para el producto seleccionado:", "Cantidad", 1, out cantidad) == DialogResult.OK)
                {
                    if (cantidad > 0)
                    {
                        // Verificar si la cantidad no excede el stock disponible
                        if (cantidad > productoSeleccionado.Stock)
                        {
                            CustomMessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error");
                            return;
                        }

                        // Agregar el producto a los detalles con el precio de venta predeterminado
                        AgregarProductoADetalles(productoSeleccionado, (int)cantidad, productoSeleccionado.PrecioVenta);
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
                    }
                }
            }
        }
        }
    }

