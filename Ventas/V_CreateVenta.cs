using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Inventario;
using POS_CHITOS.Usuarios;
using POS_CHITOS.Ventas;
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
        private readonly CortesService _cortesService;

        public V_CreateVenta(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;

            var context = new POSContext(new DbContextOptions<POSContext>());
            _ventasService = new VentasService(context);
            _inventarioService = new inventarioService(context);
            _usuarioService = new UsuarioService(context);
            _cortesService = new CortesService(context);



            B_EliminarProducto.Enabled = false;
            B_ModificarCantidad.Enabled = false;
            // Configurar las columnas del DataGridView

            ConfigurarAutoCompleteProducto();
            VerificarSeleccionFila(); // Verificar inicialmente si hay fila seleccionada

            // Configurar el DateTimePicker y CheckBox
           
           
        }

        // Método para configurar las columnas del DataGridView
        private void ConfigurarColumnasDataGridView()
        {
            DGV_DetallesVenta.Columns.Clear(); // Limpiar columnas anteriores

            DGV_DetallesVenta.Columns.Add("CodigoProducto", "Código");
            DGV_DetallesVenta.Columns.Add("DescripcionProducto", "Descripción");
            DGV_DetallesVenta.Columns.Add("Cantidad", "Cantidad");
            DGV_DetallesVenta.Columns.Add("PrecioUnitario", "Precio Unitario");
            DGV_DetallesVenta.Columns.Add("PrecioTotal", "Precio Total");

            // Configurar el formato de las columnas
            DGV_DetallesVenta.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C2"; // Formato moneda
            DGV_DetallesVenta.Columns["PrecioTotal"].DefaultCellStyle.Format = "C2"; // Formato moneda

            // Configurar los anchos de las columnas
            DGV_DetallesVenta.Columns["CodigoProducto"].Width = 100;
            DGV_DetallesVenta.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGV_DetallesVenta.Columns["Cantidad"].Width = 80;
            DGV_DetallesVenta.Columns["PrecioUnitario"].Width = 100;
            DGV_DetallesVenta.Columns["PrecioTotal"].Width = 100;
            DGV_DetallesVenta.AllowUserToAddRows = false;

            // Aplicar los estilos personalizados para la tabla
            ConfigurarEstiloTabla();
        }

        private void ConfigurarAutoCompleteProducto()
        {
            // Excluir productos con stock 0 en el autocomplete
            var productos = _inventarioService.listarInventarioParaVentas()
                                              .Where(p => p.Stock > 0) // Solo productos con stock mayor a 0
                                              .Select(p => p.CodigoProducto + " - " + p.DescripcionProducto)
                                              .ToList();

            // Aquí podrías agregar un log para verificar los productos cargados
            foreach (var producto in productos)
            {
                Console.WriteLine("Producto disponible para autocompletado: " + producto);
            }

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
                            TB_Producto.Text = "";
                            TB_Producto.Focus();
                        }
                        else
                        {
                            CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
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

        private void VerificarSeleccionFila()
        {
            // Verificar si hay filas seleccionadas en la tabla
            bool filaSeleccionada = DGV_DetallesVenta.SelectedRows.Count > 0;

            // Habilitar o deshabilitar botones según la selección de la fila

            B_EliminarProducto.Enabled = filaSeleccionada;
            B_ModificarCantidad.Enabled = filaSeleccionada;
            B_AgregarVenta.Enabled = DGV_DetallesVenta.Rows.Count > 0; // Solo habilitar si hay productos
        }


        private void ModificarCantidadProducto(DetalleVentaDTO detalleSeleccionado)
        {
            float nuevaCantidad;
            if (CustomInputBox.Show("Ingrese la nueva cantidad para el producto seleccionado:", "Modificar Cantidad", detalleSeleccionado.Cantidad, out nuevaCantidad) == DialogResult.OK)
            {
                if (nuevaCantidad > 0)
                {
                    // Verificar si la nueva cantidad no excede el stock disponible
                    var productoSeleccionado = _inventarioService.ObtenerProductoPorCodigo(detalleSeleccionado.CodigoProducto);
                    if (productoSeleccionado != null && nuevaCantidad > productoSeleccionado.Stock)
                    {
                        CustomMessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error");
                        return;
                    }

                    // Actualizar la cantidad y el total
                    detalleSeleccionado.Cantidad = (int)nuevaCantidad;
                    detalleSeleccionado.Total = detalleSeleccionado.Cantidad * detalleSeleccionado.PrecioUnitario;

                    // Refrescar la tabla y calcular el total
                    ActualizarTablaDetalles((List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource);
                }
                else
                {
                    CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
                }
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
            var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
            if (detallesVenta == null)
            {
                detallesVenta = new List<DetalleVentaDTO>();
            }

            // Verificar si el producto ya existe en la tabla
            var detalleExistente = detallesVenta.FirstOrDefault(d => d.CodigoProducto == producto.CodigoProducto);
            if (detalleExistente != null)
            {
                // Verificar si la nueva cantidad excede el stock disponible
                if (detalleExistente.Cantidad + cantidad > producto.Stock)
                {
                    CustomMessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error");
                    return;
                }

                // Si existe, incrementar la cantidad y actualizar el total
                detalleExistente.Cantidad += cantidad;
                detalleExistente.Total = detalleExistente.Cantidad * detalleExistente.PrecioUnitario;
            }
            else
            {
                // Verificar si la cantidad inicial excede el stock disponible
                if (cantidad > producto.Stock)
                {
                    CustomMessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error");
                    return;
                }

                // Si no existe, agregar un nuevo detalle
                var nuevoDetalle = new DetalleVentaDTO
                {
                    CodigoProducto = producto.CodigoProducto,
                    DescripcionProducto = producto.DescripcionProducto,
                    Cantidad = cantidad,
                    PrecioUnitario = precioVenta,
                    Total = cantidad * precioVenta
                };

                detallesVenta.Add(nuevoDetalle);
            }

            // Actualizar la tabla y el total
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

                // Obtener la fecha de la venta según el estado del checkbox
                DateTime fechaVenta = DateTime.Now;
                var usuarioLogueado = _usuarioService.ObtenerNombreUsuarioPorId(_idUsuario);
                var corteVigente = _cortesService.ObtenerCorteNoRealizado(_idUsuario);

                if (corteVigente == null)
                {
                    MessageBox.Show("No hay un corte de caja activo. No se puede realizar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Convertir List<DetalleVentaDTO> a List<DetalleVenta>
                List<DetalleVenta> detallesVenta = detallesVentaDTO.Select(d => new DetalleVenta
                {
                    CodigoProducto = d.CodigoProducto,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    DescripcionProducto = d.CodigoProducto == "0" ? d.DescripcionProducto : null, // Solo productos varios tendrán descripción
                    FolioVenta = 0
                }).ToList();

                // Calcular el total de la venta
                float totalVenta = detallesVenta.Sum(d => d.Cantidad * d.PrecioUnitario);

                // Mostrar la ventana para recibir el pago
                using (var recibirPago = new V_RecibirPagoVenta(totalVenta))
                {
                    if (recibirPago.ShowDialog() == DialogResult.OK)
                    {
                        float pagoRecibido = recibirPago.PagoRecibido;
                        float cambio = recibirPago.Cambio;

                        // Registrar la venta
                        var nuevaVenta = _ventasService.RegistrarVenta(_idUsuario, fechaVenta, detallesVenta, pagoRecibido, cambio, "Realizada", corteVigente.IdCorte);
                        int folioVenta = nuevaVenta.FolioVenta;

                        // Crear el DTO para la venta
                        var ventaDTO = new VentaDTO
                        {
                            FolioVenta = folioVenta,
                            FechaVenta = fechaVenta,
                            TotalVenta = totalVenta,
                            NombreUsuario = usuarioLogueado,
                            Estado = "Realizada",
                            PagoRecibido = pagoRecibido,
                            Cambio = cambio
                        };

                        // Generar el ticket solo si el checkbox está marcado
                        if (check_ticket.Checked)
                        {
                            var ticketGenerator = new TicketGenerator();
                            ticketGenerator.GenerarTicketPDF(ventaDTO, detallesVentaDTO);
                            MessageBox.Show("Venta registrada y ticket generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

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

        private void DGV_DetallesVenta_SelectionChanged(object sender, EventArgs e)
        {
            VerificarSeleccionFila();
        }

        private void B_CancelarVenta_Click(object sender, EventArgs e)
        {
            //Preguntar si esta seguro de cancelar la venta y cancelarla si dice que si usa el CustomMessageBox
            DialogResult dialogResult = CustomMessageBox.Show("¿Está seguro que desea cancelar la venta?", "Cancelar Venta");
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void B_CambiarPrecio_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesVenta.SelectedRows.Count > 0)
            {
                var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                var detalleSeleccionado = detallesVenta[DGV_DetallesVenta.SelectedRows[0].Index];

                // Cambiar el precio con el CustomInputBox
                float nuevoPrecio;
                if (CustomInputBox.Show("Ingrese el nuevo precio para el producto seleccionado:", "Modificar Precio", detalleSeleccionado.PrecioUnitario, out nuevoPrecio) == DialogResult.OK)
                {
                    if (nuevoPrecio > 0)
                    {
                        detalleSeleccionado.PrecioUnitario = nuevoPrecio;
                        detalleSeleccionado.Total = detalleSeleccionado.Cantidad * nuevoPrecio;
                        ActualizarTablaDetalles(detallesVenta);
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor ingrese un precio válido.", "Error");
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("Seleccione un producto para modificar su precio.", "Advertencia");
            }
        }

        private void B_EliminarProducto_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesVenta.SelectedRows.Count > 0)
            {
                var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                var detalleSeleccionado = detallesVenta[DGV_DetallesVenta.SelectedRows[0].Index];

                // Confirmar eliminación con el CustomMessageBox
                DialogResult result = CustomMessageBox.Show($"¿Está seguro que desea eliminar el producto {detalleSeleccionado.CodigoProducto}?", "Eliminar Producto");

                if (result == DialogResult.Yes)
                {
                    detallesVenta.Remove(detalleSeleccionado);
                    ActualizarTablaDetalles(detallesVenta);
                }
            }
            else
            {
                CustomMessageBox.Show("Seleccione un producto para eliminar.", "Advertencia");
            }
        }

        private void B_ModificarCantidad_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesVenta.SelectedRows.Count > 0)
            {
                var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                var detalleSeleccionado = detallesVenta[DGV_DetallesVenta.SelectedRows[0].Index];

                // Cambiar la cantidad con el CustomInputBox
                float nuevaCantidad;
                if (CustomInputBox.Show("Ingrese la nueva cantidad para el producto seleccionado:", "Modificar Cantidad", detalleSeleccionado.Cantidad, out nuevaCantidad) == DialogResult.OK)
                {
                    if (nuevaCantidad > 0)
                    {
                        // Verificar si la cantidad no excede el stock disponible
                        var productoSeleccionado = _inventarioService.ObtenerProductoPorCodigo(detalleSeleccionado.CodigoProducto);
                        if (productoSeleccionado != null && nuevaCantidad > productoSeleccionado.Stock)
                        {
                            CustomMessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error");
                            return;
                        }

                        detalleSeleccionado.Cantidad = (int)nuevaCantidad;
                        detalleSeleccionado.Total = detalleSeleccionado.Cantidad * detalleSeleccionado.PrecioUnitario;
                        ActualizarTablaDetalles(detallesVenta);
                    }
                    else
                    {
                        CustomMessageBox.Show("Por favor ingrese una cantidad válida.", "Error");
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("Seleccione un producto para modificar su cantidad.", "Advertencia");
            }
        }

       

        private void DGV_DetallesVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
                var detalleSeleccionado = detallesVenta[e.RowIndex];

                if (e.ColumnIndex == DGV_DetallesVenta.Columns["DescripcionProducto"].Index)
                {
                    // Verificar si el producto es un producto vario
                    if (detalleSeleccionado.CodigoProducto.StartsWith("VARIO"))
                    {
                        // Abrir la ventana para cambiar la descripción
                        using (var cambiarDescripcionForm = new V_CambiarDescripcion(detalleSeleccionado.DescripcionProducto))
                        {
                            if (cambiarDescripcionForm.ShowDialog() == DialogResult.OK)
                            {
                                // Actualizar la descripción del producto vario
                                detalleSeleccionado.DescripcionProducto = cambiarDescripcionForm.NuevoNombre;

                                // Refrescar la tabla para mostrar la nueva descripción
                                ActualizarTablaDetalles(detallesVenta);
                            }
                        }
                    }
                }
                else if (e.ColumnIndex == DGV_DetallesVenta.Columns["Cantidad"].Index)
                {
                    // Cambiar la cantidad (lógica ya existente)
                    ModificarCantidadProducto(detalleSeleccionado);
                }
                else if (e.ColumnIndex == DGV_DetallesVenta.Columns["PrecioUnitario"].Index)
                {
                    // Cambiar el precio (lógica ya existente)
                    float nuevoPrecio;
                    if (CustomInputBox.Show("Ingrese el nuevo precio para el producto seleccionado:", "Modificar Precio", detalleSeleccionado.PrecioUnitario, out nuevoPrecio) == DialogResult.OK)
                    {
                        if (nuevoPrecio > 0)
                        {
                            detalleSeleccionado.PrecioUnitario = nuevoPrecio;
                            detalleSeleccionado.Total = detalleSeleccionado.Cantidad * nuevoPrecio;
                            ActualizarTablaDetalles(detallesVenta);
                        }
                        else
                        {
                            CustomMessageBox.Show("Por favor ingrese un precio válido.", "Error");
                        }
                    }
                }
            }
        }

        private void B_BuscarProducto_Click(object sender, EventArgs e)
        {   // Instanciar la ventana de selección de productos
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
        private void AgregarProductoAVenta(InventarioDTO producto)
        {
            // Asegúrate de que el producto no es null
            if (producto == null)
            {
                MessageBox.Show("No se ha seleccionado un producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Configura la cantidad por defecto como 1 (esto puedes permitir que el usuario lo modifique si es necesario)
            int cantidadAgregar = 1;

            // Verificar si el producto ya existe en el DataGridView
            foreach (DataGridViewRow row in DGV_DetallesVenta.Rows)
            {
                if (row.Cells["CodigoProducto"].Value.ToString() == producto.CodigoProducto)
                {
                    // Si el producto ya está en el DataGridView, incrementa la cantidad
                    int cantidadExistente = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    int nuevaCantidad = cantidadExistente + cantidadAgregar;

                    // Validar que no exceda el stock disponible
                    if (nuevaCantidad > producto.Stock)
                    {
                        MessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar la cantidad y el total
                    row.Cells["Cantidad"].Value = nuevaCantidad;
                    row.Cells["PrecioTotal"].Value = nuevaCantidad * producto.PrecioVenta;

                    // Opcional: Desmarcar todas las filas después de actualizar
                    DGV_DetallesVenta.ClearSelection();
                    return;
                }
            }

            // Si el producto no está en la lista, agregar una nueva fila
            if (cantidadAgregar > producto.Stock)
            {
                MessageBox.Show("La cantidad seleccionada excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Agregar una nueva fila al DataGridView
            float precioTotal = producto.PrecioVenta * cantidadAgregar;
            DGV_DetallesVenta.Rows.Add(producto.CodigoProducto, producto.DescripcionProducto, cantidadAgregar, producto.PrecioVenta, precioTotal);

            // Opcional: Desmarcar todas las filas después de agregar
            DGV_DetallesVenta.ClearSelection();
        }

        private void B_AgregarProductoVario_Click(object sender, EventArgs e)
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

        private void AgregarProductoVarioADetalles(string descripcion)
        {
            var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVenta.DataSource;
            if (detallesVenta == null)
            {
                detallesVenta = new List<DetalleVentaDTO>();
            }

            // Crear el producto vario con CódigoProducto = '0' y la descripción personalizada
            var productoVario = new DetalleVentaDTO
            {
                CodigoProducto = "0",
                DescripcionProducto = descripcion,
                
            };

            detallesVenta.Add(productoVario);
            ActualizarTablaDetalles(detallesVenta);
        }

        //Metodo para atajos de teclado 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarVenta.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.P))
            {
                B_AgregarProductoVario.PerformClick();
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
                DGV_DetallesVenta.Focus();
                return true;
            }
            if (keyData == (Keys.Escape))
            {
                B_CancelarVenta.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.K))
            {
                check_ticket.Checked = !check_ticket.Checked;
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                B_BuscarProducto.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
