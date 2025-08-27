using Microsoft.EntityFrameworkCore;
//using POS_CHITOS.Proveedores;
using POS_CHITOS;
using POS_CHITOS.Usuarios;
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
    public partial class V_menuProveedor : Form
    {
        private readonly ProveedoresService _proveedoresService;
        private int selectedProveedorId;
        private BindingList<Proveedores> bindingList;
        private Usuario _usuarioActual;  // Usuario actual
        public V_menuProveedor(int idUsuario, POSContext context)
        {
            InitializeComponent();
            // Crear el contexto y el servicio

            _proveedoresService = new ProveedoresService(context);
            _usuarioActual = context.Usuarios.Find(idUsuario);
            // Cargar los proveedores
            CargarProveedores();


            B_ModificarProveedor.Enabled = false;
            B_DarBaja.Enabled = false;
            DGV_Proveedores.AllowUserToAddRows = false;  // Deshabilitar la última fila

            ConfigurarPermisos();
        }

        private void V_menuProveedor_Load(object sender, EventArgs e)
        {

        }

        // Método para configurar los permisos según el rol del usuario
        private void ConfigurarPermisos()
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // Deshabilitar los botones de modificar y cancelar ventas para el Cajero normal
                B_ModificarProveedor.Enabled = false;
                B_DarBaja.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void CargarProveedores()
        {
            try
            {
                var proveedores = _proveedoresService.listarProveedores();

                // Asignar el DataSource al DataGridView
                DGV_Proveedores.DataSource = proveedores;

                // Ocultar la columna "proveedoresInventario" si existe
                if (DGV_Proveedores.Columns["proveedoresInventario"] != null)
                {
                    DGV_Proveedores.Columns["proveedoresInventario"].Visible = false;
                }

                // Configurar los nombres de las columnas
                if (DGV_Proveedores.Columns["idProveedor"] != null)
                    DGV_Proveedores.Columns["idProveedor"].HeaderText = "ID";
                DGV_Proveedores.Columns["idProveedor"].Width = 120;

                if (DGV_Proveedores.Columns["NombreProveedor"] != null)
                    DGV_Proveedores.Columns["NombreProveedor"].HeaderText = "Nombre";
                DGV_Proveedores.Columns["NombreProveedor"].Width = 350;

                if (DGV_Proveedores.Columns["TelefonoProveedor"] != null)
                    DGV_Proveedores.Columns["TelefonoProveedor"].HeaderText = "Teléfono";
                DGV_Proveedores.Columns["TelefonoProveedor"].Width = 150;

                if (DGV_Proveedores.Columns["CorreoElectronico"] != null)
                    DGV_Proveedores.Columns["CorreoElectronico"].HeaderText = "Correo";
                DGV_Proveedores.Columns["CorreoElectronico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (DGV_Proveedores.Columns["DireccionProveedor"] != null)
                    DGV_Proveedores.Columns["DireccionProveedor"].HeaderText = "Dirección";
                DGV_Proveedores.Columns["DireccionProveedor"].Width = 350;

                if (DGV_Proveedores.Columns["Estado"] != null)
                    DGV_Proveedores.Columns["Estado"].HeaderText = "Estado";
                DGV_Proveedores.Columns["Estado"].Width = 130;

                // Configurar la fuente de las celdas
                DGV_Proveedores.DefaultCellStyle.Font = new Font("Arial", 14);

                // Configurar el encabezado
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);

                // Configurando el fondo y el color de texto de las celdas normales
                DGV_Proveedores.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Fondo blanco
                DGV_Proveedores.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua

                // Configurando el fondo y el color de texto de los encabezados de las columnas
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Texto blanco

                // Alternar colores de las filas
                DGV_Proveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro
                DGV_Proveedores.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua
                DGV_Proveedores.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 140, 153); // Fondo de selección

                // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
                DGV_Proveedores.EnableHeadersVisualStyles = false;
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro igual al normal
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco igual al normal

                //Poner en medio los headers de las columnas y las celdas
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DGV_Proveedores.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //Quitar los bordes de las celdas
                DGV_Proveedores.CellBorderStyle = DataGridViewCellBorderStyle.None;


                // No tener el DGV seleccionado inicialmente
                DGV_Proveedores.ClearSelection();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error al cargar los proveedores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void button2_Click(object sender, EventArgs e)
        {
            V_CreateProveedor createProveedor = new V_CreateProveedor();
            createProveedor.ShowDialog();
            CargarProveedores();

        }

        private void B_ActualizarProveedor_Click(object sender, EventArgs e)
        {
            CargarProveedores();
            DGV_Proveedores.ClearSelection();
            DGV_Proveedores.Refresh();  // Forzar el refresco visual del control

        }

        private void DGV_Proveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (_usuarioActual.Rol == "Cajero")
            {
                // No habilitar los botones si es cajero
                B_ModificarProveedor.Enabled = false;
                B_DarBaja.Enabled = false;
            }
            else
            {
                if (DGV_Proveedores.SelectedRows.Count > 0)
                {
                    selectedProveedorId = Convert.ToInt32(DGV_Proveedores.SelectedRows[0].Cells["idProveedor"].Value);
                    B_ModificarProveedor.Enabled = true;
                    B_DarBaja.Enabled = true;
                }
                else
                {
                    selectedProveedorId = 0;
                    B_ModificarProveedor.Enabled = false;
                    B_DarBaja.Enabled = false;
                }
            }
        }

        private void B_ModificarProveedor_Click(object sender, EventArgs e)
        {
            if (selectedProveedorId > 0)
            {
                V_UpdateProveedor UpdateProveedor = new V_UpdateProveedor(selectedProveedorId, _proveedoresService);
                UpdateProveedor.FormClosed += (s, args) => CargarProveedores();  // Recargar los datos después de cerrar el formulario
                UpdateProveedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TB_BuscarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            // Filtrar los proveedores por nombre pero que se vaya reduciendo la tabla conforme se escribe
            var proveedores = _proveedoresService.listarProveedores();
            var filteredProveedores = proveedores.Where(p => p.NombreProveedor.ToLower().Contains(TB_BuscarProveedor.Text.ToLower())).ToList();
            bindingList = new BindingList<Proveedores>(filteredProveedores);
            DGV_Proveedores.DataSource = bindingList;



        }

        private void B_DarBaja_Click(object sender, EventArgs e)
        {
            //Preguntar si quiere cambiar el estado del proveedor a inactivo o activo 
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cambiar el estado del proveedor?", "Cambiar estado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _proveedoresService.cambiarEstadoProveedor(selectedProveedorId);
                CargarProveedores();
            }

        }


        //Metodo de atajos para los botones que no sea keydown y sea con control al incio
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                button2.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarProveedor.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarProveedor.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_DarBaja.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.C))
            {
                B_catalogoProveedor.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                DGV_Proveedores.Focus();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarProveedor.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }



        private void B_catalogoProveedor_Click(object sender, EventArgs e)
        {
            // Obtener el proveedor seleccionado
            if (DGV_Proveedores.SelectedRows.Count > 0)
            {
                int idProveedor = (int)DGV_Proveedores.SelectedRows[0].Cells["IDProveedor"].Value;

                // Abrir la ventana de catálogo del proveedor
                V_CatalogoProveedor catalogoProveedor = new V_CatalogoProveedor(idProveedor);
                catalogoProveedor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
