using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Compras;
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
    public partial class V_MenuCompras : Form
    {
        private Usuario _usuarioActual;  // Usuario actual
        private readonly ComprasService _comprasService;
        private List<CompraDTO> _compras;
        private readonly BindingSource _bsCompras = new();
        private Control _lista => DGV_Compras;
        private Control? _vistaActual;
        public V_MenuCompras(int idusuario, POSContext context)
        {
            InitializeComponent();
            _usuarioActual = context.Usuarios.Find(idusuario);
            _comprasService = new ComprasService(context);

            ConfigurarPermisos();
            ConfigurarGridCompras();
            InicializarVista();
            // Cargar las compras al abrir el formulario
            CargarCompras();


        }
        private void InicializarVista()
        {
            // Igual que en ventas: la grilla vive dentro del host
            if (_lista.Parent != panelHost)
            {
                _lista.Parent = panelHost;
                _lista.Dock = DockStyle.Fill;
            }
            MostrarLista();
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

            if (panelSuperior != null)
                panelSuperior.Visible = true;

            panelHost.Visible = true;
            panelHost.BringToFront();
            panelHost.ResumeLayout();
        }

        private void ShowFormInPanel(Form f)
        {
            panelHost.SuspendLayout();

            // Esconde el listado (NO el host)
            _lista.Visible = false;
            if (panelSuperior != null)
                panelSuperior.Visible = false;

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

            panelHost.Controls.Clear();
            panelHost.Controls.Add(f);
            _vistaActual = f;

            // fallback por si cierran con la X
            f.FormClosed -= Child_FormClosedRestore;
            f.FormClosed += Child_FormClosedRestore;

            panelHost.Visible = true;
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
                CargarCompras();
                Toast.Show(this, "Compras actualizadas.", ToastType.Success, 1600, ToastPosition.BottomRight);
            }
        }

        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarCompra.Enabled = false;
                B_CancelarCompra.Enabled = false;
                B_ModificarCompra.Visible = false;
                B_CancelarCompra.Visible = false;

               
                B_BuscarPorFecha.Visible = false;
                
            }
        }
        private void VerificarPermisosCompraSeleccionada()
        {
            // Asegurarse de que _compras está inicializado
            if (_compras == null)
            {
                _compras = _comprasService.ListarCompras();
            }

            B_ModificarCompra.Enabled = false;
            B_CancelarCompra.Enabled = false;

            if (DGV_Compras.SelectedRows.Count > 0)
            {
                var filaSeleccionada = DGV_Compras.SelectedRows[0];
                if (filaSeleccionada.Cells["idCompra"].Value != null &&
                    int.TryParse(filaSeleccionada.Cells["idCompra"].Value.ToString(), out int idCompra))
                {
                    // Obtener la compra seleccionada y verificar el estado del corte
                    var compraSeleccionada = _compras.FirstOrDefault(c => c.idCompra == idCompra);
                    if (compraSeleccionada != null && compraSeleccionada.EstadoCorte != "Realizado")
                    {
                        B_ModificarCompra.Enabled = true;
                        B_CancelarCompra.Enabled = true;
                    }
                }
            }
        }


        public void CargarCompras(List<CompraDTO> comprasFiltradas = null)
        {
            try
            {
                var compras = comprasFiltradas ?? _comprasService.ListarCompras();

                if (_usuarioActual.Rol == "Cajero" || _usuarioActual.Rol == "Cajero Principal")
                {
                    compras = compras
                        .Where(c => c.NombreUsuario == _usuarioActual.NombreUsuario)
                        .ToList();
                }

                _compras = compras;
                _bsCompras.DataSource = null;
                _bsCompras.DataSource = compras;
                _bsCompras.ResetBindings(false);

                OcultarColumnasTecnicas();   // <- aquí también

                Toast.Show(this, "Compras cargadas.", ToastType.Info, 1600, ToastPosition.TopRight);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error al cargar las compras: {ex.Message}", "Error");
            }
        }


        private void ActualizarGridComprasSilencioso(List<CompraDTO> compras)
        {
            if (_usuarioActual.Rol == "Cajero" || _usuarioActual.Rol == "Cajero Principal")
                compras = compras.Where(c => c.NombreUsuario == _usuarioActual.NombreUsuario).ToList();

            _compras = compras;
            _bsCompras.DataSource = null;
            _bsCompras.DataSource = compras;
            _bsCompras.ResetBindings(false);
        }


        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {
            CargarCompras();
        }

        public void abrirdetallones()
        {
            if (DGV_Compras.SelectedRows.Count > 0)
            {
                var idCompra = Convert.ToInt32(DGV_Compras.SelectedRows[0].Cells["idCompra"].Value);
                V_MostrarDetallesCompras detallesForm = new V_MostrarDetallesCompras(idCompra);
                detallesForm.ShowDialog();
            }
            else
            {
                CustomMessageBox.Show("Seleccione una compra para ver los detalles", "Mensaje");
            }
        }

        private void B_MostrarDetalles_Click(object sender, EventArgs e)
        {
            if (DGV_Compras.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Seleccione una compra para ver los detalles", "Mensaje");
                return;
            }

            var idCompra = Convert.ToInt32(DGV_Compras.SelectedRows[0].Cells["idCompra"].Value);

            var form = new V_MostrarDetallesCompras(
                idCompra,
                onClose: refrescar => CloseEmbeddedView(refrescar)
            );

            ShowFormInPanel(form);
        }


        private void B_ModificarCompra_Click(object sender, EventArgs e)
        {
            VerificarPermisosCompraSeleccionada();

            if (!B_ModificarCompra.Enabled)
            {
                CustomMessageBox.Show("No se puede modificar esta compra porque pertenece a un corte realizado.", "Acción no permitida");
                return;
            }

            if (DGV_Compras.SelectedRows.Count == 0)
            {
                CustomMessageBox.Show("Seleccione una compra para modificar.", "Mensaje");
                return;
            }

            try
            {
                var selectedRow = DGV_Compras.SelectedRows[0];

                if (selectedRow.Cells["idCompra"].Value != null &&
                    int.TryParse(selectedRow.Cells["idCompra"].Value.ToString(), out int idCompra) &&
                    idCompra > 0)
                {
                    var form = new V_ModificarCompra(
                        idCompra,
                        onClose: refrescar => CloseEmbeddedView(refrescar)
                    );

                    ShowFormInPanel(form);
                }
                else
                {
                    CustomMessageBox.Show("El ID de la compra no es válido.", "Error");
                }
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show($"Error al modificar la compra: {ex.Message}", "Error");
            }
        }

        private void B_CancelarCompra_Click(object sender, EventArgs e)
        {
            VerificarPermisosCompraSeleccionada();

            // Si el botón está habilitado, procede a cambiar el estado de la compra
            if (B_CancelarCompra.Enabled)
            {
                if (DGV_Compras.SelectedRows.Count > 0)
                {
                    var idCompra = Convert.ToInt32(DGV_Compras.SelectedRows[0].Cells["idCompra"].Value);
                    var estado = DGV_Compras.SelectedRows[0].Cells["Estado"].Value.ToString();

                    if (estado == "Realizada")
                    {
                        var confirmacion = MessageBox.Show("¿Está seguro de cancelar la compra? Los productos de esta compra serán reducidos del stock.",
                                                           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmacion == DialogResult.Yes)
                        {
                            _comprasService.CambiarEstadoCompra(idCompra, "Cancelada");
                            CargarCompras();
                        }
                    }
                    else if (estado == "Cancelada")
                    {
                        var confirmacion = MessageBox.Show("¿Está seguro de reactivar la compra?",
                                                           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (confirmacion == DialogResult.Yes)
                        {
                            _comprasService.CambiarEstadoCompra(idCompra, "Realizada");
                            CargarCompras();
                        }
                    }
                }
                else
                {
                    CustomMessageBox.Show("Seleccione una compra para cancelar o reactivar.", "Mensaje");
                }
            }
            else
            {
                CustomMessageBox.Show("No se puede cancelar esta compra porque pertenece a un corte realizado.", "Acción no permitida");
                B_ModificarCompra.Enabled = true;
                B_CancelarCompra.Enabled = true;
            }
        }

        private void TB_BuscarCompra_TextChanged(object sender, EventArgs e)
        {
            var f = (TB_BuscarCompra.Text ?? "").Trim();

            if (string.IsNullOrEmpty(f))
            {
                CargarCompras();
                return;
            }

            var fLower = f.ToLowerInvariant();

            if (_compras == null)
                _compras = _comprasService.ListarCompras();

            var filtradas = _compras.Where(c =>
                c.FolioCompraOriginal?.ToLower().Contains(fLower) == true ||
                c.NombreProveedor?.ToLower().Contains(fLower) == true ||
                c.NombreUsuario?.ToLower().Contains(fLower) == true
            ).ToList();

            ActualizarGridComprasSilencioso(filtradas);
        }

        private void B_BuscarPorFecha_Click(object sender, EventArgs e)
        {
            // Crear Form para seleccionar rango de fechas
            using (var formFechas = new Form())
            {
                formFechas.Text = "Buscar Compras por Rango de Fechas";
                formFechas.Size = new Size(400, 240);
                formFechas.StartPosition = FormStartPosition.CenterParent;
                formFechas.FormBorderStyle = FormBorderStyle.FixedDialog;
                formFechas.MaximizeBox = false;
                formFechas.MinimizeBox = false;

                var lblDesde = new System.Windows.Forms.Label
                {
                    Text = "Fecha Desde:",
                    Location = new Point(20, 20),
                    Size = new Size(100, 25),
                    Font = new Font("Segoe UI", 11)
                };

                var dtpDesde = new DateTimePicker
                {
                    Location = new Point(130, 18),
                    Size = new Size(240, 30),
                    Font = new Font("Segoe UI", 10),
                    Format = DateTimePickerFormat.Short,
                    Value = DateTime.Now.AddMonths(-1) // último mes
                };

                var lblHasta = new System.Windows.Forms.Label
                {
                    Text = "Fecha Hasta:",
                    Location = new Point(20, 65),
                    Size = new Size(100, 25),
                    Font = new Font("Segoe UI", 11)
                };

                var dtpHasta = new DateTimePicker
                {
                    Location = new Point(130, 63),
                    Size = new Size(240, 30),
                    Font = new Font("Segoe UI", 10),
                    Format = DateTimePickerFormat.Short,
                    Value = DateTime.Now
                };

                var chkIncluirCanceladas = new CheckBox
                {
                    Text = "Incluir compras canceladas",
                    Location = new Point(20, 110),
                    Size = new Size(350, 25),
                    Font = new Font("Segoe UI", 10),
                    Checked = false
                };

                var btnBuscar = new Button
                {
                    Text = "Buscar",
                    Location = new Point(180, 155),
                    Size = new Size(100, 35),
                    DialogResult = DialogResult.OK,
                    Font = new Font("Segoe UI", 10),
                    BackColor = Color.FromArgb(0, 122, 204),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };

                var btnCancelar = new Button
                {
                    Text = "Cancelar",
                    Location = new Point(290, 155),
                    Size = new Size(100, 35),
                    DialogResult = DialogResult.Cancel,
                    Font = new Font("Segoe UI", 10)
                };

                formFechas.Controls.AddRange(new Control[] {
            lblDesde, dtpDesde, lblHasta, dtpHasta,
            chkIncluirCanceladas, btnBuscar, btnCancelar
        });

                formFechas.AcceptButton = btnBuscar;
                formFechas.CancelButton = btnCancelar;

                // Validación de fechas
                btnBuscar.Click += (s, ev) =>
                {
                    if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                    {
                        CustomMessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.", "Fechas inválidas");
                        formFechas.DialogResult = DialogResult.None;
                    }
                };

                if (formFechas.ShowDialog() != DialogResult.OK)
                    return;

                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1); // incluir todo el día

                // Buscar compras en el rango
                var comprasPorFecha = _comprasService.ListarComprasPorFecha(
                    desde,
                    hasta,
                    chkIncluirCanceladas.Checked
                );

                if (comprasPorFecha.Count == 0)
                {
                    CustomMessageBox.Show(
                        $"No se encontraron compras entre {desde:dd/MMM/yyyy} y {dtpHasta.Value.Date:dd/MMM/yyyy}",
                        "Sin resultados"
                    );
                    return;
                }

                // Limpiar buscador de texto
                TB_BuscarCompra.Clear();

                // Cargar en la grilla usando tu mismo flujo
                CargarCompras(comprasPorFecha);

                Toast.Show(
                    this,
                    $"Encontradas {comprasPorFecha.Count} compras ({desde:dd/MMM} - {dtpHasta.Value.Date:dd/MMM})",
                    ToastType.Success,
                    2500,
                    ToastPosition.TopRight
                );
            }
        }

        private void ConfigurarGridCompras()
        {
            DGV_Compras.AutoGenerateColumns = false;
            DGV_Compras.MultiSelect = false;
            DGV_Compras.RowHeadersVisible = false;
            DGV_Compras.AllowUserToAddRows = false;
            DGV_Compras.AllowUserToResizeRows = false;
            DGV_Compras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Compras.AllowUserToResizeColumns = true;
            DGV_Compras.Columns.Clear();

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "idCompra",
                HeaderText = "ID Compra",
                DataPropertyName = "idCompra",
                Visible = false,        // <- se crea ya oculta
                MinimumWidth = 60
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FolioCompraOriginal",
                HeaderText = "Folio Compra",
                DataPropertyName = "FolioCompraOriginal",
                FillWeight = 14,
                MinimumWidth = 120
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreProveedor",
                HeaderText = "Proveedor",
                DataPropertyName = "NombreProveedor",
                FillWeight = 22,
                MinimumWidth = 160
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreUsuario",
                HeaderText = "Usuario",
                DataPropertyName = "NombreUsuario",
                FillWeight = 18,
                MinimumWidth = 140
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "FechaCompra",
                HeaderText = "Fecha",
                DataPropertyName = "FechaCompra",
                FillWeight = 16,
                DefaultCellStyle = { Format = "g" }
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalCompra",
                HeaderText = "Total",
                DataPropertyName = "TotalCompra",
                FillWeight = 14,
                DefaultCellStyle = { Format = "C2" }
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                FillWeight = 10,
                MinimumWidth = 100
            });

            DGV_Compras.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "EstadoCorte",
                HeaderText = "Estado Corte",
                DataPropertyName = "EstadoCorte",
                Visible = false
            });

            DGV_Compras.ApplyTheme(compacto: true);
            DGV_Compras.Center("FolioCompraOriginal", "Estado");
            DGV_Compras.FormatCurrency("TotalCompra");
            DGV_Compras.PillByValue("Estado", good: "Realizada", bad: "Cancelada");

            DGV_Compras.CellFormatting += (s, e) =>
            {
                if (e.RowIndex < 0) return;
                var col = DGV_Compras.Columns[e.ColumnIndex];
                if (col.DataPropertyName != "Estado") return;

                var val = e.Value as string;
                var cell = DGV_Compras.Rows[e.RowIndex].Cells[e.ColumnIndex];

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
            };

            DGV_Compras.DataSource = _bsCompras;

            // refuerzo por si alguna vez aparece otra columna "idCompra"
            OcultarColumnasTecnicas();
        }

        private void OcultarColumnasTecnicas()
        {
            var colId = DGV_Compras.Columns["idCompra"];
            if (colId != null)
                colId.Visible = false;

            var colCorte = DGV_Compras.Columns["EstadoCorte"];
            if (colCorte != null)
                colCorte.Visible = false;
        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarCompra.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_CancelarCompra.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.D))
            {
                B_MostrarDetalles.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Compras.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarCompra.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
