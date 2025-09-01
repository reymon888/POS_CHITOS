using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_CHITOS.Utils;

namespace POS_CHITOS.Clientes
{
    public partial class V_MenuClientes : Form
    {
        private readonly POSContext _ctx;
        private readonly clientesService _svc;
        private readonly BindingSource _bs = new();
        private readonly List<ClientesDTO> _cache = new();
        private readonly System.Windows.Forms.Timer _debounce = new() { Interval = 250 };

        private ClientesDTO clienteSel => _bs.Current as ClientesDTO;
        public V_MenuClientes(POSContext ctx)
        {
            InitializeComponent();
            ConfigurarGrid();
            _ctx = ctx;
            _svc = new clientesService(_ctx);

            DGV_Clientes.DataSource = _bs;

            // FILTROS

            CB_Filtros.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_Filtros.Items.Clear();
            CB_Filtros.Items.AddRange(new[] { "Habilitados", "Todos", "Deshabilitados" });
            CB_Filtros.SelectedItem = "Habilitados";     // default = activos
            CB_Filtros.SelectedIndexChanged += (_, __) => AplicarFiltro();


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
            DGV_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Clientes.AllowUserToResizeColumns = true;



            DGV_Clientes.Columns.Clear();

            // --- Columnas ---
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre",
                FillWeight = 24,                   // antes estaba gigantesca; bajamos
                MinimumWidth = 180
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefono",
                HeaderText = "Teléfono",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RFC",
                HeaderText = "RFC",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 22
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Direccion",
                HeaderText = "Dirección",
                FillWeight = 28,                    // le damos más espacio 👈
                MinimumWidth = 220,
                DefaultCellStyle = { WrapMode = DataGridViewTriState.True }
            });
            DGV_Clientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 8
            });

            // --- Tema y formatos (EXTENSIONES) ---
            DGV_Clientes.ApplyTheme(compacto: true);                 // look/feel consistente
            DGV_Clientes.Center("Telefono", "RFC", "Estado");        // centrado en esas columnas
            DGV_Clientes.PillByValue("Estado");                      // verde/rojo para estado

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
                        (idx == 0 && c.Estado == "Habilitado") ||
                        (idx == 1 ) ||
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
            if (haySel)
                B_Estado.Text = clienteSel.Estado == "Habilitado"
                    ? "Deshabilitar (Ctrl + B)"
                    : "Habilitar (Ctrl + B)";
        }


        private async void B_Estado_ClickAsync(object sender, EventArgs e)
        {
            if (clienteSel == null) return;

            // toggle de estado
            _svc.CambiarEstado(clienteSel.IdCliente);   // o pasando el bool invertido, según tu service
            await CargarClientesAsync();
            Toast.Show(this, "Estado del cliente actualizado.", ToastType.Info, 2200, ToastPosition.TopRight);
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

        private void B_Agregar_Click(object sender, EventArgs e)
        {
            using var f = new V_UpsertCliente(_ctx);
            if (f.ShowDialog() == DialogResult.OK)
                _ = CargarClientesAsync();
            Toast.Show(this, "Cliente creado con éxito.", ToastType.Success, 2200, ToastPosition.Center);
        }

        private void B_Modificar_Click(object sender, EventArgs e)
        {
            if (clienteSel == null) return;
            using var f = new V_UpsertCliente(_ctx, clienteSel.IdCliente);
            if (f.ShowDialog(this) == DialogResult.OK)
                _ = CargarClientesAsync();
            Toast.Show(this, "Cliente actualizado.", ToastType.Info, 2200, ToastPosition.TopRight);
        }

        private void AbrirDetalles()
        {
            if (clienteSel == null) return;
            using var f = new V_ClienteDetalle(clienteSel);
            f.ShowDialog(this);
        }

        private void DGV_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirDetalles();
        }
    }

}
