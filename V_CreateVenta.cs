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
    public partial class V_CreateVenta : Form
    {
        private readonly VentasService _ventasService;
        private readonly inventarioService _inventarioService;
        private readonly int _idUsuario;
        private readonly UsuarioService _usuarioService;

        public V_CreateVenta(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;

            var context = new POSContext(new DbContextOptions<POSContext>());
            _ventasService = new VentasService(context);
            _inventarioService = new inventarioService(context);
            _usuarioService = new UsuarioService(context);

            ConfigurarAutoCompleteProducto();
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

        private void B_AgregarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                var detallesVentaDTO = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;

                if (detallesVentaDTO == null || detallesVentaDTO.Count == 0)
                {
                    MessageBox.Show("No se pueden registrar ventas sin productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener el usuario logueado dentro del método
                var usuarioLogueado = _usuarioService.ObtenerNombreUsuarioPorId(_idUsuario);

                // Convertir List<DetalleVentaDTO> a List<DetalleVenta>
                List<DetalleVenta> detallesVenta = detallesVentaDTO.Select(d => new DetalleVenta
                {
                    CodigoProducto = d.CodigoProducto,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    FolioVenta = 0 // Se asignará al guardar la venta
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

                        // Registrar la venta
                        var nuevaVenta = _ventasService.RegistrarVenta(_idUsuario, detallesVenta, pagoRecibido, cambio, "Realizada", 1);

                        // Obtener el FolioVenta generado
                        int folioVenta = nuevaVenta.FolioVenta;

                        // Crear el DTO para la venta
                        var ventaDTO = new VentaDTO
                        {
                            FolioVenta = folioVenta,
                            FechaVenta = DateTime.Now,
                            TotalVenta = totalVenta,
                            NombreUsuario = usuarioLogueado, // El usuario que registró la venta
                            Estado = "Realizada",
                            PagoRecibido = pagoRecibido,
                            Cambio = cambio
                        };

                        // Generar el ticket en PDF
                        var ticketGenerator = new TicketGenerator();
                        ticketGenerator.GenerarTicketPDF(ventaDTO, detallesVentaDTO);

                        MessageBox.Show("Venta registrada y ticket generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                var detailedError = ex.InnerException != null ? ex.InnerException.Message : "Sin detalles adicionales.";
                MessageBox.Show($"Error al registrar la venta: {ex.Message}\nDetalles: {detailedError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_Servicio_Click(object sender, EventArgs e)
        {

        }
    }
}
