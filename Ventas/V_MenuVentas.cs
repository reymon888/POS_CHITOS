using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Usuarios;
using POS_CHITOS.Utils;
using POS_CHITOS.Ventas;
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
    public partial class V_MenuVentas : Form
    {
        private readonly VentasService ventasService;
        private List<VentaDTO> _ventas;  // Lista de ventas completa
        private Usuario _usuarioActual;  // Usuario actual
        private readonly BindingSource _bsVentas = new();
        private Control _lista => DGV_Ventas;
        private bool _mostrandoEnEspera = false;
        private bool _mostrandoHistorialPlaca = false;
        private Control? _vistaActual;
        public V_MenuVentas(int idusuario, POSContext context)
        {
            InitializeComponent();
            ventasService = new VentasService(context);
            _usuarioActual = context.Usuarios.Find(idusuario);


            ConfigurarGridVentas();
            CargarVentas();

            // Suscribir eventos de filtros
            TB_BuscarVenta.TextChanged += TB_BuscarVenta_TextChanged;
            ConfigurarPermisos();
            InicializarVista(); // <- importante

        }
        private void InicializarVista()
        {
            // Garantiza que la lista viva dentro del host desde el inicio
            if (_lista.Parent != panelHost)
            {
                _lista.Parent = panelHost;
                _lista.Dock = DockStyle.Fill;
            }
            MostrarLista(); // pinta la grilla en el host
        }
        private void MostrarLista()
        {
            panelHost.SuspendLayout();
            panelHost.Controls.Clear();

            _lista.Visible = true;
            _lista.Dock = DockStyle.Fill;
            if (_lista.Parent != panelHost) _lista.Parent = panelHost;

            panelHost.Controls.Add(_lista);
            _vistaActual = null;

            if (panelBotonera != null) panelBotonera.Visible = true;

            panelHost.Visible = true;
            panelHost.BringToFront();
            panelHost.ResumeLayout();
        }
        private void VerificarPermisosVentaSeleccionada()
        {
            // Asegurarse de que _ventas está inicializado
            if (_ventas == null)
            {
                _ventas = ventasService.ObtenerVentas();
            }

            B_ModificarVenta.Enabled = false;
            B_CancelarVenta.Enabled = false;

            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                var filaSeleccionada = DGV_Ventas.SelectedRows[0];
                if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                    int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                {
                    // Obtener la venta seleccionada y verificar el estado del corte
                    var ventaSeleccionada = _ventas.FirstOrDefault(v => v.FolioVenta == folioVenta);
                    // dentro de VerificarPermisosVentaSeleccionada
                    if (ventaSeleccionada != null)
                    {
                        bool editable = ventaSeleccionada.Estado == "EnEspera"
                                        || ventaSeleccionada.EstadoCorte != "Realizado";

                        B_ModificarVenta.Enabled = editable;
                        B_CancelarVenta.Enabled = editable;  // si así lo quieres
                    }

                }
            }
        }



        public void CargarVentas(List<VentaDTO> ventasFiltradas = null)
        {
            var ventas = ventasFiltradas ?? ventasService.ObtenerVentas();

            if (_usuarioActual.Rol == "Cajero")
                ventas = ventas.Where(v => v.NombreUsuario == _usuarioActual.NombreUsuario).ToList();

            _ventas = ventas;                 // guarda cache
            _bsVentas.DataSource = ventas;    // pinta en grid

            // Toast suave para feedback (si tienes Toast util)
            Toast.Show(this, "Ventas cargadas.", ToastType.Info, 1600, ToastPosition.TopRight);


        }

        private void B_MostrarDetalles_Click(object sender, EventArgs e)
        {
            if (DGV_Ventas.SelectedRows.Count == 0) { CustomMessageBox.Show("Selecciona una venta.", "Aviso"); return; }

            var row = DGV_Ventas.SelectedRows[0];
            if (row.Cells["FolioVenta"].Value == null || !int.TryParse(row.Cells["FolioVenta"].Value.ToString(), out int folio))
            { CustomMessageBox.Show("Folio inválido.", "Error"); return; }

            var form = new V_MostrarDetallesVenta(folio, onClose: refrescar => CloseEmbeddedView(refrescar));
            ShowFormInPanel(form);
        }

        private void B_ModificarVenta_Click(object sender, EventArgs e)
        {
            VerificarPermisosVentaSeleccionada();
            if (!B_ModificarVenta.Enabled)
            {
                CustomMessageBox.Show("No se puede modificar esta venta ya que el corte está realizado.", "Acción no permitida");
                return;
            }
            if (DGV_Ventas.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Selecciona una venta.", "Aviso");
                return;
            }

            var row = DGV_Ventas.SelectedRows[0];
            if (row.Cells["FolioVenta"].Value == null || !int.TryParse(row.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
            {
                CustomMessageBox.Show("Folio inválido.", "Error");
                return;
            }

            // === Embebido ===
            var ctx = new POSContext(new DbContextOptions<POSContext>());
            var form = new V_ModificarVenta(
                folioVenta,
                _usuarioActual.Id,
                ctx,
                onClose: refrescar => CloseEmbeddedView(refrescar)   // <- vuelve al listado y refresca si procede
            );

            ShowFormInPanel(form);
        }

        private void TB_BuscarVenta_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            // Si está en modo historial de placa, no aplicar filtros
            if (_mostrandoHistorialPlaca)
                return;

            var f = (TB_BuscarVenta.Text ?? "").Trim();

            // Si el campo está vacío, recargar según el estado actual
            if (string.IsNullOrEmpty(f))
            {
                if (_mostrandoEnEspera)
                {
                    _ventas = ventasService.ObtenerVentasEnEspera();
                }
                else
                {
                    _ventas = ventasService.ObtenerVentas();
                }
                ActualizarGridSilencioso(_ventas);
                return;
            }

            // *** Detectar si es un número (folio) ***
            if (int.TryParse(f, out int folio) || f.All(char.IsDigit))
            {
                // Buscar primero en las ventas actuales
                var ventasEnCache = _ventas?.Where(v => v.FolioVenta.ToString().Contains(f)).ToList();

                if (ventasEnCache != null && ventasEnCache.Any())
                {
                    // Si encuentra en cache, mostrarlas
                    ActualizarGridSilencioso(ventasEnCache);
                    return;
                }

                // Si no está en cache, buscar en historial completo
                var ventasHistorial = ventasService.BuscarVentasPorFolioHistorial(f);

                if (ventasHistorial.Any())
                {
                    ActualizarGridSilencioso(ventasHistorial);
                    return;
                }
                else
                {
                    // No se encontró nada
                    ActualizarGridSilencioso(new List<VentaDTO>());
                    return;
                }
            }

            // *** Búsqueda normal por texto (nombre, placa, etc.) ***
            var fLower = f.ToLowerInvariant();

            if (_ventas == null)
                _ventas = _mostrandoEnEspera ? ventasService.ObtenerVentasEnEspera() : ventasService.ObtenerVentas();

            var ventasFiltradas = _ventas.Where(v =>
                v.FolioVenta.ToString().Contains(f) ||
                (!string.IsNullOrEmpty(v.NombreUsuario) && v.NombreUsuario.ToLower().Contains(fLower)) ||
                (!string.IsNullOrEmpty(v.Usuario) && v.Usuario.ToLower().Contains(fLower)) ||
                (!string.IsNullOrEmpty(v.PlacaCarro) && v.PlacaCarro.ToLower().Contains(fLower))
            ).ToList();

            ActualizarGridSilencioso(ventasFiltradas);
        }

        // 2. AGREGAR este nuevo método después de AplicarFiltros():
        private void ActualizarGridSilencioso(List<VentaDTO> ventas)
        {
            if (_usuarioActual.Rol == "Cajero")
                ventas = ventas.Where(v => v.NombreUsuario == _usuarioActual.NombreUsuario).ToList();

            _ventas = ventas;
            _bsVentas.DataSource = null;
            _bsVentas.DataSource = ventas;
            _bsVentas.ResetBindings(false);
        }



        private void B_BuscarPorFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = DTP_Desde.Value.Date;
            DateTime hasta = DTP_Hasta.Value.Date;

            // Obtener ventas filtradas por fechas
            var ventasFiltradas = ventasService.ObtenerVentasPorFecha(desde, hasta);

            // Cargar ventas filtradas en el DataGridView
            CargarVentas(ventasFiltradas);
        }

        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarVentas();
        }

        // Método para configurar los permisos según el rol del usuario
        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarVenta.Enabled = false;
                B_CancelarVenta.Enabled = false;

                B_ModificarVenta.Visible = false;
                B_CancelarVenta.Visible = false;

                DTP_Desde.Enabled = false;
                DTP_Hasta.Enabled = false;

                B_BuscarPorFecha.Enabled = false;

                DTP_Desde.Visible = false;
                DTP_Hasta.Visible = false;

                B_BuscarPorFecha.Visible = false;

                label1.Visible = false;
                label2.Visible = false;


            }
        }

        private void B_CancelarVenta_Click(object sender, EventArgs e)
        {
            VerificarPermisosVentaSeleccionada();

            // Si el botón está habilitado, procede a cambiar el estado de la venta
            if (B_CancelarVenta.Enabled)
            {
                // Código para cambiar el estado de la venta
                if (DGV_Ventas.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];
                    if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                    {
                        string estadoActual = filaSeleccionada.Cells["Estado"].Value.ToString();
                        string nuevoEstado = estadoActual == "Realizada" ? "Cancelada" : "Realizada";

                        DialogResult result = CustomMessageBox.Show($"¿Está seguro que desea cambiar el estado de la venta a {nuevoEstado}?",
                            "Confirmar cambio de estado");

                        if (result == DialogResult.Yes)
                        {
                            ventasService.CambiarEstadoVenta(folioVenta, nuevoEstado);
                            CargarVentas();
                            CustomMessageBox.Show($"El estado de la venta fue cambiado a {nuevoEstado}.", "Estado actualizado");
                        }
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede cancelar esta venta ya que el corte está realizado.", "Acción no permitida");
                B_ModificarVenta.Enabled = true;
                B_CancelarVenta.Enabled = true;
            }
        }

        private void B_Ticket_Click(object sender, EventArgs e)
        {
            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                var filaSeleccionada = DGV_Ventas.SelectedRows[0];

                if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                    int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                {
                    try
                    {
                        // Obtener los detalles de la venta seleccionada
                        var ventaSeleccionada = ventasService.ObtenerVentaPorFolio(folioVenta);
                        var detallesVenta = ventasService.ObtenerDetallesVentaPorFolio(folioVenta);

                        if (ventaSeleccionada != null && detallesVenta != null && detallesVenta.Count > 0)
                        {
                            // Generar el ticket
                            TicketGenerator ticketGenerator = new TicketGenerator();
                            ticketGenerator.GenerarTicketPDF(ventaSeleccionada, detallesVenta);

                            MessageBox.Show("El ticket ha sido generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron detalles para esta venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una venta válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una venta para reimprimir el ticket.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Metodo de atajos para los botones que no sea keydown y sea con control al incio
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.K))
            {
                B_Ticket.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarVenta.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_ModificarVenta.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                B_MostrarDetalles.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Ventas.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarVenta.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ConfigurarGridVentas()
        {
            DGV_Ventas.AutoGenerateColumns = false;
            DGV_Ventas.MultiSelect = false;
            DGV_Ventas.RowHeadersVisible = false;
            DGV_Ventas.AllowUserToAddRows = false;
            DGV_Ventas.AllowUserToResizeRows = false;
            DGV_Ventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Ventas.AllowUserToResizeColumns = true;
            DGV_Ventas.Columns.Clear();

            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FolioVenta",
                HeaderText = "Folio",
                DataPropertyName = "FolioVenta",
                FillWeight = 10,
                MinimumWidth = 90
            });

            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaVenta",
                HeaderText = "Fecha",
                DataPropertyName = "FechaVenta",
                FillWeight = 16,
                DefaultCellStyle = { Format = "g" } // fecha+hora corta
            });

            // <-- NUEVA COLUMNA Placa
            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "PlacaCarro",
                HeaderText = "Placa",
                DataPropertyName = "PlacaCarro",
                FillWeight = 14,
                MinimumWidth = 110
            });

            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreUsuario",
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario",
                FillWeight = 18,
                MinimumWidth = 140
            });

            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalVenta",
                HeaderText = "Total",
                DataPropertyName = "TotalVenta",
                FillWeight = 14,
                DefaultCellStyle = { Format = "C2" }
            });

            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MetodoPago",
                HeaderText = "Metodo de Pago",
                DataPropertyName = "MetodoPago",
                FillWeight = 14,
                DefaultCellStyle = { Format = "C2" }
            });

            DGV_Ventas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                FillWeight = 12
            });

            // Tema como en clientes (usa tus extensiones)
            DGV_Ventas.ApplyTheme(compacto: true);
            DGV_Ventas.Center("FolioVenta", "Estado", "PlacaCarro");
            DGV_Ventas.FormatCurrency("TotalVenta");
            DGV_Ventas.PillByValue("Estado", good: "Realizada", bad: "Cancelada");

            // Mostrar placa en MAYÚSCULAS de forma visual
            DGV_Ventas.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                if (DGV_Ventas.Columns[e.ColumnIndex].DataPropertyName == "PlacaCarro"
                    && e.Value is string p && !string.IsNullOrWhiteSpace(p))
                    e.Value = p.ToUpperInvariant();

                if (e.RowIndex < 0) return;
                var col = DGV_Ventas.Columns[e.ColumnIndex];
                if (col.DataPropertyName != "Estado") return;

                var val = e.Value as string;
                var cell = DGV_Ventas.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (val == "Realizada")
                {
                    cell.Style.BackColor = Color.FromArgb(220, 247, 230);
                    cell.Style.ForeColor = Color.FromArgb(22, 115, 71);
                }
                else if (val == "Cancelada")
                {
                    cell.Style.BackColor = Color.FromArgb(253, 229, 222);
                    cell.Style.ForeColor = Color.FromArgb(160, 29, 19);
                }
                else if (val == "EnEspera")
                {
                    cell.Style.BackColor = Color.FromArgb(255, 248, 220); // ámbar suave
                    cell.Style.ForeColor = Color.FromArgb(142, 90, 0);
                }
            };

            // Enlaza el BS
            DGV_Ventas.DataSource = _bsVentas;
        }

        private void ShowFormInPanel(Form f)
        {
            panelHost.SuspendLayout();

            // Esconde el listado (NO el host)
            _lista.Visible = false;
            if (panelBotonera != null) panelBotonera.Visible = false;

            // Limpia vista anterior
            if (_vistaActual != null)
            {
                panelHost.Controls.Remove(_vistaActual);
                _vistaActual.Dispose();
                _vistaActual = null;
            }

            // Embebe el form
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelHost.Controls.Clear();     // saca la grilla del host
            panelHost.Controls.Add(f);      // mete el hijo
            _vistaActual = f;

            // fallback por si cierran con la X
            f.FormClosed -= Child_FormClosedRestore;
            f.FormClosed += Child_FormClosedRestore;

            panelHost.Visible = true;       // host siempre visible
            panelHost.BringToFront();

            panelHost.ResumeLayout();
            f.Show();
        }


        private void Child_FormClosedRestore(object? sender, FormClosedEventArgs e)
        {
            // si el hijo se cerró con la X, regresa al listado y refresca
            CloseEmbeddedView(refrescar: true);
        }

        private void CloseEmbeddedView(bool refrescar)
        {
            if (_vistaActual != null)
            {
                if (_vistaActual is Form f)
                    f.FormClosed -= Child_FormClosedRestore;

                panelHost.Controls.Remove(_vistaActual);
                _vistaActual.Dispose();
                _vistaActual = null;
            }

            MostrarLista();

            if (refrescar)
            {
                // Respetar el filtro actual al refrescar
                if (_mostrandoEnEspera)
                {
                    var ventasEnEspera = ventasService.ObtenerVentasEnEspera();
                    CargarVentas(ventasEnEspera);
                }
                else
                {
                    CargarVentas();
                }
                Toast.Show(this, "Ventas actualizadas.", ToastType.Success, 1600, ToastPosition.BottomRight);
            }
        }

        private void B_VentaEspera_Click(object sender, EventArgs e)
        {
            if (_mostrandoEnEspera)
            {
                // Si ya está mostrando en espera, regresar a la vista normal (del día)
                _mostrandoEnEspera = false;
                B_VentaEspera.Text = "Ventas en Espera"; // Cambiar texto del botón
                CargarVentas(); // Cargar ventas normales del día
                Toast.Show(this, "Mostrando ventas del día.", ToastType.Info, 1600, ToastPosition.TopRight);
            }
            else
            {
                // Mostrar solo ventas en espera (de todos los días)
                _mostrandoEnEspera = true;
                B_VentaEspera.Text = "Ver Todas"; // Cambiar texto del botón
                var ventasEnEspera = ventasService.ObtenerVentasEnEspera();
                CargarVentas(ventasEnEspera);
                Toast.Show(this, $"Mostrando {ventasEnEspera.Count} ventas en espera.", ToastType.Info, 1600, ToastPosition.TopRight);
            }
        }

        private void B_BuscarPlaca_Click(object sender, EventArgs e)
        {
            // Si ya está en modo historial, salir
            if (_mostrandoHistorialPlaca)
            {
                SalirDeModoHistorial();
                return;
            }

            // Crear un Form simple para pedir la placa
            using (var formPlaca = new Form())
            {
                formPlaca.Text = "Buscar Historial por Placa";
                formPlaca.Size = new Size(400, 180);
                formPlaca.StartPosition = FormStartPosition.CenterParent;
                formPlaca.FormBorderStyle = FormBorderStyle.FixedDialog;
                formPlaca.MaximizeBox = false;
                formPlaca.MinimizeBox = false;

                var lblMensaje = new Label
                {
                    Text = "Ingresa la placa del vehículo:",
                    Location = new Point(20, 20),
                    Size = new Size(350, 30),
                    Font = new Font("Segoe UI", 12)
                };

                var txtPlaca = new TextBox
                {
                    Location = new Point(20, 55),
                    Size = new Size(340, 30),
                    Font = new Font("Segoe UI", 12),
                    CharacterCasing = CharacterCasing.Upper,
                    Text = TB_BuscarVenta.Text.Trim()
                };

                var btnBuscar = new Button
                {
                    Text = "Buscar",
                    Location = new Point(180, 100),
                    Size = new Size(100, 35),
                    DialogResult = DialogResult.OK,
                    Font = new Font("Segoe UI", 10)
                };

                var btnCancelar = new Button
                {
                    Text = "Cancelar",
                    Location = new Point(290, 100),
                    Size = new Size(100, 35),
                    DialogResult = DialogResult.Cancel,
                    Font = new Font("Segoe UI", 10)
                };

                formPlaca.Controls.AddRange(new Control[] { lblMensaje, txtPlaca, btnBuscar, btnCancelar });
                formPlaca.AcceptButton = btnBuscar;
                formPlaca.CancelButton = btnCancelar;

                txtPlaca.Focus();
                txtPlaca.SelectAll();

                // Evento Enter en el TextBox
                txtPlaca.KeyDown += (s, ev) =>
                {
                    if (ev.KeyCode == Keys.Enter)
                    {
                        btnBuscar.PerformClick();
                        ev.Handled = true;
                    }
                };

                if (formPlaca.ShowDialog() != DialogResult.OK)
                    return;

                string placa = txtPlaca.Text.Trim();

                if (string.IsNullOrWhiteSpace(placa))
                {
                    CustomMessageBox.Show("Debes ingresar una placa.", "Campo vacío");
                    return;
                }

                // Buscar en el historial
                var ventasPorPlaca = ventasService.ObtenerVentasPorPlaca(placa);

                if (ventasPorPlaca.Count == 0)
                {
                    CustomMessageBox.Show($"No se encontraron ventas para: {placa}", "Sin resultados");
                    return;
                }

                // Activar modo historial
                _mostrandoHistorialPlaca = true;
                _mostrandoEnEspera = false;

                B_VentaEspera.Text = "Ventas en Espera";
                B_BuscarPlaca.Text = "Salir de Historial";
                TB_BuscarVenta.Text = placa;

                CargarVentas(ventasPorPlaca);
                Toast.Show(this, $"Historial: {ventasPorPlaca.Count} ventas de {placa}",
                           ToastType.Success, 2500, ToastPosition.TopRight);
            }
        }
        private void SalirDeModoHistorial()
        {
            _mostrandoHistorialPlaca = false;
            B_BuscarPlaca.Text = "Buscar por Placa";
            TB_BuscarVenta.Clear();
            CargarVentas();
            Toast.Show(this, "Regresando a ventas del día.", ToastType.Info, 1600, ToastPosition.TopRight);
        }
    }
    }



