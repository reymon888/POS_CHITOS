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
    public partial class V_MostrarDetallesVenta : Form
    {
        private readonly int _FolioVenta;
        private readonly VentasService VentasService;
        public V_MostrarDetallesVenta(int FolioVenta)
        {
            InitializeComponent();
            _FolioVenta = FolioVenta;
            var context = new POSContext(new DbContextOptions<POSContext>());
            VentasService = new VentasService(context);
          
            CargarDetallesVenta(_FolioVenta);
            CalcularTotalVenta();


        }

        private void CargarDetallesVenta(int FolioVenta)
        {
            try
            {
                // Obtener los detalles de la venta por su FolioVenta
                var venta = VentasService.ObtenerVentaPorFolio(FolioVenta);

                // Verifica que la venta no sea null antes de proceder
                if (venta == null)
                {
                    MessageBox.Show("La venta no fue encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Configura los controles con los datos de la venta
                TB_Usuario.Text = venta.NombreUsuario ?? "N/A"; // Maneja si NombreUsuario es null
                TB_FolioVenta.Text = venta.FolioVenta.ToString();
                dateTimePicker1.Value = venta.FechaVenta;

                // Asignar los detalles al DataGridView
                DGV_DetallesVentas.DataSource = venta.DetallesVenta;

                // Realiza configuraciones adicionales de columnas y otros ajustes
                ConfigurarColumnasDGV();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los detalles de la VENTA: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConfigurarColumnasDGV()
        {
            if (DGV_DetallesVentas.Columns["CodigoProducto"] != null)
            {
                DGV_DetallesVentas.Columns["CodigoProducto"].HeaderText = "Codigo Producto";
                DGV_DetallesVentas.Columns["CodigoProducto"].Width = 150;
            }

            if (DGV_DetallesVentas.Columns["DescripcionProducto"] != null)
            {
                DGV_DetallesVentas.Columns["DescripcionProducto"].HeaderText = "Descripcion";
                DGV_DetallesVentas.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            if (DGV_DetallesVentas.Columns["Cantidad"] != null)
            {
                DGV_DetallesVentas.Columns["Cantidad"].HeaderText = "Cantidad";
                DGV_DetallesVentas.Columns["Cantidad"].Width = 150;
            }

            if (DGV_DetallesVentas.Columns["PrecioUnitario"] != null)
            {
                DGV_DetallesVentas.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";
                DGV_DetallesVentas.Columns["PrecioUnitario"].Width = 150;
            }

            if (DGV_DetallesVentas.Columns["Total"] != null)
            {
                DGV_DetallesVentas.Columns["Total"].HeaderText = "Total";
                DGV_DetallesVentas.Columns["Total"].Width = 150;
            }

            // Configuraciones adicionales de la tabla
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
            DGV_DetallesVentas.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_DetallesVentas.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesVentas.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesVentas.EnableHeadersVisualStyles = false;
            DGV_DetallesVentas.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_DetallesVentas.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_DetallesVentas.ClearSelection();

            //Poner el contenido de la tabla en medio
            DGV_DetallesVentas.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Eliminar el contorno de las celdas
            DGV_DetallesVentas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_DetallesVentas.RowHeadersVisible = false;

            // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro
            DGV_DetallesVentas.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco
        }

        private void CalcularTotalVenta()
        {
            // Cambia 'DetallesVentaDTO' por el tipo correcto 'DetalleVentaDTO'
            var detallesVenta = (List<DetalleVentaDTO>)DGV_DetallesVentas.DataSource;
            if (detallesVenta != null)
            {
                var totalVenta = detallesVenta.Sum(d => d.Total);
                TB_TotalVenta.Text = totalVenta.ToString("C2");
            }
        }

    }
}
