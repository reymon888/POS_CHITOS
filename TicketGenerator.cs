
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class TicketGenerator
    {
        public void GenerarTicketPDF(VentaDTO venta, List<DetalleVentaDTO> detallesVenta)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                FileName = $"Ticket_Venta_{venta.FolioVenta}.pdf" // El nombre del archivo usa correctamente el FolioVenta
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;

                try
                {
                    using (PdfDocument document = new PdfDocument())
                    {
                        document.Info.Title = $"Ticket de Venta - {venta.FolioVenta}"; // Título del PDF
                        PdfPage page = document.AddPage();
                        page.Width = XUnit.FromMillimeter(55); // Ancho típico de ticket
                        page.Height = XUnit.FromMillimeter(150); // Ajusta la altura según sea necesario

                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XFont font = new XFont("Arial", 6, XFontStyleEx.Regular);
                        XFont fontBold = new XFont("Arial", 7, XFontStyleEx.Bold);

                        double yPosition = 10;

                        // Información del negocio
                        gfx.DrawString("TALLER AUTOMOTRIZ CHITO'S", fontBold, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                        yPosition += 12;
                        gfx.DrawString("Hidalgo 925, Palma Sola,", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                        yPosition += 12;
                        gfx.DrawString("48740 El Grullo, Jal.", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                        yPosition += 12;
                        gfx.DrawString("Tel: 321 690 3502", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                        yPosition += 20;
                       
                        // Información del ticket
                        gfx.DrawString($"Folio: {venta.FolioVenta}", fontBold, XBrushes.Black, 10, yPosition);
                        yPosition += 12;
                        gfx.DrawString($"Fecha: {venta.FechaVenta:dd/MM/yyyy HH:mm:ss}", font, XBrushes.Black, 10, yPosition);
                        yPosition += 12;
                        gfx.DrawString($"Cliente: Público General", font, XBrushes.Black, 10, yPosition);
                        yPosition += 12;
                        gfx.DrawString($"Atendido por: {venta.NombreUsuario}", font, XBrushes.Black, 10, yPosition); // El nombre del usuario logueado
                        yPosition += 20;

                        // Encabezados de los productos
                        gfx.DrawString("CANT   $ C/U.    IMPORTE", fontBold, XBrushes.Black, 10, yPosition);
                        yPosition += 10;
                        gfx.DrawString("------------------------------------------------------------", font, XBrushes.Black, 10, yPosition);
                        yPosition += 12;

                        // Detalles de los productos
                        foreach (var detalle in detallesVenta)
                        {
                            gfx.DrawString($"{detalle.DescripcionProducto}", font, XBrushes.Black, 10, yPosition); // Descripción del producto
                            yPosition += 12;
                            gfx.DrawString($"{detalle.Cantidad} -----  {detalle.PrecioUnitario.ToString("C2")} -----  {detalle.Total.ToString("C2")}", font, XBrushes.Black, 10, yPosition);
                            yPosition += 12;
                        }

                        gfx.DrawString("------------------------------------------------------------", font, XBrushes.Black, 10, yPosition);
                        yPosition += 12;

                        // Totales
                        gfx.DrawString($"Total: {venta.TotalVenta.ToString("C2")}", fontBold, XBrushes.Black, 10, yPosition);
                        yPosition += 12;
                        gfx.DrawString($"Pago Recibido: {venta.PagoRecibido.ToString("C2")}", font, XBrushes.Black, 10, yPosition);
                        yPosition += 12;
                        gfx.DrawString($"Cambio: {venta.Cambio.ToString("C2")}", font, XBrushes.Black, 10, yPosition);
                        yPosition += 20;

                        // Guardar el archivo
                        document.Save(rutaArchivo);
                        Process.Start(new ProcessStartInfo(rutaArchivo) { UseShellExecute = true });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}








