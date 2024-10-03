using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace POS_CHITOS
{
    public partial class menuPrincipal : Form
    {
        private Form activeForm;
        private Usuario _usuarioActual;

        public menuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            // empiece en pantalla completa 
            this.WindowState = FormWindowState.Maximized;


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
            openChildForm(new V_menuProveedor(context));



        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(childForm);
            panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void menuSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void B_Inventario_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia de POSContext
            var context = new POSContext(new DbContextOptions<POSContext>());

            // Pasar el contexto al crear el formulario
            openChildForm(new V_menuInventario(context));
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
            openChildForm(new V_MenuCompras(context));
        }

        private void B_NuevaVenta_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_CreateVenta(_usuarioActual.Id));
        }

        private void B_Ventas_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_MenuVentas(context));
        }

        private void B_caja_Click(object sender, EventArgs e)
        {
            var context = new POSContext(new DbContextOptions<POSContext>());
            openChildForm(new V_menuEntradasEfectivo(_usuarioActual.Id,context));
        }
    }
}
