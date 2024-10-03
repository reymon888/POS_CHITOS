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
    public partial class V_CreateCompra : Form
    {
        private readonly ComprasService _compraService;
        private readonly ProveedoresService _proveedoresService;
        private readonly inventarioService _inventarioService;
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

            // Configurar autocompletes
            ConfigurarAutoCompleteProveedor();
            ConfigurarAutoCompleteProducto();

            // Configurar el DateTimePicker
            ConfigurarDateTimePicker();
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
                var usuario = _compraService.ObtenerUsuarioPorId(_idUsuario); // Asegúrate de tener este método en tu servicio
                if (usuario == null)
                {
                    MessageBox.Show("El usuario no existe. Verifica el ID del usuario logueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nuevaFechaCompra = dateTimePicker1.Value;
                var detallesCompraDTO = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;

                if (detallesCompraDTO == null || detallesCompraDTO.Count == 0)
                {
                    MessageBox.Show("No se pueden guardar cambios sin productos en la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Registrar la compra
                _compraService.RegistrarCompra(proveedorSeleccionado.idProveedor,nuevaFechaCompra, detallesCompra, _idUsuario, "Realizada", folioCompraOriginal,1);

                //// Actualizar el stock del inventario para cada producto
                //foreach (var detalle in detallesCompra)
                //{
                //    var producto = _inventarioService.ObtenerProductoPorCodigo(detalle.CodigoProducto);
                //    if (producto != null)
                //    {
                //        _inventarioService.AumentarStock(detalle.CodigoProducto, detalle.Cantidad);
                //    }
                //}

                MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Obtener mensaje detallado de la excepción interna
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
                DGV_DetallesCompras.Columns["CodigoProducto"].Width = 150;
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
                DGV_DetallesCompras.Columns["PrecioUnitario"].Width = 150;
            }

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


        private void ConfigurarDateTimePicker()
        {
            dateTimePicker1.MinDate = DateTime.Now.AddMonths(-2);
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
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
            if (MessageBox.Show("¿Está seguro que desea cancelar la compra?", "Cancelar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        // Solicitar el precio de compra al usuario
                        string precioCompraTexto = Microsoft.VisualBasic.Interaction.InputBox(
                            "Ingrese el precio de compra para el producto seleccionado:", "Precio de Compra", productoSeleccionado.PrecioCompra.ToString());

                        if (!float.TryParse(precioCompraTexto, out float precioCompra) || precioCompra <= 0)
                        {
                            MessageBox.Show("Por favor ingrese un precio de compra válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string cantidadTexto = Microsoft.VisualBasic.Interaction.InputBox(
                            "Ingrese la cantidad para el producto seleccionado:", "Cantidad", "1");

                        if (int.TryParse(cantidadTexto, out int cantidad) && cantidad > 0)
                        {
                            // Agregar el producto a los detalles con el precio de compra ingresado
                            AgregarProductoADetalles(productoSeleccionado, cantidad, precioCompra);
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
            // Eliminar el producto seleccionado de la compra
            if (DGV_DetallesCompras.SelectedRows.Count > 0)
            {
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[DGV_DetallesCompras.SelectedRows[0].Index];

                DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar el producto {detalleSeleccionado.CodigoProducto}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    detallesCompra.Remove(detalleSeleccionado);
                    ActualizarTablaDetalles(detallesCompra);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar de la compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void B_ModificarCantidad_Click(object sender, EventArgs e)
        {
            if (DGV_DetallesCompras.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[DGV_DetallesCompras.SelectedRows[0].Index];

                // Abrir el cuadro de diálogo para modificar la cantidad
                ModificarCantidadProducto(detalleSeleccionado);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para modificar su cantidad.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}


