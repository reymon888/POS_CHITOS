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
    public partial class V_MostrarDetallesCompras : Form
    {
        private readonly int _idCompra;
        private readonly ComprasService _comprasService;
        private readonly ProveedoresService _proveedoresService;

        public V_MostrarDetallesCompras(int idCompra)
        {
            InitializeComponent();

            _idCompra = idCompra;
            var context = new POSContext(new DbContextOptions<POSContext>());
            _comprasService = new ComprasService(context);
            _proveedoresService = new ProveedoresService(context);

            // Cargar los detalles de la compra y los datos de la cabecera
            CargarDatosCompra(_idCompra);
        }

        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            // Actualizar los detalles si es necesario
            CargarDetallesCompra(_idCompra);
        }

        public void CargarDetallesCompra(int idCompra)
        {
            try
            {
                // Obtener los detalles de la compra por su ID
                var detallesCompra = _comprasService.ObtenerDetallesCompra(_idCompra);

                // Limpiar el DataSource antes de volver a asignar
                DGV_DetallesCompras.DataSource = null;

                DGV_DetallesCompras.DataSource = detallesCompra;

                // Configuración de las columnas con anchos personalizados
                if (DGV_DetallesCompras.Columns["CodigoProducto"] != null)
                {
                    DGV_DetallesCompras.Columns["CodigoProducto"].HeaderText = "Codigo Producto";
                    DGV_DetallesCompras.Columns["CodigoProducto"].Width = 150;  // Ancho personalizado en píxeles
                }

                if (DGV_DetallesCompras.Columns["DescripcionProducto"] != null)
                {
                    DGV_DetallesCompras.Columns["DescripcionProducto"].HeaderText = "Descripcion";
                    DGV_DetallesCompras.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;  // Ocupa el espacio sobrante
                }

                if (DGV_DetallesCompras.Columns["Cantidad"] != null)
                {
                    DGV_DetallesCompras.Columns["Cantidad"].HeaderText = "Cantidad";
                    DGV_DetallesCompras.Columns["Cantidad"].Width = 150;  // Ancho personalizado en píxeles
                }

                if (DGV_DetallesCompras.Columns["PrecioUnitario"] != null)
                {
                    DGV_DetallesCompras.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                    DGV_DetallesCompras.Columns["PrecioUnitario"].Width = 150;  // Ancho personalizado en píxeles
                }

                // Configurar la fuente de las celdas
                DGV_DetallesCompras.DefaultCellStyle.Font = new Font("Arial", 14);

                // Configurar el fondo y el color de texto de las celdas
                DGV_DetallesCompras.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Fondo blanco
                DGV_DetallesCompras.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua

                // Configurar el fondo y el color de texto de los encabezados
                DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro
                DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Texto blanco

                // Asegurar que la tabla no use colores predeterminados del sistema
                DGV_DetallesCompras.EnableHeadersVisualStyles = false;

                // Alternar colores de las filas
                DGV_DetallesCompras.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro
                DGV_DetallesCompras.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua

                // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
                DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro
                DGV_DetallesCompras.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco

                // No tener el DGV seleccionado
                DGV_DetallesCompras.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosCompra(int idCompra)
        {
            try
            {
                // Obtener los datos de la compra (cabecera)
                var compra = _comprasService.ObtenerDetalCompra(idCompra);
                if (compra != null)
                {
                    // Cargar los datos del proveedor, usuario, id de compra y fecha
                    TB_Proveedor.Text = compra.Proveedor.NombreProveedor;
                    TB_Usuario.Text = compra.Usuario.NombreUsuario;
                    TB_IdCompra.Text = compra.FolioCompraOriginal.ToString();  // Cambiar por el campo correcto
                    dateTimePicker1.Value = compra.FechaCompra;

                    // Cargar los detalles de la compra
                    CargarDetallesCompra(idCompra);

                    // Calcular el total de la compra
                    CalcularTotalCompra();
                }
                else
                {
                    MessageBox.Show("No se encontró la compra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de la compra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
