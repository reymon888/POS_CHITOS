using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace POS_CHITOS
{
    public partial class V_LogIn : Form
    {
        public Usuario UsuarioAutenticado { get; private set; }

        public V_LogIn()
        {
            InitializeComponent();
        
            TB_Usuario.Text = "Ramon";
            TB_PW.Text = "1234";

            TB_Usuario.Focus();

        }

        private void V_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TB_Usuario.Text;
            string contrasena = TB_PW.Text;

            // Hashear la contraseña para compararla con la base de datos
            string contrasenaHasheada = BitConverter.ToString(
                SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(contrasena))
            ).Replace("-", "");

            using (var context = new POSContext(new DbContextOptions<POSContext>()))
            {
                // Verificar si el usuario existe con la contraseña correcta y está activo
                var usuario = context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contrasena == contrasenaHasheada);

                if (usuario != null && usuario.Activo)
                {
                    // Ocultar el formulario de login, no lo cierres
                    this.Hide();

                    // Abrir el menú principal
                    var mainMenu = new menuPrincipal(usuario);

                    // Mostrar el menú principal de forma modal
                    mainMenu.ShowDialog();

                    // Una vez que el menú principal se cierre, cerrar el formulario de login
                    this.Close();
                }
                else if (usuario != null && !usuario.Activo)
                {
                    MessageBox.Show("El usuario está desactivado, contacta al administrador.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TB_PW_KeyDown(object sender, KeyEventArgs e)
        {
            //precionar enter para logear
            if (e.KeyCode == Keys.Enter)
            {
                B_Login_Click(sender, e);
            }
        }

        private void B_Registrarse_Click(object sender, EventArgs e)
        {


        }

     

        private void label_NewUsuario_Click(object sender, EventArgs e)
        {
            V_Register registrarse = new V_Register();
            registrarse.ShowDialog();

        }
    }
}
