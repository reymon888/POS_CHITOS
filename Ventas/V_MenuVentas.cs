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
            if (DGV_Ventas.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];

                    if (filaSeleccionada.Cells["FolioVenta"].Value != null && int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int FolioVenta))
                    {
                        if (FolioVenta > 0)
                        {
                            // Crear el formulario de modificación de compra
                            V_MostrarDetallesVenta MostrarDetallesVentaForm = new V_MostrarDetallesVenta(FolioVenta);

                            // Mostrar el formulario y verificar si se cerró con éxito (DialogResult.OK)
                            if (MostrarDetallesVentaForm.ShowDialog() == DialogResult.OK)
                            {
                                // Recargar la tabla de compras solo si la modificación fue exitosa
                                CargarVentas();
                            }

                        }
                        else // Si el ID de la compra no es válido
                        {
                            CustomMessageBox.Show("El folio de la venta no es válido.", "Error");
                        }

                    }
                    else // Si el ID de la compra no es válido
                    {
                        CustomMessageBox.Show("No se pudo obtener el ID de la compra seleccionada. Asegúrate de que esté correctamente seleccionado.", "Error");
                    }
                }
                catch (Exception ex) // Si no se seleccionó ninguna fila
                {
                    CustomMessageBox.Show($"Error al convertir el ID de la compra: {ex.Message}", "Error");
                }
            }
            else // Si no se seleccionó ninguna fila
            {
                CustomMessageBox.Show("Selecciona una venta para modificar.", "Error");
            }
        }

        private void B_ModificarVenta_Click(object sender, EventArgs e)
        {
            VerificarPermisosVentaSeleccionada();

            // Si el botón está habilitado, procede a abrir el formulario de modificación
            if (B_ModificarVenta.Enabled)
            {
                // Código para abrir el formulario de modificación
                if (DGV_Ventas.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = DGV_Ventas.SelectedRows[0];
                    if (filaSeleccionada.Cells["FolioVenta"].Value != null &&
                        int.TryParse(filaSeleccionada.Cells["FolioVenta"].Value.ToString(), out int folioVenta))
                    {
                        using (V_ModificarVenta modificarVentaForm = new V_ModificarVenta(folioVenta, _usuarioActual.Id, new POSContext(new DbContextOptions<POSContext>())))
                        {
                            if (modificarVentaForm.ShowDialog() == DialogResult.OK)
                            {
                                CargarVentas();
                            }
                        }
                    }
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede modificar esta venta ya que el corte está realizado.", "Acción no permitida");
                //activar botones
                B_ModificarVenta.Enabled = true;
                B_CancelarVenta.Enabled = true;
            }
        }

        private void TB_BuscarVenta_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
        private void AplicarFiltros()
        {
            if (_ventas == null)
                _ventas = ventasService.ObtenerVentas();

            var f = (TB_BuscarVenta.Text ?? "").Trim().ToLowerInvariant();

            var ventasFiltradas = _ventas.Where(v =>
                v.FolioVenta.ToString().Contains(f) ||
                (!string.IsNullOrEmpty(v.NombreUsuario) && v.NombreUsuario.ToLower().Contains(f)) ||
                (!string.IsNullOrEmpty(v.Usuario) && v.Usuario.ToLower().Contains(f)) || // por si usas esta propiedad en algún lugar
                (!string.IsNullOrEmpty(v.PlacaCarro) && v.PlacaCarro.ToLower().Contains(f))
            ).ToList();

            CargarVentas(ventasFiltradas);
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
    }

}

