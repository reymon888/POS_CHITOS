using Microsoft.EntityFrameworkCore;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using POS_CHITOS.Inventario;
using POS_CHITOS.PI;
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
    public partial class V_ReporteInventario : Form
    {
        private readonly inventarioService _inventarioService;
        private readonly ProveedoresInventarioService _proveedoresInventarioService;
        public V_ReporteInventario()
        {
            InitializeComponent();

            var context = new POSContext(new DbContextOptions<POSContext>());
            _inventarioService = new inventarioService(context);
            _proveedoresInventarioService = new ProveedoresInventarioService(context);

            //Colocar ventana centrada
            StartPosition = FormStartPosition.CenterScreen;
            //No permitir redimensionar
            MaximizeBox = false;
            MinimizeBox = false;

            TB_Stock.Enabled = false;



            CargarCategorias();
            CargarProveedores();
        }
        private void CargarCategorias()
        {
            var categorias = _inventarioService.ObtenerCategorias();
            var listaCategorias = categorias.Select(c => new { Id = c.IdCategoria, Nombre = c.NombreCategoria }).ToList();

            // Agregar la opción "Todas las categorías"
            listaCategorias.Insert(0, new { Id = 0, Nombre = "Todas las categorías" });

            CB_Categorias.DataSource = listaCategorias;
            CB_Categorias.DisplayMember = "Nombre"; // Mostrar nombres
            CB_Categorias.ValueMember = "Id";      // Valor será el ID
        }

        private void CargarProveedores()
        {
            var proveedores = _proveedoresInventarioService.ObtenerProveedores();
            var listaProveedores = proveedores.Select(p => new { Id = p.idProveedor, Nombre = p.NombreProveedor }).ToList();

            // Agregar la opción "Todos los proveedores"
            listaProveedores.Insert(0, new { Id = 0, Nombre = "Todos los proveedores" });

            CB_Proveedores.DataSource = listaProveedores;
            CB_Proveedores.DisplayMember = "Nombre"; // Mostrar nombres
            CB_Proveedores.ValueMember = "Id";       // Valor será el ID
        }


        private void B_Guardar_Click(object sender, EventArgs e)
        {
            int? categoriaId = CB_Categorias.SelectedValue != null ? (int?)CB_Categorias.SelectedValue : null;
            int? proveedorId = CB_Proveedores.SelectedValue != null ? (int?)CB_Proveedores.SelectedValue : null;


            string stockFilter = string.Empty;
            int? stockCantidad = null;

            // Determinar el filtro de stock basado en los RadioButtons seleccionados
            if (RB_ConStock.Checked)
            {
                stockFilter = "ConStock";
            }
            else if (RB_SinStock.Checked)
            {
                stockFilter = "SinStock";
            }
            else if (RB_DebajoStock.Checked)
            {
                if (int.TryParse(TB_Stock.Text, out int cantidad))
                {
                    stockFilter = "DebajoStock";
                    stockCantidad = cantidad;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un valor numérico válido para el filtro de stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Obtener los productos filtrados
            var productosFiltrados = _inventarioService.ObtenerProductosFiltrados(categoriaId, proveedorId, stockFilter, stockCantidad);

            // Generar el PDF
            GenerarReportePDF(productosFiltrados);
        }

        private void GenerarReporteInventario(int? categoriaId, int? proveedorId, string stockFilter)
        {
            // Filtrar el inventario según los parámetros

            int cantidadStock;
            if (!int.TryParse(TB_Stock.Text, out cantidadStock))
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido para el stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var productos = _inventarioService.ObtenerProductosFiltrados(categoriaId, proveedorId, stockFilter, cantidadStock);

            // Llamar al método para generar el PDF con los productos filtrados
            GenerarReportePDF(productos);
        }

        private void GenerarReportePDF(List<InventarioDTO> productos)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte de inventario";
                saveFileDialog.FileName = $"Reporte_Inventario_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Reporte de Inventario";

                    PdfPage page = pdf.AddPage();
                    page.Size = PdfSharp.PageSize.Letter;
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont fontTitulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                    XFont fontTexto = new XFont("Arial", 12);
                    XFont fontEncabezado = new XFont("Arial", 12, XFontStyleEx.Bold);

                    int marginLeft = 40;
                    int marginTop = 40;
                    int lineHeight = 20;
                    int currentY = 0;

                    // Método para dibujar encabezado azul y datos de la empresa
                    void DibujarEncabezadoPrincipal()
                    {
                        // Dibujar encabezado azul
                        XSolidBrush azulBrush = new XSolidBrush(XColor.FromArgb(26, 77, 128));
                        gfx.DrawRectangle(azulBrush, 0, 0, page.Width, 50);
                        gfx.DrawString("Reporte de Inventario", fontTitulo, XBrushes.White, new XRect(0, 10, page.Width, lineHeight), XStringFormats.TopCenter);

                        currentY = 60;

                        // Información de la empresa
                        gfx.DrawString("Taller Automotriz Chito's", fontTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                        currentY += lineHeight;
                        gfx.DrawString("Oscar Raul Rubio Rubio", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                        currentY += lineHeight;
                        gfx.DrawString("Hidalgo 925, Palma Sola, 48740 El Grullo, Jal.", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                        currentY += lineHeight;
                        gfx.DrawString("321 690 3502", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                        currentY += lineHeight * 2;
                    }

                    // Método para dibujar encabezados de proveedor y categoría
                    void DibujarFiltrosSeleccionados()
                    {
                        string proveedorSeleccionado = CB_Proveedores.Text == "Todos los proveedores" ? "Todos los proveedores" : CB_Proveedores.Text;
                        string categoriaSeleccionada = CB_Categorias.Text == "Todas las categorías" ? "Todas las categorías" : CB_Categorias.Text;

                        gfx.DrawString($"Proveedor: {proveedorSeleccionado}", fontTexto, XBrushes.Black, new XRect(marginLeft, currentY, 300, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString($"Categoría: {categoriaSeleccionada}", fontTexto, XBrushes.Black, new XRect(page.Width - marginLeft - 300, currentY, 300, lineHeight), XStringFormats.TopRight);
                        currentY += lineHeight;
                    }

                    // Método para dibujar encabezados de tabla
                    void DibujarEncabezadosTabla()
                    {
                        gfx.DrawString("Categoría", fontEncabezado, XBrushes.Black, new XRect(marginLeft, currentY, 100, lineHeight), XStringFormats.TopCenter);
                        gfx.DrawString("Código Producto", fontEncabezado, XBrushes.Black, new XRect(marginLeft + 140, currentY, 100, lineHeight), XStringFormats.TopCenter);
                        gfx.DrawString("Descripción", fontEncabezado, XBrushes.Black, new XRect(marginLeft + 240, currentY, 200, lineHeight), XStringFormats.TopCenter);
                        gfx.DrawString("Stock", fontEncabezado, XBrushes.Black, new XRect(marginLeft + 440, currentY, 100, lineHeight), XStringFormats.TopCenter);

                        currentY += lineHeight;
                        gfx.DrawLine(XPens.Black, marginLeft, currentY, page.Width - marginLeft, currentY);
                        currentY += 5;
                    }

                    // Método para crear nueva página
                    void CrearNuevaPagina()
                    {
                        page = pdf.AddPage();
                        page.Size = PdfSharp.PageSize.Letter;
                        gfx = XGraphics.FromPdfPage(page);
                        currentY = 0;

                        DibujarEncabezadoPrincipal();
                        DibujarFiltrosSeleccionados();
                        DibujarEncabezadosTabla();
                    }

                    // Dibujar encabezado principal y filtros
                    DibujarEncabezadoPrincipal();
                    DibujarFiltrosSeleccionados();
                    DibujarEncabezadosTabla();

                    string TruncarTexto(string texto, int maxLength)
                    {
                        if (string.IsNullOrEmpty(texto))
                            return "Sin Información";

                        return texto.Length > maxLength ? texto.Substring(0, maxLength) + "..." : texto;
                    }

                    foreach (var producto in productos)
                    {
                        if (currentY + lineHeight > page.Height - marginTop)
                        {
                            CrearNuevaPagina();
                        }

                        string nombreCategoria = TruncarTexto(producto.NombreCategoria, 20);
                        string codigoProducto = TruncarTexto(producto.CodigoProducto, 15);
                        string descripcionProducto = TruncarTexto(producto.DescripcionProducto, 30);
                        string stock = producto.Stock.ToString();

                        gfx.DrawString(nombreCategoria, fontTexto, XBrushes.Black, new XRect(marginLeft, currentY, 150, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(codigoProducto, fontTexto, XBrushes.Black, new XRect(marginLeft + 150, currentY, 120, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(descripcionProducto, fontTexto, XBrushes.Black, new XRect(marginLeft + 270, currentY, 200, lineHeight), XStringFormats.TopLeft);
                        gfx.DrawString(stock, fontTexto, XBrushes.Black, new XRect(marginLeft + 475, currentY, 100, lineHeight), XStringFormats.TopLeft);

                        currentY += lineHeight;
                    }

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



        private void RB_DebajoStock_CheckedChanged(object sender, EventArgs e)
        {
            TB_Stock.Enabled = RB_DebajoStock.Checked;
            if (!RB_DebajoStock.Checked)
            {
                TB_Stock.Text = string.Empty; // Limpiar el campo si se desactiva
            }
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
