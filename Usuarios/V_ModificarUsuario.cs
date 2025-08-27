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
    public partial class V_ModificarUsuario : Form
    {
        readonly UsuarioService _usuarioService;
        readonly int _idUsuario;
        public V_ModificarUsuario(int idUsuario, string nombreusuario, string rol, UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;  // Asignamos el servicio
            _idUsuario = idUsuario;  // Asignamos el id del usuario correctamente

            //Asignar los valores a los controles
            TB_newUser.Text = nombreusuario;
            configuracionCB();
            CB_Rol.Text = rol;

        }

        private void configuracionCB()
        {
            // Añadir las opciones del enumerado al ComboBox
            CB_Rol.Items.Add("Superadministrador");
            CB_Rol.Items.Add("Cajero");

            // Seleccionar el rol actual como opción por defecto
            CB_Rol.SelectedIndex = CB_Rol.Items.IndexOf(CB_Rol.Text);
        }

        private void validarModificacion()
        {
            // Validar que el campo del nombre de usuario no esté vacío
            if (TB_newUser.Text == "")
            {
                MessageBox.Show("Por favor ingrese un nombre de usuario.");
            }
            else
            {
                string nombreUsuario = TB_newUser.Text;
                string rol = CB_Rol.Text;

                try
                {
                    // Llamar al servicio para modificar el usuario
                    _usuarioService.ModificarUsuario(_idUsuario, nombreUsuario, rol);

                    MessageBox.Show("Usuario modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();  // Cerrar el formulario
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void B_RegistrarUsuario_Click(object sender, EventArgs e)
        {
            validarModificacion();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            // Preguntar al usuario si desea cancelar la modificación
            var respuesta = MessageBox.Show("¿Está seguro que desea cancelar la modificación del usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();  // Cerrar el formulario
            }

        }
    }
}
