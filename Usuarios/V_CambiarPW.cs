using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Usuarios
{
    public partial class V_CambiarPW : Form
    {
        readonly UsuarioService _usuarioService;
        readonly int _idUsuario;
        public V_CambiarPW(int idUsuario, UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _idUsuario = idUsuario;

            // Configurar la ventana (opcional)
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void validarCambioContraseña()
        {
            // Verificar que los campos no estén vacíos
            if (TB_newPW.Text == "" || TB_newPW2.Text == "")
            {
                MessageBox.Show("Por favor ingrese y confirme la nueva contraseña.");
            }
            else if (TB_newPW.Text != TB_newPW2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
            }
            else
            {
                string nuevaContrasena = TB_newPW.Text;

                try
                {
                    // Llamar al servicio para cambiar la contraseña
                    _usuarioService.CambiarContrasena(_idUsuario, nuevaContrasena);

                    MessageBox.Show("Contraseña cambiada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();  // Cerrar el formulario
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cambiar la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            validarCambioContraseña();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            //Preguntar si desea cancelar el cambio de contraseña
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar el cambio de contraseña?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
