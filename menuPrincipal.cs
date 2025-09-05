using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Clientes;
using POS_CHITOS.Reportes;
using POS_CHITOS.Usuarios;
using POS_CHITOS.Utils;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace POS_CHITOS
{
    public partial class menuPrincipal : Form
    {
        private Form activeForm;
        private Usuario _usuarioActual;
        private Button botonSeleccionado; // Variable para rastrear el botón seleccionado
        private readonly CortesService _cortesService;
        private Toast _toastActual;

        // --- Sidebar state/animación ---
        bool sideExpanded = false;
        int SIDE_W_COLLAPSED = 72;      // colapsado
        int SIDE_W_EXPANDED = 260;     // expandido
        int SIDE_STEP = 12;      // px por tick
        int SIDE_TEXT_LIMIT = 140;     // desde aquí ya muestro texto

        System.Windows.Forms.Timer sideTimer;
        int sideTargetWidth;

        ToolTip sideTips = new ToolTip();



        public menuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            // Empiece en pantalla completa
            this.WindowState = FormWindowState.Maximized;
            // No permitir que cambie el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            // No permitir que se maximice la ventana
            this.MaximizeBox = false;
            // Asegurarse de que la ventana no cubra la barra de tareas
            this.TopMost = false;

            _cortesService = new CortesService(new POSContext(new DbContextOptions<POSContext>()));

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuPrincipal_KeyDown);

            this.KeyPreview = true; // garantiza que ProcessCmdKey siempre reciba las teclas



            // Verificar que el usuario no sea null
            if (usuario != null)
            {
                _usuarioActual = usuario;

                // Asignar el nombre y rol del usuario a los labels
                labelUsuario.Text = usuario.NombreUsuario;
                labelCargo.Text = usuario.Rol;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Asignar eventos a los botones del panel lateral
            foreach (Control control in PanelLateral.Controls)
            {
                if (control is Button boton && boton.Name != "B_Salir")  // Ignorar el botón de salir
                {
                    boton.Click += CambiarColorBoton;
                }
            }

            // Asignar eventos a los botones del panel superior
            foreach (Control control in PanelSuperior.Controls)
            {
                if (control is Button boton)
                {
                    boton.Click += CambiarColorBoton;
                }
            }

            // Configurar los permisos según el rol del usuario
            ConfigurarPermisos();



            // Dock/estilo del lateral
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Width = SIDE_W_COLLAPSED;
            PanelLateral.Padding = new Padding(0, 12, 0, 12);

            PanelLateral.BackColor = Color.FromArgb(31, 79, 120);  // #1F4F78
            PanelLateral.AutoScroll = true;

            // Configura TODOS los botones ya existentes del lateral (apilar + estilos)
            ConfigurarBotonesLateral(PanelLateral);





            PanelLateral.AutoScroll = false;   // listo, no habrá barras

            OrdenarPorTabIndex();




            // Redondear los botones
            RedondearBoton(btnNuevaVenta, 40);



            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            EnableDoubleBuffer(this);
            EnableDoubleBuffer(PanelSuperior);
            EnableDoubleBuffer(PanelLateral);
            EnableDoubleBuffer(panelEscritorio);
            // si usas DataGridView:
            // EnableDoubleBuffer(miDataGridView);


            SetMeta(B_Ventas, "Ventas", "F12");
            SetMeta(B_Compras, "Compras", "Ctrl + M");
            SetMeta(B_Clientes, "Clientes", "Ctrl + L");
            SetMeta(B_Reportes, "Reportes", "F9");
            SetMeta(B_Usuarios, "Usuarios", "F6");

            WireSidebarToasts();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openChildForm(Form childForm)
        {
            // Cierra y libera el hijo anterior si existe
            if (activeForm != null)
            {
                panelEscritorio.Controls.Remove(activeForm);
                activeForm.Close();
                activeForm.Dispose();     // <- clave
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


        private void menuSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        // Cambiar color de los botones del panel lateral
        // Cambiar color de los botones
        private void CambiarColorBoton(object sender, EventArgs e)
        {
            if (botonSeleccionado != null)
                botonSeleccionado.BackColor = PanelLateral.BackColor; // el azul del side

            if (sender is Button b)
            {
                b.UseVisualStyleBackColor = false;
                b.BackColor = Color.FromArgb(53, 61, 71); // activo
                botonSeleccionado = b;
            }
        }


        private void B_Reportes_Click_1(object sender, EventArgs e)
        {
            openChildForm(new V_MenuReportes());
        }

        // Método para configurar los permisos según el rol del usuario
        private void ConfigurarPermisos()
        {
            //Si el rol del usuario actual es Cajero o Cajero Principal que no tenga permiso a reportes y usuarios
            if (_usuarioActual.Rol == "Cajero" || _usuarioActual.Rol == "Cajero Principal")
            {
                //B_Usuarios.Visible = false;
                //B_Reportes.Visible = false;
            }

        }

        private void menuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {



        }

        // Helper reutilizable en tu formulario
        private static bool TryClick(Button b)
        {
            if (b != null && b.Visible && b.Enabled)
            {
                b.PerformClick();
                return true;
            }
            return false;
        }

        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
        //    switch (keyData)
        //    {
        //        //case Keys.F1: return TryClick(B_NuevaVenta) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F2: return TryClick(B_Inventario) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F3: return TryClick(B_Entradas) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F4: return TryClick(B_NuevaCompra) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F5: return TryClick(B_Proveedores) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F6: return TryClick(B_Usuarios) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F7: return TryClick(B_Gastos) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F8: return TryClick(B_Compras) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F9: return TryClick(B_Reportes) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F10: return TryClick(B_Ventas) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F11: return TryClick(B_Cortes) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.F12: return TryClick(B_Salir) || base.ProcessCmdKey(ref msg, keyData);
        //        //case Keys.Control | Keys.L: return TryClick(B_Clientes) || base.ProcessCmdKey(ref msg, keyData);
        //        //default:
        //        //    return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //}

        private static POSContext CreateContext()
        {
            // hoy no cambia nada; si mañana ajustas cadena de conexión o logging,
            // lo haces aquí y el resto del código ni se entera.
            return new POSContext(new DbContextOptions<POSContext>());
        }
        private void RedondearBoton(Button boton, int radio)
        {
            GraphicsPath path = new GraphicsPath();
            Rectangle rect = new Rectangle(0, 0, boton.Width, boton.Height);

            path.AddArc(rect.X, rect.Y, radio, radio, 180, 90);
            path.AddArc(rect.Right - radio, rect.Y, radio, radio, 270, 90);
            path.AddArc(rect.Right - radio, rect.Bottom - radio, radio, radio, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radio, radio, radio, 90, 90);
            path.CloseFigure();

            boton.Region = new Region(path);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ConfigurarBotonesLateral(Panel side)
        {
            // Orden por posición (o usa TabIndex)
            var btns = side.Controls.OfType<Button>()
                        .Where(b => b.Name != "B_Salir") // si quieres excluir Salir
                        .OrderBy(b => b.Top).ToList();

            foreach (var b in btns)
            {
                if (b.Tag == null) b.Tag = b.Text;  // guardo su texto original
                b.Text = "";                        // colapsado

                b.Dock = DockStyle.Top;             // apilar
                b.Height = 44;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.UseVisualStyleBackColor = false;

                // Colores/estados (coinciden con lo que ya usas)
                b.BackColor = Color.Transparent;
                b.ForeColor = Color.White;
                b.FlatAppearance.MouseOverBackColor = Color.FromArgb(61, 70, 82); // #3D4652
                b.FlatAppearance.MouseDownBackColor = Color.FromArgb(53, 61, 71); // #353D47

                // Alineaciones (icono izq, texto izq)
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;

                // Separador entre botones
                var spacer = new Panel { Dock = DockStyle.Top, Height = 8 };
                side.Controls.Add(spacer);
                b.BringToFront();

                // Tooltip (cuando está colapsado)
                sideTips.SetToolTip(b, b.Tag?.ToString() ?? "");

                b.Margin = new Padding(0);             // sin márgenes laterales
                b.Padding = new Padding(14, 0, 10, 0);  // espacio interno (no del panel)



            }
        }




        private void PanelLateral_Resize(object sender, EventArgs e)
        {
            int w = PanelLateral.ClientSize.Width - PanelLateral.Padding.Left - PanelLateral.Padding.Right;
            foreach (var b in PanelLateral.Controls.OfType<Button>())
                b.Width = w;   // así el fondo hover/activo cubre la fila completa
        }

        private void OrdenarPorTabIndex()
        {
            var btns = PanelLateral.Controls.OfType<Button>()
                         .Where(b => b.Dock != DockStyle.Bottom)   // deja fuera los de abajo
                         .OrderBy(b => b.TabIndex)                 // ARRIBA → ABAJO
                         .ToList();

            PanelLateral.SuspendLayout();
            for (int i = btns.Count - 1; i >= 0; i--)              // agrega de abajo hacia arriba
            {
                var b = btns[i];
                b.Dock = DockStyle.Top;
                PanelLateral.Controls.SetChildIndex(b, 0);
            }
            PanelLateral.ResumeLayout();
        }

        private void B_Ventas_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de ventas
            openChildForm(new V_MenuVentas(_usuarioActual.Id, CreateContext()));

        }

        private void B_Clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new V_MenuClientes(CreateContext()));
        }

        // 1.a  En la clase (top)
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED -> compone todo el form
                return cp;
            }
        }



        static void EnableDoubleBuffer(Control c)
        {
            if (SystemInformation.TerminalServerSession) return;

            // DoubleBuffered = true
            typeof(Control)
                .GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)?
                .SetValue(c, true, null);

            // ResizeRedraw = true  (también es protected)
            typeof(Control)
                .GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance)?
                .SetValue(c, true, null);

            // Opcional: SetStyle(UserPaint|AllPaintingInWmPaint|OptimizedDoubleBuffer, true)
            typeof(Control)
                .GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance)?
                .Invoke(c, new object[] {
            ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer,
            true
                });

            foreach (Control child in c.Controls)
                EnableDoubleBuffer(child);
        }
        void SetMeta(Button b, string nombre, string atajo)
        {
            b.Tag = nombre;                    // nombre para mostrar
            b.AccessibleDescription = atajo;   // texto del atajo
        }

        private void WireSidebarToasts()
        {
            foreach (var b in PanelLateral.Controls.OfType<Button>())
            {
                b.MouseEnter -= PanelLateral_MouseEnter;
                b.MouseLeave -= PanelLateral_MouseLeave;

                b.MouseEnter += PanelLateral_MouseEnter;
                b.MouseLeave += PanelLateral_MouseLeave;
            }
        }



        private void ShowToastSidebar(Control anchor, string nombre, string atajo)
        {
            // cierra el anterior (si existiera)
            try
            {
                if (_toastActual != null && !_toastActual.IsDisposed)
                    _toastActual.Close();
            }
            catch { /* ignore */ }
            finally { _toastActual = null; }

            string text = string.IsNullOrWhiteSpace(atajo) ? nombre : $"{nombre}  ·  {atajo}";
            var t = new Toast(text, ToastType.Info, 1200);

            // --- Fit al contenido, tolerante a nulos ---
            var lbl = t.Controls.OfType<Label>().FirstOrDefault();
            var font = lbl?.Font ?? this.Font;
            int padL = lbl?.Padding.Left ?? 14;
            int padR = lbl?.Padding.Right ?? 14;

            int textW = TextRenderer.MeasureText(text, font).Width;
            int w = textW + padL + padR + 10;
            int minW = 140, maxW = 360;
            w = Math.Min(maxW, Math.Max(minW, w));
            t.Size = new Size(w, t.Height);

            // --- Tema oscuro + franja ámbar ---
            t.BackColor = Color.FromArgb(53, 61, 71);  // #353D47
            if (lbl != null) lbl.ForeColor = Color.White;

            var stripe = new Panel { Dock = DockStyle.Left, Width = 4, BackColor = Color.FromArgb(240, 180, 41) }; // #F0B429
            t.Controls.Add(stripe);
            stripe.BringToFront();

            // --- Posicionamiento robusto ---
            var owner = anchor?.FindForm();
            var screen = (owner != null) ? Screen.FromControl(owner) : Screen.FromControl(anchor);
            Rectangle work = screen.WorkingArea;

            var r = anchor.RectangleToScreen(anchor.ClientRectangle);
            int x = r.Right + 10;
            int y = r.Top + (r.Height - t.Height) / 2;

            if (x + t.Width > work.Right) x = r.Left - 10 - t.Width;
            y = Math.Max(work.Top + 8, Math.Min(y, work.Bottom - 8 - t.Height));

            t.Location = new Point(x, y);
            _toastActual = t;
            t.FormClosed += (_, __) => { _toastActual = null; }; // por si se cierra solo

            t.Show(owner);
        }


        private void HideToastSidebar()
        {
            try
            {
                if (_toastActual != null && !_toastActual.IsDisposed)
                    _toastActual.Close(); // ahora el timer ya no dará guerra
            }
            catch { }
            finally { _toastActual = null; }
        }


        private void PanelLateral_MouseEnter(object sender, EventArgs e)
        {
            if (sender is not Button b) return;      // ← evita el cast inválido
           
            string nombre = b.Tag as string ?? b.Text;
            string atajo = b.AccessibleDescription;
            ShowToastSidebar(b, nombre, atajo);   // SOLO este
        }

        private void PanelLateral_MouseLeave(object sender, EventArgs e)
        {

            if (sender is Button) HideToastSidebar(); // opcional, o simplemente HideToastSidebar();
        }
    }
}
