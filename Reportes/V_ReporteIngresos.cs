using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using POS_CHITOS.Usuarios;
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
    public partial class V_ReporteIngresos : Form
    {
        private readonly UsuarioService _usuarioService;
        private readonly EntradaEfectivoService _entradaEfectivoService;
        public V_ReporteIngresos()
        {
            InitializeComponent();
            var context = new POSContext(new DbContextOptions<POSContext>());
            _usuarioService = new UsuarioService(context);
            _entradaEfectivoService = new EntradaEfectivoService(context);

            // Cargar usuarios al inicializar
            CargarUsuarios();

            // Configurar límites de fechas
            DTP_Hasta.MaxDate = DateTime.Now;

            // Configuración de ventana
            StartPosition = FormStartPosition.CenterScreen;
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

        private void GenerarReporteIngresos(DateTime fechaDesde, DateTime fechaHasta, int idUsuario)
        {
            List<EntradaEfectivoDTO> ingresos;
            if (idUsuario == 0) // Todos los usuarios
            {
                ingresos = _entradaEfectivoService.ObtenerIngresosPorFecha(fechaDesde, fechaHasta);
            }
            else // Ingresos por usuario específico
            {
                ingresos = _entradaEfectivoService.ObtenerIngresosPorUsuarioYFecha(idUsuario, fechaDesde, fechaHasta);
            }

            GenerarReportePDF(ingresos);
        }

        private void GenerarReportePDF(List<EntradaEfectivoDTO> ingresos)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte de ingresos";
                saveFileDialog.FileName = $"Reporte_Ingresos_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Reporte de Ingresos";

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

                    // Encabezado
                    gfx.DrawRectangle(brushFondo, 0, 0, page.Width, 50);
                    gfx.DrawString("Reporte de Ingresos", fontTitulo, XBrushes.White, new XRect(0, 10, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += 35;
                    gfx.DrawString("Taller Automotriz Chito's", fontTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;

                    gfx.DrawString("Oscar Raul Rubio Rubio", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("Hidalgo 925, Palma Sola, 48740 El Grullo, Jal.", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("321 690 3502", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    // Rango de fechas
                    gfx.DrawString($"Rango de fechas: {DTP_Desde.Value.ToString("dddd, dd MMMM yyyy")} - {DTP_Hasta.Value.ToString("dddd, dd MMMM yyyy")}", fontSubTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    // Columnas
                    gfx.DrawString("Fecha", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, 100, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Usuario", fontNegrita, XBrushes.Black, new XRect(marginLeft + 100, currentY, 150, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Monto", fontNegrita, XBrushes.Black, new XRect(marginLeft + 250, currentY, 100, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Descripción", fontNegrita, XBrushes.Black, new XRect(marginLeft + 350, currentY, 200, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;

                    gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                    currentY += 5;

                    foreach (var ingreso in ingresos)
                    {
                        if (currentY + lineHeight > usableHeight)
                        {
                            CrearNuevaPagina();
                        }

                        gfx.DrawString(ingreso.Fecha.ToString("dd/MM/yyyy"), fontTexto, XBrushes.Black, new XRect(marginLeft, currentY, 100, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(ingreso.NombreUsuario, fontTexto, XBrushes.Black, new XRect(marginLeft + 100, currentY, 150, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(ingreso.Monto.ToString("C2"), fontTexto, XBrushes.Black, new XRect(marginLeft + 250, currentY, 100, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(ingreso.Concepto, fontTexto, XBrushes.Black, new XRect(marginLeft + 350, currentY, 200, lineHeight), XStringFormats.TopLeft);
                        currentY += lineHeight;
                    }

                    float totalIngresos = ingresos.Sum(i => i.Monto);
                    int totalIngresosCount = ingresos.Count;

                    gfx.DrawString($"Total de ingresos: {totalIngresosCount}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, 200, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString($"Total: {totalIngresos.ToString("C2")}", fontNegrita, XBrushes.Black, new XRect(marginLeft + 250, currentY, 100, lineHeight), XStringFormats.TopLeft);

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



        private void B_Guardar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = DTP_Desde.Value;
            DateTime fechaHasta = DTP_Hasta.Value;
            int idUsuarioSeleccionado = (int)CB_Usuarios.SelectedValue;

            GenerarReporteIngresos(fechaDesde, fechaHasta, idUsuarioSeleccionado);

        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
