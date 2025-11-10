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
            try
            {
                string nombreUsuario = TB_Usuario.Text.Trim();
                string contrasena = TB_PW.Text;

                // Hash SHA-256
                string contrasenaHasheada;
                using (var sha = System.Security.Cryptography.SHA256.Create())
                    contrasenaHasheada = BitConverter
                        .ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(contrasena)))
                        .Replace("-", "");

                using var context = new POSContext(new DbContextOptions<POSContext>());
                var loginService = new LoginService(context);
                var cortesService = new CortesService(context);

                // 1) Autenticar
                var usuario = loginService.AutenticarUsuario(nombreUsuario, contrasenaHasheada);
                if (usuario is null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2) Decidir si hay que pedir monto inicial
                bool tieneCorteAbierto = cortesService.ObtenerCorteNoRealizado(usuario.Id) != null;
                bool tieneMontoHoy = cortesService.ExisteMontoInicialHoy(usuario.Id);
                bool debePedirMonto = !(tieneCorteAbierto || tieneMontoHoy);

                bool montoInicialOk = true;
                if (debePedirMonto)
                {
                    using var frmMonto = new V_MontoInicial(usuario.Id, cortesService);
                    montoInicialOk = (frmMonto.ShowDialog(this) == DialogResult.OK);
                    if (!montoInicialOk) return; // canceló → no abrir menú
                }

                // 3) Abrir menú marcando el flag de “inicio de caja verificado”
                bool inicioCajaVerificado = !debePedirMonto || montoInicialOk;

                this.Hide();
                using var mainMenu = new menuPrincipal(usuario, inicioCajaVerificado);
                mainMenu.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al iniciar sesión:\n{ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
