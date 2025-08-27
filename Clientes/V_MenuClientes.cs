using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Clientes
{
    public partial class V_MenuClientes : Form
    {
        private readonly clientesService _svc;
        private readonly BindingSource _bs = new();
        private readonly List<ClientesDTO> _cache = new();
        private readonly System.Windows.Forms.Timer _debounce = new() { Interval = 250 };

        private ClientesDTO clienteSel => _bs.Current as ClientesDTO;
        public V_MenuClientes(POSContext ctx)
        {
            InitializeComponent();
            ConfigurarGrid();
            _svc = new clientesService(ctx);

            DGV_Clientes.DataSource = _bs;

            // FILTROS

            CB_Filtros.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Filtros.Items.AddRange(new[] { "Todos", "Habilitados", "Deshabilitados" });
            CB_Filtros.SelectedIndex = 0;

            TB_BuscarCliente.TextChanged += (_, __) => { _debounce.Stop(); _debounce.Start(); };
            _debounce.Tick += (_, __) => { _debounce.Stop(); AplicarFiltro(); };

            DGV_Clientes.SelectionChanged += (_, __) => HabilitarBotones();

            Shown += async (_, __) => { await CargarClientesAsync(); };

        }

        public void ConfigurarGrid()
        {
            DGV_Clientes.AutoGenerateColumns = false;
            DGV_Clientes.MultiSelect = false;
            DGV_Clientes.RowHeadersVisible = false;
            DGV_Clientes.AllowUserToAddRows = false;
            DGV_Clientes.AllowUserToResizeRows = false;

            DGV_Clientes.Columns.Clear();
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                Width = 120
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RFC",
                HeaderText = "RFC",
                Width = 110
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Dirección",
                Width = 220
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                Width = 110
            });

            // estilos básicos (opcional)
            DGV_Clientes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DGV_Clientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            DGV_Clientes.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            DGV_Clientes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 247, 250);

        }

        private async Task CargarClientesAsync()
        {
            try
            {
                // trae todo una vez (rápido por AsNoTracking del service)
                var lista = await Task.Run(() => _svc.Listar());
                _cache.Clear();
                _cache.AddRange(lista);
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFiltro()
        {
            string f = TB_BuscarCliente.Text?.Trim().ToLower() ?? "";
            int idx = CB_Filtros.SelectedIndex; // 0 todos, 1 habilitados, 2 deshabilitados

            var view = _cache.Where(c =>
                        (idx == 0) ||
                        (idx == 1 && c.Estado == "Habilitado") ||
                        (idx == 2 && c.Estado == "Deshabilitado"))
                     .Where(c =>
                        string.IsNullOrEmpty(f) ||
                        (c.Nombre?.ToLower().Contains(f) ?? false) ||
                        (c.Telefono?.ToLower().Contains(f) ?? false) ||
                        (c.RFC?.ToLower().Contains(f) ?? false))
                     .OrderBy(c => c.Nombre)
                     .ToList();

            _bs.DataSource = new BindingList<ClientesDTO>(view);
            HabilitarBotones();
        }

        private void HabilitarBotones()
        {
            bool haySel = clienteSel != null;
            B_Modificar.Enabled = haySel;
            B_Estado.Enabled = haySel;

        }

        private void B_Estado_Click(object sender, EventArgs e)
        {
            if (clienteSel == null) return;
            var activar = clienteSel.Estado == "Habilitado";
            _svc.CambiarEstado(clienteSel.IdCliente, activar);
            _ = CargarClientesAsync();
        }

        // Atajos
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N)) { B_Agregar.PerformClick(); return true; }
            if (keyData == (Keys.Control | Keys.M)) { B_Modificar.PerformClick(); return true; }
            if (keyData == (Keys.Control | Keys.B)) { B_Estado.PerformClick(); return true; }
            if (keyData == (Keys.Control | Keys.S)) { TB_BuscarCliente.Focus(); TB_BuscarCliente.SelectAll(); return true; }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
