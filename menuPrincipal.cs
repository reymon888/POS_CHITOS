using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Clientes;
using POS_CHITOS.Reportes;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS
{
    public partial class menuPrincipal : Form
    {
        private Form? activeForm;
        private readonly Usuario _usuarioActual;
        private readonly CortesService _cortesService;
        private bool _inicioCajaVerificado;

        private Button? _navSeleccionado;

        // Paleta
        private static readonly Color NAV_BASE = Color.FromArgb(31, 79, 120);  // azul barra
        private static readonly Color NAV_HOVER = Color.FromArgb(43, 100, 150); // azul claro al hover
        private static readonly Color NAV_ACTIVE = Color.FromArgb(53, 61, 71);   // gris activo

        public menuPrincipal(Usuario usuario, bool inicioCajaVerificado)
        {
            _usuarioActual = usuario ?? throw new ArgumentNullException(nameof(usuario));
            _inicioCajaVerificado = inicioCajaVerificado;

            InitializeComponent();

            // Ventana
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            TopMost = false;
            KeyPreview = true;
            KeyDown += menuPrincipal_KeyDown;

            // Servicios
            _cortesService = new CortesService(new POSContext(new DbContextOptions<POSContext>()));

            // UI usuario
            labelUsuario.Text = _usuarioActual.NombreUsuario;
            labelCargo.Text = _usuarioActual.Rol;

            // Configura la barra superior
            ConfigurarMenuSuperior(PanelSuperior);
        }

        // Dibujo suave de todo el form
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private static POSContext CreateContext()
            => new POSContext(new DbContextOptions<POSContext>());

        // Abre un child form ocupando el panel central
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                panelEscritorio.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose();
                activeForm = null;
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelEscritorio.SuspendLayout();
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
            panelEscritorio.ResumeLayout();
        }

        // Helpers
        private static bool TryClick(Button? b)
        {
            if (b is { Visible: true, Enabled: true })
            {
                b.PerformClick();
                return true;
            }
            return false;
        }
        private void SetMeta(Button b, string nombre, string atajo)
        {
            b.Tag = nombre;
            b.AccessibleDescription = atajo;
        }

        // ===== Navegación superior =====
        private void ConfigurarMenuSuperior(Control contenedor)
        {
            contenedor.BackColor = NAV_BASE;

            foreach (var b in contenedor.Controls.OfType<Button>())
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.UseVisualStyleBackColor = false;

                b.BackColor = NAV_BASE;
                b.ForeColor = Color.White;
                b.FlatAppearance.MouseOverBackColor = NAV_HOVER;
                b.FlatAppearance.MouseDownBackColor = NAV_ACTIVE;

                b.MouseEnter -= Nav_MouseEnter; b.MouseEnter += Nav_MouseEnter;
                b.MouseLeave -= Nav_MouseLeave; b.MouseLeave += Nav_MouseLeave;
                b.Click -= Nav_Click; b.Click += Nav_Click;
            }
        }

        private void Nav_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button b && b != _navSeleccionado)
                b.BackColor = NAV_HOVER;
        }

        private void Nav_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button b && b != _navSeleccionado)
                b.BackColor = NAV_BASE;
        }

        private void Nav_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;
            if (_navSeleccionado is { IsDisposed: false })
                _navSeleccionado.BackColor = NAV_BASE;

            b.BackColor = NAV_ACTIVE;
            _navSeleccionado = b;
        }

        // ===== Validación de monto inicial al mostrar =====
        private void menuPrincipal_Shown(object? sender, EventArgs e)
        {
            if (_inicioCajaVerificado) return;

            BeginInvoke(new Action(() =>
            {
                if (!_cortesService.ExisteMontoInicialHoy(_usuarioActual.Id))
                {
                    using var dlg = new V_MontoInicial(_usuarioActual.Id, _cortesService);
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                        _inicioCajaVerificado = true;
                }
                else
                {
                    _inicioCajaVerificado = true;
                }
            }));
        }

        private bool AsegurarInicioDeCaja()
        {
            if (_inicioCajaVerificado && _cortesService.ExisteMontoInicialHoy(_usuarioActual.Id))
                return true;

            using var dlg = new V_MontoInicial(_usuarioActual.Id, _cortesService);
            var ok = dlg.ShowDialog(this) == DialogResult.OK && _cortesService.ExisteMontoInicialHoy(_usuarioActual.Id);
            _inicioCajaVerificado = ok;
            return ok;
        }

        // ===== Clicks de menú =====
        private void B_Ventas_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_MenuVentas(_usuarioActual.Id, CreateContext()));

        private void B_Compras_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_MenuCompras(_usuarioActual.Id, CreateContext()));

        private void B_Inventario_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_menuInventario(_usuarioActual.Id, CreateContext()));

        private void B_Ingresos_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_menuEntradasEfectivo(_usuarioActual.Id, CreateContext()));

        private void B_Egresos_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_MenuSalidasEfectivo(_usuarioActual.Id, CreateContext()));

        private void B_Proveedores_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_menuProveedor(_usuarioActual.Id, CreateContext()));

        private void B_Caja_Click_1(object? sender, EventArgs e)
            => openChildForm(new V_MenuCortesCaja(_usuarioActual.Id, CreateContext()));

        private void B_Reportes_Click_2(object? sender, EventArgs e)
            => openChildForm(new V_MenuReportes());

        private void btnNuevaVenta_Click(object? sender, EventArgs e)
            => openChildForm(new V_CreateVenta(_usuarioActual.Id));

        private void b_NewCompra_Click(object? sender, EventArgs e)
            => openChildForm(new V_CreateCompra(_usuarioActual.Id));

        private void B_Salir_Click(object? sender, EventArgs e)
            => Application.Exit();

        private void menuPrincipal_KeyDown(object? sender, KeyEventArgs e)
        {
            // Ejemplo por si quieres atajos globales:
            // if (e.KeyCode == Keys.F12) TryClick(B_Ventas);
        }
    }
}
