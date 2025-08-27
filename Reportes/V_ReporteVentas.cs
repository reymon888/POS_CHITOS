using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using POS_CHITOS.Usuarios;
using POS_CHITOS.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Reportes
{
    public partial class V_ReporteVentas : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly VentasService _ventasService;
        public V_ReporteVentas()
        {
            InitializeComponent();
            var context = new POSContext(new DbContextOptions<POSContext>());
            _usuarioService = new UsuarioService(context);
            _ventasService = new VentasService(context);

            // Cargar los usuarios al inicializar
            CargarUsuarios();

            //DTP_Hasta como maximo fecha actual
            DTP_Hasta.MaxDate = DateTime.Now;

            //Ventana en medio
            StartPosition = FormStartPosition.CenterScreen;

            //No cambiar tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void CargarUsuarios()
        {
            //cargar el combobox con el nombre de los usaurios de tipo cajero
            var usuarios = _usuarioService.listarUsuarios();
            var listaUsuarios = usuarios.Where(u => u.Rol == "Cajero").Select(u => new { u.Id, u.NombreUsuario }).ToList();
            listaUsuarios.Insert(0, new { Id = 0, NombreUsuario = "Todos los usuarios" });

            CB_Usuarios.DataSource = listaUsuarios;
            CB_Usuarios.DisplayMember = "NombreUsuario";
            CB_Usuarios.ValueMember = "Id";
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            // Recoger los parámetros seleccionados
            DateTime fechaDesde = DTP_Desde.Value;
            DateTime fechaHasta = DTP_Hasta.Value;
            int idUsuarioSeleccionado = (int)CB_Usuarios.SelectedValue;


            bool incluirDetalles = check_detallesventas.Checked;
            bool incluirCanceladas = check_ventascanceladas.Checked;

            // Generar el reporte usando los parámetros
            GenerarReporteVentas(fechaDesde, fechaHasta, idUsuarioSeleccionado, incluirDetalles, incluirCanceladas);
        }

        private void GenerarReporteVentas(DateTime fechaDesde, DateTime fechaHasta, int idUsuario, bool incluirDetalles, bool incluirCanceladas)
        {
            // Lógica para obtener las ventas según los filtros
            List<VentaDTO> ventas;
            if (idUsuario == 0) // Todos los usuarios
            {
                ventas = _ventasService.ObtenerVentasPorFecha(fechaDesde, fechaHasta, incluirCanceladas);
            }
            else // Ventas por usuario específico
            {
                ventas = _ventasService.ObtenerVentasPorUsuarioYFecha(idUsuario, fechaDesde, fechaHasta, incluirCanceladas);
            }

            // Si el usuario quiere incluir detalles, cargar detalles adicionales
            if (incluirDetalles)
            {
                ventas.ForEach(v => v.DetallesVenta = _ventasService.ObtenerDetallesDeVenta(v.FolioVenta));
            }

            // Llamar al método para generar el PDF
            GenerarReportePDF(ventas, incluirDetalles);
        }

        private void GenerarReportePDF(List<VentaDTO> ventas, bool incluirDetalles)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte de ventas";
                saveFileDialog.FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Reporte de Ventas";

                    PdfPage page = pdf.AddPage();
                    page.Size = PdfSharp.PageSize.Letter;
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont fontTitulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                    XFont fontTexto = new XFont("Arial", 12);
                    XFont fontNegrita = new XFont("Arial", 12, XFontStyleEx.Bold);
                    XFont fontSubTitulo = new XFont("Arial", 14, XFontStyleEx.Bold);

                    XSolidBrush brushTitulo = new XSolidBrush(XColor.FromArgb(51, 51, 51));
                    XSolidBrush brushFondo = new XSolidBrush(XColor.FromArgb(26, 77, 128));

                    int marginLeft = 40;
                    int marginTop = 40;
                    int lineHeight = 20;
                    int currentY = marginTop;
                    int pageHeight = (int)page.Height;
                    int usableHeight = pageHeight - marginTop * 2;

                    void CrearNuevaPagina()
                    {
                        page = pdf.AddPage();
                        page.Size = PdfSharp.PageSize.Letter;
                        gfx = XGraphics.FromPdfPage(page);
                        currentY = marginTop;
                    }

                    gfx.DrawRectangle(brushFondo, 0, 0, page.Width, 50);
                    gfx.DrawString("Reporte de Ventas", fontTitulo, XBrushes.White, new XRect(0, 10, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += 35;
                    gfx.DrawString("Taller Automotriz Chito's", fontTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;

                    gfx.DrawString("Oscar Raul Rubio Rubio", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("Hidalgo 925, Palma Sola, 48740 El Grullo, Jal.", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("321 690 3502", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    gfx.DrawString($"Rango de fechas: {DTP_Desde.Value.ToString("dddd, dd MMMM yyyy")} - {DTP_Hasta.Value.ToString("dddd, dd MMMM yyyy")}", fontSubTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    gfx.DrawString("Folio", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, 50, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Fecha", fontNegrita, XBrushes.Black, new XRect(marginLeft + 60, currentY, 150, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Total", fontNegrita, XBrushes.Black, new XRect(marginLeft + 220, currentY, 100, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Usuario", fontNegrita, XBrushes.Black, new XRect(marginLeft + 340, currentY, 150, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;

                    gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                    currentY += 5;

                    foreach (var venta in ventas)
                    {
                        if (currentY + lineHeight * 2 > usableHeight)
                        {
                            CrearNuevaPagina();
                        }

                        gfx.DrawString(venta.FolioVenta.ToString(), fontTexto, XBrushes.Black, new XRect(marginLeft, currentY, 50, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(venta.FechaVenta.ToString("dd/MM/yyyy"), fontTexto, XBrushes.Black, new XRect(marginLeft + 60, currentY, 150, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(venta.TotalVenta.ToString("C2"), fontTexto, XBrushes.Black, new XRect(marginLeft + 220, currentY, 100, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(venta.NombreUsuario, fontTexto, XBrushes.Black, new XRect(marginLeft + 340, currentY, 150, lineHeight), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        if (incluirDetalles)
                        {
                            foreach (var detalle in venta.DetallesVenta)
                            {
                                // Tomar la descripción directamente de detallesventas
                                string descripcionProducto = !string.IsNullOrEmpty(detalle.DescripcionProducto)
                                                             ? detalle.DescripcionProducto
                                                             : "Producto sin descripción";

                                // Generar la línea de texto para el producto
                                string productoTexto = $" - {descripcionProducto}: {detalle.Cantidad} x {detalle.PrecioUnitario.ToString("C2")} = {detalle.Total.ToString("C2")}";

                                // Verificar si hay suficiente espacio en la página
                                if (currentY + lineHeight > usableHeight)
                                {
                                    CrearNuevaPagina();
                                }

                                // Dibujar el detalle en el PDF
                                gfx.DrawString(productoTexto, fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                                currentY += lineHeight;
                            }

                        }

                        gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                        currentY += 5;
                    }

                    float totalVentas = ventas.Sum(v => v.TotalVenta);
                    int totalVentasCount = ventas.Count;

                    gfx.DrawString($"Total de ventas: {totalVentasCount}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, 200, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString($"Total: {totalVentas.ToString("C2")}", fontNegrita, XBrushes.Black, new XRect(marginLeft + 220, currentY, 100, lineHeight), XStringFormats.TopLeft);

                    pdf.Save(filePath);

                    try
                    {
                        Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"El reporte se guardó correctamente, pero no se pudo abrir automáticamente. Error: {ex.Message}", "Error al abrir el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

