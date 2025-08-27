using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS
{
    public partial class V_menuUsuarios : Form
    {
        readonly UsuarioService _usuarioService;
        int selectedIdUsuario;
        private BindingList<Usuario> bindingList;

        public V_menuUsuarios(POSContext context)
        {
            InitializeComponent();
            _usuarioService = new UsuarioService(context);

            mostrarUsuariosEnLaTabla();
        }

        private void B_AgregarUsuarios_Click(object sender, EventArgs e)
        {
            //llamar a la ventana de agregar usuarios
            V_Register REGISTRO = new V_Register();
            REGISTRO.ShowDialog();
            mostrarUsuariosEnLaTabla();

        }

        public void mostrarUsuariosEnLaTabla()
        {
            //Mostrar los usuarios en la tabla y dale nombre a las columnas y ajustarle el tamano a cada columna
            var usuarios = _usuarioService.listarUsuarios();
            DGV_Usuarios.DataSource = usuarios;

            formatotabla();

        }

        private void TB_BuscarUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void B_DarBajaUsuarios_Click(object sender, EventArgs e)
        {
            //desaCtivar o activar un usuario dependiendo de su estado actual
            var usuario = _usuarioService.listarUsuarios().Find(u => u.Id == selectedIdUsuario);
            if (usuario == null) return;

            if (usuario.Activo)
            {
                _usuarioService.DarDeBajaUsuario(selectedIdUsuario);
            }
            else
            {
                _usuarioService.ActivarUsuario(selectedIdUsuario);
            }

            mostrarUsuariosEnLaTabla();



        }

        private void DGV_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Obtener el ID del usuario seleccionado
            if (DGV_Usuarios.SelectedRows.Count > 0)
            {
                selectedIdUsuario = Convert.ToInt32(DGV_Usuarios.SelectedRows[0].Cells["Id"].Value);
                B_ModificarUsuarios.Enabled = true;
                B_CambiarEstadoUsuario.Enabled = true;
            }
            else
            {
                selectedIdUsuario = 0;
                B_ModificarUsuarios.Enabled = false;
                B_CambiarEstadoUsuario.Enabled = false;
            }
        }

        private void B_ActualizarTablaUsuarios_Click(object sender, EventArgs e)
        {
            mostrarUsuariosEnLaTabla();
        }

        private void TB_BuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            //buscar un usuario por su nombre y cuando este escribiendo en el textbox se actualiza la tabla
            var usuarios = _usuarioService.listarUsuarios().Where(u => u.NombreUsuario.Contains(TB_BuscarUsuario.Text)).ToList();
            DGV_Usuarios.DataSource = usuarios;

            formatotabla();


        }

        private void formatotabla()
        {
            if (DGV_Usuarios.Columns["Id"] != null)
                DGV_Usuarios.Columns["Id"].HeaderText = "ID";

            if (DGV_Usuarios.Columns["NombreUsuario"] != null)

                DGV_Usuarios.Columns["NombreUsuario"].HeaderText = "Nombre de Usuario";

            if (DGV_Usuarios.Columns["Rol"] != null)

                DGV_Usuarios.Columns["Rol"].HeaderText = "Rol";

            if (DGV_Usuarios.Columns["Activo"] != null)

                DGV_Usuarios.Columns["Activo"].HeaderText = "Activo";

            DGV_Usuarios.Columns["Contrasena"].Visible = false;

            DGV_Usuarios.Columns["Id"].Width = 180;

            DGV_Usuarios.Columns["NombreUsuario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DGV_Usuarios.Columns["Rol"].Width = 250;

            DGV_Usuarios.Columns["Activo"].Width = 220;


            //Comfigurar el contenido del header y las celdas en medio
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Usuarios.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            // Configurar la fuente de las celdas
            DGV_Usuarios.DefaultCellStyle.Font = new Font("Arial", 16);
            DGV_Usuarios.DefaultCellStyle.ForeColor = Color.Black;

            // Configurar el encabezado
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 18, FontStyle.Bold);
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;


            // Configurando el fondo y el color de texto de las celdas normales
            DGV_Usuarios.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Fondo blanco para las celdas
            DGV_Usuarios.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua

            // Configurando el fondo y el color de texto de los encabezados de las columnas
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro para los encabezados
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Texto blanco para los encabezados

            // Asegurando que la tabla no use colores predeterminados del sistema para garantizar la consistencia
            DGV_Usuarios.EnableHeadersVisualStyles = false;

            // Otras configuraciones visuales que podrías querer ajustar
            DGV_Usuarios.BorderStyle = BorderStyle.None; // Sin borde (opcional)
            DGV_Usuarios.GridColor = Color.FromArgb(200, 200, 200); // Color del grid ajustado para mejor contraste (opcional)
            DGV_Usuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Estilo del borde del encabezado

            //alternar colores de las filas una blanca y otra gris claro




            DGV_Usuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro para las filas alternas
            DGV_Usuarios.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua
            DGV_Usuarios.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 140, 153); // Fondo verde agua para la fila seleccionada

            // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
            DGV_Usuarios.EnableHeadersVisualStyles = false;  // Desactivar los estilos visuales del sistema para los encabezados
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro igual al normal
            DGV_Usuarios.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco igual al normal

        }

        private void B_ModificarUsuarios_Click(object sender, EventArgs e)
        {


            //Verificiar si hay una fila seleccionada en el DataGridView y obtener el id del usuario y pasarle el nombre de usuario y rol
            if (DGV_Usuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(DGV_Usuarios.SelectedRows[0].Cells["Id"].Value);
                string nombreUsuario = DGV_Usuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();
                string rol = DGV_Usuarios.SelectedRows[0].Cells["Rol"].Value.ToString();

                //Abrir el formulario para modificar el usuario
                var formModificarUsuario = new V_ModificarUsuario(idUsuario, nombreUsuario, rol, _usuarioService);
                formModificarUsuario.ShowDialog();

                //Recargar los usuarios después de modificar uno
                mostrarUsuariosEnLaTabla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void B_CambiarPW_Click(object sender, EventArgs e)
        {
            //Verificar si hay una fila seleccionada en el DataGridView y obtener el id del usuario
            if (DGV_Usuarios.SelectedRows.Count > 0)
            {
                int idUsuario = Convert.ToInt32(DGV_Usuarios.SelectedRows[0].Cells["Id"].Value);

                //Abrir el formulario para cambiar la contraseña
                var formCambiarPW = new V_CambiarPW(idUsuario, _usuarioService);
                formCambiarPW.ShowDialog();

                //Recargar los usuarios después de cambiar la contraseña
                mostrarUsuariosEnLaTabla();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para cambiar la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //metodo para atajos de teclado para los botones
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarUsuarios.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarUsuarios.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_CambiarEstadoUsuario.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.P))
            {
                B_CambiarPW.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTablaUsuarios.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarUsuario.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Usuarios.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
