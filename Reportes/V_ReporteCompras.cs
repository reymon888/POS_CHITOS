using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using POS_CHITOS.Compras;
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
    public partial class V_ReporteCompras : Form
    {
        private readonly ComprasService _comprasService;
        
       

        public V_ReporteCompras()
        {
            InitializeComponent();

            var context = new POSContext(new DbContextOptions<POSContext>()); // Inicializar el contexto aquí
            _comprasService = new ComprasService(context); // Crear una instancia del servicio
            CargarUsuarios();
            CargarProveedores();

            //Centrar la ventana
            StartPosition = FormStartPosition.CenterScreen;
            //No cambiar tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        private void CargarUsuarios()
        {
            //cargar los usuarios de tipo cajero
            var usuarios = _comprasService.ObtenerUsuarios();
            var listaUsuarios = usuarios.Where(u => u.Rol == "Cajero").Select(u => new { u.Id, u.NombreUsuario }).ToList();
            listaUsuarios.Insert(0, new { Id = 0, NombreUsuario = "Todos los usuarios" });

            CB_Usuarios.DataSource = listaUsuarios;
            CB_Usuarios.DisplayMember = "NombreUsuario";
            CB_Usuarios.ValueMember = "Id";
        }

        private void CargarProveedores()
        {
            //Cargar proveedores al combobox y una opcion para obtenerlos a todos para el reporte
            var proveedores = _comprasService.ObtenerProveedores();
            var listaProveedores = proveedores.Select(p => new { p.idProveedor, p.NombreProveedor }).ToList();
            listaProveedores.Insert(0, new { idProveedor = 0, NombreProveedor = "Todos los proveedores" });
            CB_Proveedores.DataSource = listaProveedores;
            CB_Proveedores.DisplayMember = "NombreProveedor";
            CB_Proveedores.ValueMember = "IdProveedor";



        }
        private void B_Guardar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = DTP_Desde.Value;
            DateTime fechaHasta = DTP_Hasta.Value;
            int? idUsuario = CB_Usuarios.SelectedValue as int? > 0 ? (int?)CB_Usuarios.SelectedValue : null;
            int? idProveedor = CB_Proveedores.SelectedValue as int? > 0 ? (int?)CB_Proveedores.SelectedValue : null;
            bool incluirDetalles = check_detallescompras.Checked;
            bool incluirCanceladas = check_comprascanceladas.Checked;

            // Obtener las compras basadas en los filtros seleccionados
            var compras = _comprasService.ListarComprasPorFiltro(fechaDesde, fechaHasta, idUsuario, idProveedor, incluirCanceladas);

            // Generar el reporte de PDF
            GenerarReporteComprasPDF(compras, incluirDetalles);
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerarReporteComprasPDF(List<CompraDTO> compras, bool incluirDetalles)
        {
            // Crear un SaveFileDialog para permitir al usuario seleccionar dónde guardar el archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte de compras";
                saveFileDialog.FileName = $"Reporte_Compras_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                // Si el usuario selecciona una ubicación y hace clic en guardar
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Ordenar las compras por fecha descendente
                    compras = compras.OrderByDescending(c => c.FechaCompra).ToList();

                    // Crear el documento PDF
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Reporte de Compras";

                    // Crear una primera página en tamaño carta (8.5 x 11 pulgadas)
                    PdfPage page = pdf.AddPage();
                    page.Size = PdfSharp.PageSize.Letter;
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont fontTitulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                    XFont fontTexto = new XFont("Arial", 12);
                    XFont fontNegrita = new XFont("Arial", 12, XFontStyleEx.Bold);
                    XFont fontSubTitulo = new XFont("Arial", 14, XFontStyleEx.Bold);

                    // Definir colores
                    XSolidBrush brushTitulo = new XSolidBrush(XColor.FromArgb(51, 51, 51));
                    XSolidBrush brushFondo = new XSolidBrush(XColor.FromArgb(26, 77, 128));

                    // Definir márgenes y límites de la página
                    int marginLeft = 40;
                    int marginTop = 40;
                    int lineHeight = 20;
                    int currentY = marginTop;
                    int pageHeight = (int)page.Height;
                    int usableHeight = pageHeight - marginTop * 2;  // Área útil de la página

                    // Función para crear una nueva página
                    void CrearNuevaPagina()
                    {
                        page = pdf.AddPage();
                        page.Size = PdfSharp.PageSize.Letter;
                        gfx = XGraphics.FromPdfPage(page);
                        currentY = marginTop; // Restablecer el Y actual en la nueva página
                    }

                    // Información del taller centrada
                    gfx.DrawRectangle(brushFondo, 0, 0, page.Width, 50);
                    gfx.DrawString("Reporte de Compras", fontTitulo, XBrushes.White, new XRect(0, 10, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += 35; // Ajustar el espacio después del título

                    // Nombre del taller
                    gfx.DrawString("Taller Automotriz Chito's", fontTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;

                    // Datos del taller
                    gfx.DrawString("Oscar Raul Rubio Rubio", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("Hidalgo 925, Palma Sola, 48740 El Grullo, Jal.", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("321 690 3502", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2; // Espacio adicional después de los datos del taller

                    // Fechas del reporte centradas
                    gfx.DrawString($"Rango de fechas: {DTP_Desde.Value.ToString("dd/MM/yyyy")} - {DTP_Hasta.Value.ToString("dd/MM/yyyy")}",
                        fontSubTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    // Cabecera de tabla
                    gfx.DrawString("Folio", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, 50, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Fecha", fontNegrita, XBrushes.Black, new XRect(marginLeft + 60, currentY, 150, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Proveedor", fontNegrita, XBrushes.Black, new XRect(marginLeft + 220, currentY, 150, lineHeight), XStringFormats.TopLeft);
                    gfx.DrawString("Total", fontNegrita, XBrushes.Black, new XRect(marginLeft + 380, currentY, 100, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;

                    // Dibujar línea separadora de encabezado
                    gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                    currentY += 5; // Espacio después de la línea

                    foreach (var compra in compras)
                    {
                        // Verificar si es necesario crear una nueva página antes de agregar más contenido
                        if (currentY + lineHeight * 2 > usableHeight)
                        {
                            CrearNuevaPagina(); // Crear nueva página si no hay espacio suficiente
                        }

                        // Dibujar cada compra
                        gfx.DrawString(compra.idCompra.ToString(), fontTexto, XBrushes.Black, new XRect(marginLeft, currentY, 50, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(compra.FechaCompra.ToString("dd/MM/yyyy"), fontTexto, XBrushes.Black, new XRect(marginLeft + 60, currentY, 150, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(compra.NombreProveedor, fontTexto, XBrushes.Black, new XRect(marginLeft + 220, currentY, 150, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(compra.TotalCompra.ToString("C2"), fontTexto, XBrushes.Black, new XRect(marginLeft + 380, currentY, 100, lineHeight), XStringFormats.TopLeft);
                        currentY += lineHeight;

                        // Si el usuario quiere ver los detalles
                        if (incluirDetalles)
                        {
                            // Obtener los detalles de la compra desde el servicio
                            var detallesCompra = _comprasService.ObtenerDetallesCompra(compra.idCompra);

                            foreach (var detalle in detallesCompra)
                            {
                                string productoTexto = $" - {detalle.DescripcionProducto}: {detalle.Cantidad} x {detalle.PrecioUnitario.ToString("C2")} = {detalle.Total.ToString("C2")}";
                                XSize size = gfx.MeasureString(productoTexto, fontTexto);

                                // Verificar si el detalle excede el área útil antes de agregarlo
                                if (currentY + lineHeight > usableHeight)
                                {
                                    CrearNuevaPagina(); // Crear nueva página si no hay espacio suficiente
                                }

                                // Dibujar el detalle
                                gfx.DrawString(productoTexto, fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                                currentY += lineHeight;
                            }
                        }

                        // Dibujar línea separadora entre compras
                        gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                        currentY += 5;
                    }

                    //Mostrar el total de compras y el total de todas las compras canceladas y realizadas y la respectiva cantidad
                    var totalCompras = compras.Count;
                    var totalComprasCanceladas = compras.Count(c => c.Estado == "Cancelada");
                    var totalComprasRealizadas = compras.Count(c => c.Estado == "Realizada");

                    gfx.DrawString($"Total de compras: {totalCompras}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total de compras canceladas: {totalComprasCanceladas}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total de compras realizadas: {totalComprasRealizadas}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;

                    //Mostrar la cantidad de dinero total de todas las compras realizadas menos las canceladas
                    var totalDineroComprasRealizadas = compras.Where(c => c.Estado == "Realizada").Sum(c => c.TotalCompra);
                    var totalDineroComprasCanceladas = compras.Where(c => c.Estado == "Cancelada").Sum(c => c.TotalCompra);

                    gfx.DrawString($"Total de dinero en compras realizadas: {totalDineroComprasRealizadas.ToString("C2")}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total de dinero en compras canceladas: {totalDineroComprasCanceladas.ToString("C2")}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;

                    //Total de la resta de las compras realizadas menos las canceladas 
                    var totalDineroNeto = totalDineroComprasRealizadas - totalDineroComprasCanceladas;
                    gfx.DrawString($"Total de dinero neto: {totalDineroNeto.ToString("C2")}", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width - marginLeft * 2, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;





                    // Guardar el documento en la ubicación seleccionada
                    pdf.Save(filePath);

                    // Intentar abrir el archivo PDF automáticamente
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


    }
}
