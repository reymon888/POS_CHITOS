using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Avisos;
using POS_CHITOS.Usuarios;
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
        
            TB_Usuario.Text = "Administrador Chito's";
            TB_PW.Text = "1234";

            TB_Usuario.Focus();
            //centrar la ventana
            this.StartPosition = FormStartPosition.CenterScreen;
            //no cambiar tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ResumeLayout(false);


        }

        private void V_LogIn_Load(object sender, EventArgs e)
        {

        }

        private void B_Login_Click(object sender, EventArgs e)
        {
            string nombreUsuario = TB_Usuario.Text;
            string contrasena = TB_PW.Text;

            // Hashear la contraseña
            string contrasenaHasheada = BitConverter.ToString(SHA256.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(contrasena))).Replace("-", "");

            using (var context = new POSContext(new DbContextOptions<POSContext>()))
            {
                // Crear instancia de los servicios
                var loginService = new LoginService(context);
                var cortesService = new CortesService(context);

                // Autenticar el usuario
                var usuario = loginService.AutenticarUsuario(nombreUsuario, contrasenaHasheada);

                if (usuario != null)
                {
                    // Verificar si hay corte pendiente
                    if (cortesService.ObtenerCorteNoRealizado(usuario.Id) == null)
                    {
                        // Si no hay corte, abrir ventana para ingresar monto inicial
                        var formMontoInicial = new V_MontoInicial(usuario.Id, cortesService);
                        formMontoInicial.ShowDialog();
                    }

                    // Ocultar el formulario de login y abrir el menú principal
                    this.Hide();
                    var mainMenu = new menuPrincipal(usuario);
                    mainMenu.ShowDialog();
                    this.Close();
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
