using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS
{
    public partial class V_Register : Form
    {
        public V_Register()
        {
            InitializeComponent();
            configuracionCB();
        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void configuracionCB()
        {
            // Añadir las opciones del enumerado al ComboBox
            CB_Rol.Items.Add("superadmin");
            CB_Rol.Items.Add("admin");
            CB_Rol.Items.Add("trabajador");

            // Seleccionar una opción por defecto (opcional)
            CB_Rol.SelectedIndex = 0;

        }

        private void B_RegistrarUsuario_Click(object sender, EventArgs e)
        {
           validarRegistro();
        }

       
        private void validarRegistro()
        {
            //metodo para validar que los campos no esten vacios y que la contraseña de TB_newPW y TB_newPW2 sean iguales
            if (TB_newUser.Text == "" || TB_newPW.Text == "" || TB_newPW2.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                if (TB_newPW.Text != TB_newPW2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
                else
                {
                    string newUsuario = TB_newUser.Text;
                    string newRol = CB_Rol.Text;
                    string newPW = TB_newPW.Text;

                    using (var context = new POSContext(new DbContextOptions<POSContext>()))
                    {
                        var usuarioService = new UsuarioService(context);

                        try
                        {
                            // Crear el nuevo usuario
                            usuarioService.CrearUsuario(newUsuario, newRol, newPW);

                            MessageBox.Show("Usuario creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
    }


    }
}
