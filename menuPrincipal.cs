using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Clientes;
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
           openChildForm(new V_menuProveedor(_usuarioActual.Id, CreateContext()));

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

        private void B_Inventario_Click(object sender, EventArgs e)
        {
            // Pasar el contexto al crear el formulario
            openChildForm(new V_menuInventario(_usuarioActual.Id, CreateContext()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Pasar el contexto al crear el formulario
            openChildForm(new V_menuUsuarios(CreateContext()));
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
             // Pasar el contexto al crear el formulario
            openChildForm(new V_menuUsuarios(CreateContext()));
        }

        private void B_NuevaCompra_Click(object sender, EventArgs e)
        {
           // Crear una nueva instancia de V_CreateCompra y pasar el ID del usuario actual
            openChildForm(new V_CreateCompra(_usuarioActual.Id));  // Asume que _usuarioActual tiene el ID del usuario
        }

        private void B_Compras_Click(object sender, EventArgs e)
        {
            
            // Pasar el contexto al crear el formulario
            openChildForm(new V_MenuCompras(_usuarioActual.Id, CreateContext()));
        }

        private void B_NuevaVenta_Click(object sender, EventArgs e)
        {
           
            openChildForm(new V_CreateVenta(_usuarioActual.Id));
        }

        private void B_Ventas_Click(object sender, EventArgs e)
        {
            
            openChildForm(new V_MenuVentas(_usuarioActual.Id, CreateContext()));
        }

        private void B_caja_Click(object sender, EventArgs e)
        {
           
            openChildForm(new V_menuEntradasEfectivo(_usuarioActual.Id, CreateContext()));
        }

        private void B_Cortes_Click(object sender, EventArgs e)
        {
           

            // Pasamos el usuario actual y el contexto al menú de cortes
            openChildForm(new V_MenuCortesCaja(_usuarioActual.Id, CreateContext()));
        }

        private void B_Gastos_Click(object sender, EventArgs e)
        {
           
            openChildForm(new V_MenuSalidasEfectivo(_usuarioActual.Id, CreateContext()));
        }

        private void B_Salir_Click(object sender, EventArgs e)
        {
            // logout: volver a login sin petatear la app
            var login = new V_LogIn();
            login.FormClosed += (_, __) => this.Close(); // cuando se cierre login, ya cerramos todo
            this.Hide();
            login.Show();
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
                botonClicado.BackColor = Color.FromArgb(53, 61, 71); // Color cuando se hace clic
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


        private void B_Clientes_Click(object sender, EventArgs e)
        {
            openChildForm(new V_MenuClientes(CreateContext()));
        }

        private static POSContext CreateContext()
        {
            // hoy no cambia nada; si mañana ajustas cadena de conexión o logging,
            // lo haces aquí y el resto del código ni se entera.
            return new POSContext(new DbContextOptions<POSContext>());
        }

    }
}
