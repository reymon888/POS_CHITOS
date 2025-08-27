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

namespace POS_CHITOS
{
    public partial class V_MenuCortesCaja : Form
    {
        private readonly int _idUsuario;
        private readonly POSContext _context;
        private readonly CortesService _corteService;
        private Usuario _usuarioActual;  // Usuario actual

        public V_MenuCortesCaja(int idUsuario, POSContext context)
        {
            InitializeComponent();

            _idUsuario = idUsuario;
            _context = context;
            _corteService = new CortesService(_context); // Instanciamos el servicio con el contexto
            _usuarioActual = _context.Set<Usuario>().Find(idUsuario);

            // Cargar los cortes de caja al iniciar
            CargarCortesCaja();

            DGV_Cortes.AllowUserToAddRows = false; // Deshabilitar la última fila de la tabla
            
        }

        private void configurarPermisos()
        {
           
          
        }

        private void B_RealizarCorte_Click(object sender, EventArgs e)
        {
            if (DGV_Cortes.SelectedRows.Count > 0)
            {
                // Obtener el IdCorte y EstadoCorte seleccionados
                int idCorte = Convert.ToInt32(DGV_Cortes.SelectedRows[0].Cells["IdCorte"].Value);
                string estadoCorte = DGV_Cortes.SelectedRows[0].Cells["EstadoCorte"].Value.ToString();

                // Validar si el corte ya está realizado
                if (estadoCorte == "Realizado")
                {
                    MessageBox.Show("El corte ya ha sido realizado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar si el corte pertenece al usuario actual
                var corte = _corteService.ObtenerCortePorId(idCorte); // Asume que tienes este método en CortesService
                if (corte.IdUsuario != _idUsuario)
                {
                    MessageBox.Show("No puedes realizar este corte porque no te pertenece.", "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar si está seguro de realizar el corte
                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea realizar el corte de caja?",
                    "Confirmar corte de caja",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion == DialogResult.No)
                {
                    return; // Detener el proceso si selecciona "No"
                }

                try
                {
                    // Generar el PDF del corte de caja automáticamente
                    GenerarReporteCorteCaja(idCorte);

                    // Finalizar el corte de caja
                    _corteService.FinalizarCorte(idCorte, _idUsuario);

                    // Recargar los cortes después de realizar uno
                    CargarCortesCaja();
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un corte para realizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCortesCaja()
        {
            // Obtener los cortes abiertos según el usuario
            var cortes = _corteService.ObtenerCortesCajaNoRealizados(_idUsuario);

            foreach (var corte in cortes)
            {
                Debug.WriteLine($"Corte ID: {corte.IdCorte}, Usuario: {corte.Usuario?.NombreUsuario ?? "Sin usuario"}");
            }

            if (cortes != null && cortes.Any())
            {
                // Transformar los datos para evitar problemas con propiedades de navegación
                var cortesTransformados = cortes.Select(c => new
                {
                    IdCorte = c.IdCorte,
                    Usuario = c.Usuario?.NombreUsuario ?? "Sin usuario",
                    Fecha = c.Fecha,
                    MontoInicio = c.MontoInicio,
                    EstadoCorte = c.EstadoCorte
                }).ToList();

                // Configurar el DataGridView con los datos transformados
                DGV_Cortes.DataSource = null;
                DGV_Cortes.AutoGenerateColumns = false;
                DGV_Cortes.Columns.Clear();

                // Crear las columnas personalizadas
                DGV_Cortes.Columns.Add(new DataGridViewTextBoxColumn { Name = "IdCorte", HeaderText = "ID Corte", DataPropertyName = "IdCorte", Width = 150 });
                DGV_Cortes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuario", DataPropertyName = "Usuario", Width = 200 });
                DGV_Cortes.Columns.Add(new DataGridViewTextBoxColumn { Name = "Fecha", HeaderText = "Fecha", DataPropertyName = "Fecha", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
                DGV_Cortes.Columns.Add(new DataGridViewTextBoxColumn { Name = "MontoInicio", HeaderText = "Monto Inicial", DataPropertyName = "MontoInicio", Width = 150, DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } });
                DGV_Cortes.Columns.Add(new DataGridViewTextBoxColumn { Name = "EstadoCorte", HeaderText = "Estado", DataPropertyName = "EstadoCorte", Width = 150 });

                // Asignar la lista de cortes transformados como DataSource
                DGV_Cortes.DataSource = cortesTransformados;
            }
            else
            {
                // Mostrar mensaje si no hay cortes abiertos
                DGV_Cortes.DataSource = null;
                MessageBox.Show("No se encontraron cortes de caja abiertos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Aplicar estilos de la tabla
            ConfigurarEstiloTablaCortes();
        }



        private void ConfigurarEstiloTablaCortes()
        {
            // Aplicar el mismo estilo de colores y formato que has estado utilizando
            DGV_Cortes.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            DGV_Cortes.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_Cortes.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_Cortes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_Cortes.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_Cortes.EnableHeadersVisualStyles = false;
            DGV_Cortes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_Cortes.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_Cortes.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_Cortes.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_Cortes.ClearSelection();

            // Poner el contenido de la tabla en medio
            DGV_Cortes.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Cortes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Cortes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_Cortes.RowHeadersVisible = false;
        }

        private void B_MostrarDetallesCorte_Click(object sender, EventArgs e)
        {
            // Validar si hay un corte seleccionado y abrir la ventana de detalles
            if (DGV_Cortes.SelectedRows.Count > 0)
            {
                int idCorte = Convert.ToInt32(DGV_Cortes.SelectedRows[0].Cells["IdCorte"].Value);
                //Crear un PDF con los detalles del corte
                GenerarReporteCorteCaja(idCorte);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un corte para ver los detalles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void GenerarReporteCorteCaja(int idCorte)
        {
            // Obtener el nombre del usuario que abrió el corte
            string nombreUsuario = _corteService.ObtenerNombreUsuarioPorCorte(idCorte);

            // Crear un SaveFileDialog para permitir al usuario seleccionar dónde guardar el archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar reporte de corte de caja";
                saveFileDialog.FileName = $"Corte_Caja_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                // Si el usuario selecciona una ubicación y hace clic en guardar
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Crear el documento PDF
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = "Reporte de Corte de Caja";
                    PdfPage page = pdf.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont fontTitulo = new XFont("Arial", 20, XFontStyleEx.Bold);
                    XFont fontTexto = new XFont("Arial", 12);
                    XFont fontNegrita = new XFont("Arial", 12, XFontStyleEx.Bold);
                    XFont fontSubTitulo = new XFont("Arial", 14, XFontStyleEx.Bold);

                    // Definir márgenes
                    int marginLeft = 40;
                    int marginTop = 40;
                    int lineHeight = 20;
                    int currentY = marginTop;

                    // Título del reporte
                    gfx.DrawRectangle(XBrushes.DarkBlue, 0, 0, page.Width, 50);
                    gfx.DrawString("Reporte de Corte de Caja", fontTitulo, XBrushes.White, new XRect(0, 10, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += 35;

                    // Nombre del taller
                    gfx.DrawString("Taller Automotriz Chito's", fontTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;

                    // Datos del taller
                    gfx.DrawString("Oscar Raul Rubio Rubio", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("Hidalgo 925, Palma Sola, 48740 El Grullo, Jal.", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight;
                    gfx.DrawString("321 690 3502", fontTexto, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    // Agregar el nombre del usuario que abrió el corte
                    gfx.DrawString($"Corte de caja realizado por: {nombreUsuario}", fontSubTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    // Sección de resumen del corte de caja
                    gfx.DrawString($"Monto Inicial: {_corteService.ObtenerMontoInicialCorte(idCorte).ToString("C2")}", fontSubTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

                    // Sección Entradas
                    gfx.DrawString("Entradas", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Entradas: {_corteService.ObtenerTotalEntradasRealizadas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Entradas (Canceladas): {_corteService.ObtenerTotalEntradasCanceladas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight * 2;

                    // Sección Salidas
                    gfx.DrawString("Salidas", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Salidas: {_corteService.ObtenerTotalSalidasRealizadas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Salidas (Canceladas): {_corteService.ObtenerTotalSalidasCanceladas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight * 2;

                    // Sección Compras
                    gfx.DrawString("Compras", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Compras: {_corteService.ObtenerTotalComprasRealizadas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Compras (Canceladas): {_corteService.ObtenerTotalComprasCanceladas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight * 2;

                    // Sección Ventas
                    gfx.DrawString("Ventas", fontNegrita, XBrushes.Black, new XRect(marginLeft, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Ventas: {_corteService.ObtenerTotalVentasRealizadas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight;
                    gfx.DrawString($"Total en Ventas (Canceladas): {_corteService.ObtenerTotalVentasCanceladas(idCorte).ToString("C2")}", fontTexto, XBrushes.Black, new XRect(marginLeft + 20, currentY, page.Width, lineHeight), XStringFormats.TopLeft);
                    currentY += lineHeight * 2;

                    // Monto final en caja
                    float totalVentas = _corteService.ObtenerTotalVentasRealizadas(idCorte) - _corteService.ObtenerTotalVentasCanceladas(idCorte);
                    float totalCompras = _corteService.ObtenerTotalComprasRealizadas(idCorte) - _corteService.ObtenerTotalComprasCanceladas(idCorte);
                    float totalEntradasEfectivo = _corteService.ObtenerTotalEntradasRealizadas(idCorte) - _corteService.ObtenerTotalEntradasCanceladas(idCorte);
                    float totalSalidasEfectivo = _corteService.ObtenerTotalSalidasRealizadas(idCorte) - _corteService.ObtenerTotalSalidasCanceladas(idCorte);
                    float montoInicial = _corteService.ObtenerMontoInicialCorte(idCorte);
                    float montoFinal = montoInicial + totalVentas + totalEntradasEfectivo - totalCompras - totalSalidasEfectivo;

                    gfx.DrawString($"Monto Final en Caja: {montoFinal.ToString("C2")}", fontSubTitulo, XBrushes.Black, new XRect(0, currentY, page.Width, lineHeight), XStringFormats.TopCenter);
                    currentY += lineHeight * 2;

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

        //Funcion para comando de botones
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.D))
            {
                B_MostrarDetallesCorte.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.F))
            {
                B_RealizarCorte.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Cortes.Focus();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}

