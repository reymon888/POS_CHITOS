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
                ActualizarTablaDetalles((List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource);
            }
            else
            {
                MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    var detallesCompra = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                    var detalleExistente = detallesCompra?.FirstOrDefault(d => d.CodigoProducto == codigoProducto);

                    if (detalleExistente != null)
                    {
                        DialogResult result = MessageBox.Show(
                            $"El producto {detalleExistente.DescripcionProducto} ya está en la lista. ¿Desea modificar la cantidad?",
                            "Producto existente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            ModificarCantidadProducto(detalleExistente);
                        }
                    }
                    else
                    {
                        string cantidadTexto = Microsoft.VisualBasic.Interaction.InputBox(
                             "Ingrese la cantidad para el producto seleccionado:", "Cantidad", "1");

                        if (int.TryParse(cantidadTexto, out int cantidad) && cantidad > 0)
                        {
                            float precioVenta = productoSeleccionado.PrecioVenta;
                            // Agregar el producto a los detalles con el precio de compra ingresado
                            AgregarProductoADetalles(productoSeleccionado, cantidad, precioVenta);
                            ConfigurarEstiloTabla();
                            TB_Producto.Text = "";
                            TB_Producto.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
