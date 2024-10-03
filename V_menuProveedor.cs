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
    public partial class V_menuProveedor : Form
    {
        private readonly ProveedoresService _proveedoresService;
        private int selectedProveedorId;
        private BindingList<Proveedores> bindingList;
        public V_menuProveedor(POSContext context)
        {
            InitializeComponent();
            // Crear el contexto y el servicio
           
            _proveedoresService = new ProveedoresService(context);

            // Cargar los proveedores
            CargarProveedores();


            B_ModificarProveedor.Enabled = false;
            B_DarBaja.Enabled = false;





        }

        private void V_menuProveedor_Load(object sender, EventArgs e)
        {

        }

   

        private void CargarProveedores()
        {
            try
            {
                var proveedores = _proveedoresService.listarProveedores();

                // Usa una BindingList para facilitar el refresco automático
               
                DGV_Proveedores.DataSource = proveedores;

                // Configurar los nombres de las columnas
                if (DGV_Proveedores.Columns["idProveedor"] != null)
                    DGV_Proveedores.Columns["idProveedor"].HeaderText = "ID Proveedor";
                    DGV_Proveedores.Columns["idProveedor"].Width = 120;

                if (DGV_Proveedores.Columns["NombreProveedor"] != null)
                    DGV_Proveedores.Columns["NombreProveedor"].HeaderText = "Nombre";
                    DGV_Proveedores.Columns["NombreProveedor"].Width = 350;

                if (DGV_Proveedores.Columns["TelefonoProveedor"] != null)
                    DGV_Proveedores.Columns["TelefonoProveedor"].HeaderText = "Teléfono";
                    DGV_Proveedores.Columns["TelefonoProveedor"].Width = 150;

                if (DGV_Proveedores.Columns["CorreoElectronico"] != null)
                    DGV_Proveedores.Columns["CorreoElectronico"].HeaderText = "Correo Electrónico";
                    DGV_Proveedores.Columns["CorreoElectronico"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                if (DGV_Proveedores.Columns["DireccionProveedor"] != null)
                    DGV_Proveedores.Columns["DireccionProveedor"].HeaderText = "Dirección";
                    DGV_Proveedores.Columns["DireccionProveedor"].Width = 350;

                // Configurar la fuente de las celdas
                DGV_Proveedores.DefaultCellStyle.Font = new Font("Arial", 14);




                // Configurar el encabezado
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
                // Configurando el fondo y el color de texto de las celdas normales
                DGV_Proveedores.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255); // Fondo blanco para las celdas
                DGV_Proveedores.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua

                // Configurando el fondo y el color de texto de los encabezados de las columnas
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro para los encabezados
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255); // Texto blanco para los encabezados

                // Asegurando que la tabla no use colores predeterminados del sistema para garantizar la consistencia
                DGV_Proveedores.EnableHeadersVisualStyles = false;

                // Otras configuraciones visuales que podrías querer ajustar
                DGV_Proveedores.BorderStyle = BorderStyle.None; // Sin borde (opcional)
                DGV_Proveedores.GridColor = Color.FromArgb(200, 200, 200); // Color del grid ajustado para mejor contraste (opcional)
                DGV_Proveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // Estilo del borde del encabezado

                //alternar colores de las filas una blanca y otra gris claro




                DGV_Proveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // Fondo gris claro para las filas alternas
                DGV_Proveedores.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153); // Texto verde agua
                DGV_Proveedores.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(44, 140, 153); // Fondo verde agua para la fila seleccionada

                // Configuración para que los encabezados no cambien de estilo al seleccionar celdas
                DGV_Proveedores.EnableHeadersVisualStyles = false;  // Desactivar los estilos visuales del sistema para los encabezados
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51); // Fondo gris oscuro igual al normal
                DGV_Proveedores.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255); // Texto blanco igual al normal

                // No tener el DGV seleccionado
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
            // Dar de baja a un proveedor seleccionado
            if (selectedProveedorId > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea dar de baja a este proveedor?", "Dar de baja", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _proveedoresService.eliminarProveedor(selectedProveedorId);
                    MessageBox.Show("Proveedor dado de baja exitosamente");
                    CargarProveedores();
                    bindingList.ResetBindings();  // Forzar el refresco de la lista
                    DGV_Proveedores.ClearSelection();  // Limpiar la selección después de recargar
                }
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor para dar de baja.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
