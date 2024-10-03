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
    public partial class V_ModificarCompra : Form
    {
        private readonly ComprasService _compraService;
        private readonly ProveedoresService _proveedoresService;
        private readonly inventarioService _inventarioService;
        private readonly int _idCompra;

        public V_ModificarCompra(int idCompra)
        {
            InitializeComponent();

            _idCompra = idCompra;
            var context = new POSContext(new DbContextOptions<POSContext>());
            _compraService = new ComprasService(context);
            _proveedoresService = new ProveedoresService(context);
            _inventarioService = new inventarioService(context);

            // Configurar autocompletes
            ConfigurarAutoCompleteProveedor();
            ConfigurarAutoCompleteProducto();

            // Cargar los detalles de la compra
            CargarDatosCompra(_idCompra);

            // Configurar el DateTimePicker
            ConfigurarDateTimePicker();
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

        private void CargarDatosCompra(int idCompra)
        {
            var compra = _compraService.ObtenerDetalCompra(idCompra);
            if (compra != null)
            {
                TB_Proveedor.Text = compra.Proveedor.NombreProveedor;
                TB_FolioCompra.Text = compra.FolioCompraOriginal;
                CargarDetallesCompra(idCompra);
                dateTimePicker1.Value = compra.FechaCompra;
                CalcularTotalCompra();  // Calcular el total cuando se cargan los detalles de la compra
            }
            else
            {
                MessageBox.Show("No se encontró la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDetallesCompra(int idCompra)
        {
            try
            {
                var detallesCompra = _compraService.ObtenerDetallesCompra(idCompra);
                DGV_DetallesCompras.DataSource = null;
                DGV_DetallesCompras.DataSource = detallesCompra;

                // Ajustar configuración visual de la tabla
                ConfigurarEstiloTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarEstiloTabla()
        {
            if (DGV_DetallesCompras.Columns["CodigoProducto"] != null)
            {
                DGV_DetallesCompras.Columns["CodigoProducto"].HeaderText = "Codigo Producto";
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
                DGV_DetallesCompras.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                DGV_DetallesCompras.Columns["PrecioUnitario"].Width = 150;
            }

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

        private void ConfigurarDateTimePicker()
        {
            dateTimePicker1.MinDate = DateTime.Now.AddMonths(-2);
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm tt";
        }

        private void DGV_DetallesCompras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DGV_DetallesCompras.Columns["Cantidad"].Index)
            {
                // Obtener la fila seleccionada
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[e.RowIndex];

                // Abrir el cuadro de diálogo para modificar la cantidad
                ModificarCantidadProducto(detalleSeleccionado);
            }


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

        private void B_AgregarNuevoProducto_Click(object sender, EventArgs e)
        {
            //abrir ventana de agregar producto
            V_CreateInventario ventanaAgregarProducto = new V_CreateInventario();
            ventanaAgregarProducto.ShowDialog();
            ConfigurarAutoCompleteProducto();

        }

        private void B_AgregarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar proveedor
                var proveedorSeleccionado = _proveedoresService.ObtenerProveedorPorNombre(TB_Proveedor.Text);
                if (proveedorSeleccionado == null)
                {
                    MessageBox.Show("El proveedor ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar la fecha de la compra
                var nuevaFechaCompra = dateTimePicker1.Value;

                // Obtener los detalles de la compra
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                if (detallesCompra == null || detallesCompra.Count == 0)
                {
                    MessageBox.Show("No se pueden guardar cambios sin productos en la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string folioCompraOriginal = TB_FolioCompra.Text;
                float totalCompra = detallesCompra.Sum(d => d.Total);
                // Guardar los cambios de la compra
                _compraService.ActualizarCompra(_idCompra, proveedorSeleccionado.idProveedor, folioCompraOriginal, nuevaFechaCompra, totalCompra, detallesCompra);

                MessageBox.Show("Los cambios han sido guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario después de guardar los cambios
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void B_CancelarCompra_Click(object sender, EventArgs e)
        {
            // Cerrar el formulario sin guardar cambios si el usuario confirma
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar la modificación de la compra?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void B_EliminarProducto_Click(object sender, EventArgs e)
        {
            //Eliminar producto seleccionado 
            if (DGV_DetallesCompras.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var detallesCompra = (List<DetalleCompraDTO>)DGV_DetallesCompras.DataSource;
                var detalleSeleccionado = detallesCompra[DGV_DetallesCompras.SelectedRows[0].Index];

                // Preguntar al usuario si está seguro de eliminar el producto
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el producto {detalleSeleccionado.CodigoProducto} de la compra?",
                    "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el producto de la lista y refrescar la tabla
                    detallesCompra.Remove(detalleSeleccionado);
                    ActualizarTablaDetalles(detallesCompra);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto para eliminar de la compra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelSuperior_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}





