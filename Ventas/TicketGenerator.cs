
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Ventas
{
    public class TicketGenerator
    {
        
            public void GenerarTicketPDF(VentaDTO venta, List<DetalleVentaDTO> detallesVenta)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files (*.pdf)|*.pdf",
                    FileName = $"Ticket_Venta_{venta.FolioVenta}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaArchivo = saveFileDialog.FileName;

                    try
                    {
                        using (PdfDocument document = new PdfDocument())
                        {
                            document.Info.Title = $"Ticket de Venta - {venta.FolioVenta}";
                            PdfPage page = document.AddPage();
                            page.Width = XUnit.FromMillimeter(85);
                            page.Height = XUnit.FromMillimeter(200);

                            XGraphics gfx = XGraphics.FromPdfPage(page);
                            XFont font = new XFont("Arial", 10, XFontStyleEx.Regular);
                            XFont fontBold = new XFont("Arial", 12, XFontStyleEx.Bold);

                            double yPosition = 15;

                            // Información del negocio
                            gfx.DrawString("TALLER AUTOMOTRIZ CHITO'S", fontBold, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                            yPosition += 18;
                            gfx.DrawString("Hidalgo 925, Palma Sola,", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                            yPosition += 15;
                            gfx.DrawString("48740 El Grullo, Jal.", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                            yPosition += 15;
                            gfx.DrawString("Tel: 321 690 3502", font, XBrushes.Black, new XRect(0, yPosition, page.Width, page.Height), XStringFormats.TopCenter);
                            yPosition += 25;

                            // Información del ticket
                            gfx.DrawString($"Folio: {venta.FolioVenta}", fontBold, XBrushes.Black, 10, yPosition);
                            yPosition += 15;
                            gfx.DrawString($"Fecha: {venta.FechaVenta:dd/MM/yyyy HH:mm:ss}", font, XBrushes.Black, 10, yPosition);
                            yPosition += 15;
                            gfx.DrawString($"Cliente: Público General", font, XBrushes.Black, 10, yPosition);
                            yPosition += 15;
                            gfx.DrawString($"Atendido por: {venta.NombreUsuario}", font, XBrushes.Black, 10, yPosition);
                            yPosition += 25;

                            // Encabezados de los productos
                            gfx.DrawString("CANT           $ C/U.          IMPORTE", fontBold, XBrushes.Black, 10, yPosition);
                            yPosition += 15;
                            gfx.DrawString("-------------------------------------------------------------", font, XBrushes.Black, 10, yPosition);
                            yPosition += 15;

                            // Detalles de los productos
                            foreach (var detalle in detallesVenta)
                            {
                            // Renderizar la descripción como texto multilínea
                            var lineas = DividirTexto(detalle.DescripcionProducto, font, 200, gfx); // Aumenta el ancho disponible
                           

                            foreach (var linea in lineas)
                                {
                                    gfx.DrawString(linea, font, XBrushes.Black, 10, yPosition);
                                    yPosition += 15;
                                }

                                // Renderizar cantidad, precio unitario e importe
                                gfx.DrawString($"         {detalle.Cantidad}              {detalle.PrecioUnitario.ToString("C2")}               {detalle.Total.ToString("C2")}", font, XBrushes.Black, 10, yPosition);
                                yPosition += 15;
                            }

                            gfx.DrawString("-------------------------------------------------------------", font, XBrushes.Black, 10, yPosition);
                            yPosition += 15;

                            // Totales
                            gfx.DrawString($"Total: {venta.TotalVenta.ToString("C2")}", fontBold, XBrushes.Black, 10, yPosition);
                            yPosition += 15;
                            gfx.DrawString($"Pago Recibido: {venta.PagoRecibido.ToString("C2")}", font, XBrushes.Black, 10, yPosition);
                            yPosition += 15;
                            gfx.DrawString($"Cambio: {venta.Cambio.ToString("C2")}", font, XBrushes.Black, 10, yPosition);
                            yPosition += 25;

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

            private List<string> DividirTexto(string texto, XFont font, double maxWidth, XGraphics gfx)
            {
                List<string> lineas = new List<string>();
                string[] palabras = texto.Split(' ');
                StringBuilder lineaActual = new StringBuilder();

                foreach (var palabra in palabras)
                {
                    string prueba = (lineaActual.Length == 0 ? "" : lineaActual.ToString() + " ") + palabra;
                    double anchoTexto = gfx.MeasureString(prueba, font).Width;

                    if (anchoTexto <= maxWidth)
                    {
                        lineaActual.Append((lineaActual.Length == 0 ? "" : " ") + palabra);
                    }
                    else
                    {
                        lineas.Add(lineaActual.ToString());
                        lineaActual.Clear();
                        lineaActual.Append(palabra);
                    }
                }

                if (lineaActual.Length > 0)
                {
                    lineas.Add(lineaActual.ToString());
                }

                return lineas;
            }
        }
    }









