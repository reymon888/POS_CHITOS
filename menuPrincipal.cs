using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Reportes;
using POS_CHITOS.Usuarios;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace POS_CHITOS
{
    public partial class menuPrincipal : Form
    {
        private Form activeForm;
        private Usuario _usuarioActual;
        private Button botonSeleccionado; // Variable para rastrear el botón seleccionado
        private readonly CortesService _cortesService;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //cerrar esta ventaja y abrir el login

            this.Close();
            var loginForm = new V_LogIn();

            loginForm.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_menuProveedor(_usuarioActual.Id, context));



        }

        private void openChildForm(Form childForm)
        {
            // Cierra el formulario activo si existe
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Configuración del nuevo formulario hijo
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Agregar el formulario hijo al panel
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;

            // Mostrar y establecer el foco en el formulario hijo
            childForm.BringToFront();
            childForm.Show();
            childForm.Focus(); // Asegura que el foco esté en el formulario hijo
        }


        private void menuSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Inventario_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Pasar el contexto al crear el formulario
            openChildForm(new V_menuInventario(_usuarioActual.Id, context));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Pasar el contexto al crear el formulario
            openChildForm(new V_menuUsuarios(context));
        }

        private void B_reportes_Click(object sender, EventArgs e)
        {

        }

        private void menuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void B_Usuarios_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Pasar el contexto al crear el formulario
            openChildForm(new V_menuUsuarios(context));
        }

        private void B_NuevaCompra_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Crear una nueva instancia de V_CreateCompra y pasar el ID del usuario actual
            openChildForm(new V_CreateCompra(_usuarioActual.Id));  // Asume que _usuarioActual tiene el ID del usuario
        }

        private void B_Compras_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Pasar el contexto al crear el formulario
            openChildForm(new V_MenuCompras(_usuarioActual.Id, context));
        }

        private void B_NuevaVenta_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_CreateVenta(_usuarioActual.Id));
        }

        private void B_Ventas_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_MenuVentas(_usuarioActual.Id, context));
        }

        private void B_caja_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_menuEntradasEfectivo(_usuarioActual.Id, context));
        }

        private void B_Cortes_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Pasamos el usuario actual y el contexto al menú de cortes
            openChildForm(new V_MenuCortesCaja(_usuarioActual.Id, context));
        }

        private void B_Gastos_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_MenuSalidasEfectivo(_usuarioActual.Id, context));
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Cambiar color de los botones del panel lateral
        // Cambiar color de los botones
        private void CambiarColorBoton(object sender, EventArgs e)
        {
            // Si había un botón seleccionado previamente, restaurar su color predeterminado
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = Color.FromArgb(26, 77, 128); // Color predeterminado
            }

            // Cambiar el color solo al botón que fue clicado
            Button botonClicado = sender as Button;
            if (botonClicado != null)
            {
                botonClicado.BackColor = Color.FromArgb(51, 51, 51); // Color cuando se hace clic
                botonSeleccionado = botonClicado; // Establecer el botón como el seleccionado
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
                B_Usuarios.Visible = false;
                B_Reportes.Visible = false;
            }
          
        }

        private void menuPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
           


        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    B_NuevaVenta.PerformClick();
                    return true;
                case Keys.F2:
                    B_Inventario.PerformClick();
                    return true;
                case Keys.F3:
                    B_Entradas.PerformClick();
                    return true;
                case Keys.F4:
                    B_NuevaCompra.PerformClick();
                    return true;
                case Keys.F5:
                    B_Proveedores.PerformClick();
                    return true;
                case Keys.F6:
                    B_Usuarios.PerformClick();
                    return true;
                case Keys.F7:
                    B_Gastos.PerformClick();
                    return true;
                case Keys.F8:
                    B_Compras.PerformClick();
                    return true;
                case Keys.F9:
                    B_Reportes.PerformClick();
                    return true;
                case Keys.F10:
                    B_Ventas.PerformClick();
                    return true;
                case Keys.F11:
                    B_Cortes.PerformClick();
                    return true;
                case Keys.F12:
                    B_Salir.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

    }
}
