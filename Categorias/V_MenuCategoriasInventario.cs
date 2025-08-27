using POS_CHITOS.Categorias;
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
    public partial class V_MenuCategoriasInventario : Form
    {
        private readonly CategoriaInventarioService _categoriaService;
        public V_MenuCategoriasInventario(CategoriaInventarioService categoriaService)
        {
            InitializeComponent();

            _categoriaService = categoriaService;
            //aparecer en el centro
            StartPosition = FormStartPosition.CenterScreen;

            //no se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            B_ModificarCategoria.Enabled = false;
            B_CambiarEstado.Enabled = false;
            // Suscribir el evento SelectionChanged
            DGV_CategoriasInventario.SelectionChanged += DGV_CategoriasInventario_SelectionChanged;
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                // Obtener las categorías desde el servicio
                var categorias = _categoriaService.ObtenerCategorias();

                // Limpiar el DataSource antes de volver a asignar
                DGV_CategoriasInventario.DataSource = null;
                DGV_CategoriasInventario.AutoGenerateColumns = false; // Deshabilitar generación automática

                // Limpiar columnas existentes
                DGV_CategoriasInventario.Columns.Clear();

                // Crear columnas personalizadas
                DGV_CategoriasInventario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "IdCategoria",
                    HeaderText = "ID",
                    DataPropertyName = "IdCategoria",
                    Width = 150
                });

                DGV_CategoriasInventario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "NombreCategoria",
                    HeaderText = "Nombre",
                    DataPropertyName = "NombreCategoria",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

                DGV_CategoriasInventario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Estado",
                    HeaderText = "Estado",
                    DataPropertyName = "Estado",
                    Width = 200
                });

                // Asignar el DataSource
                DGV_CategoriasInventario.DataSource = categorias;

                // Aplicar estilo personalizado
                ConfigurarEstiloTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para configurar el estilo de la tabla
        private void ConfigurarEstiloTabla()
        {
            // Aplicar el mismo estilo de colores y formato que has estado utilizando
            DGV_CategoriasInventario.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            DGV_CategoriasInventario.DefaultCellStyle.Font = new Font("Arial", 14);
            DGV_CategoriasInventario.DefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_CategoriasInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(51, 51, 51);
            DGV_CategoriasInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(255, 255, 255);
            DGV_CategoriasInventario.EnableHeadersVisualStyles = false;
            DGV_CategoriasInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            DGV_CategoriasInventario.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 140, 153);
            DGV_CategoriasInventario.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 51, 51);
            DGV_CategoriasInventario.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
            DGV_CategoriasInventario.ClearSelection();

            // Poner el contenido de la tabla en medio
            DGV_CategoriasInventario.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_CategoriasInventario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_CategoriasInventario.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGV_CategoriasInventario.RowHeadersVisible = false;
        }



        //Si tengo seleccionado un producto tomar id y activar botones
        private void DGV_CategoriasInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                B_ModificarCategoria.Enabled = true;
                B_CambiarEstado.Enabled = true;
            }
        }

        private void B_ModificarCategoria_Click(object sender, EventArgs e)
        {
            //Si tengo seleccionado una categoria tomar id y abrir el formulario para modificar la categoria
            if (DGV_CategoriasInventario.SelectedRows.Count > 0)
            {

                var idCategoria = Convert.ToInt32(DGV_CategoriasInventario.SelectedRows[0].Cells["IdCategoria"].Value);
                var nombreCategoria = DGV_CategoriasInventario.SelectedRows[0].Cells["NombreCategoria"].Value.ToString().Trim();
                var modificarCategoriaForm = new V_ModificarCategoriaInventario(idCategoria, nombreCategoria, _categoriaService);
                modificarCategoriaForm.ShowDialog();
                CargarCategorias();

               

            }

        }

        private void B_CambiarEstado_Click(object sender, EventArgs e)
        {
            //Cambiar el estado de la categoria seleccionada de Habilitado a Deshabilitado y vicerversa y preguntar si esta seguro
            if (DGV_CategoriasInventario.SelectedRows.Count > 0)
            {
                var idCategoria = Convert.ToInt32(DGV_CategoriasInventario.SelectedRows[0].Cells["IdCategoria"].Value);
                var nombreCategoria = DGV_CategoriasInventario.SelectedRows[0].Cells["NombreCategoria"].Value.ToString();
                var estadoCategoria = DGV_CategoriasInventario.SelectedRows[0].Cells["Estado"].Value.ToString();
                var mensaje = $"¿Está seguro que desea cambiar el estado de la categoría {nombreCategoria} de {estadoCategoria} a ";
                var nuevoEstado = estadoCategoria == "Habilitado" ? "Deshabilitado" : "Habilitado";
                mensaje += $"{nuevoEstado}?";

                var confirmacion = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    _categoriaService.CambiarEstadoCategoria(idCategoria, nuevoEstado);
                    CargarCategorias();
                }
            }


        }

        private void B_ActualizarTabla_Click(object sender, EventArgs e)
        {

        }

        private void DGV_CategoriasInventario_SelectionChanged(object sender, EventArgs e)
        {
            // Si hay alguna fila seleccionada, activamos los botones
            if (DGV_CategoriasInventario.SelectedRows.Count > 0)
            {
                B_ModificarCategoria.Enabled = true;
                B_CambiarEstado.Enabled = true;
            }
            else
            {
                // Si no hay ninguna fila seleccionada, desactivamos los botones
                B_ModificarCategoria.Enabled = false;
                B_CambiarEstado.Enabled = false;
            }
        }

        private void B_AgregarCategoriaInventario_Click(object sender, EventArgs e)
        {
            //Abrir el formulario para agregar una categoria
            var agregarCategoriaForm = new V_AgregarCategoriaInventario(_categoriaService);
            agregarCategoriaForm.ShowDialog();
            CargarCategorias();
        }

        private void TB_BuscarCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            //Cada que escriba en el textbox filtrar las categorias que coincidan con el texto y si borro todo volver a cargar todas las categorias
            if (TB_BuscarCategoria.Text != "")
            {
                var categorias = _categoriaService.ObtenerCategorias().Where(c => c.NombreCategoria.ToLower().Contains(TB_BuscarCategoria.Text.ToLower())).ToList();
                DGV_CategoriasInventario.DataSource = categorias;
            }
            else
            {
                CargarCategorias();
            }
    }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {

            //Metodo para los atajos de teclado con control para los botones
            if (keyData == (Keys.Control | Keys.N))
            {
                B_AgregarCategoriaInventario.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.M))
            {
                B_ModificarCategoria.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.B))
            {
                B_CambiarEstado.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                B_ActualizarTabla.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                TB_BuscarCategoria.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
}
