using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Categorias
{
    public partial class V_ModificarCategoriaInventario : Form
    {
        readonly CategoriaInventarioService _categoriaService;
        int _idCategoria;

        public V_ModificarCategoriaInventario(int idCategoria, string nombreCategoria, CategoriaInventarioService categoriaService)
        {
            InitializeComponent();
            _categoriaService = categoriaService;
            _idCategoria = idCategoria;
            TB_NombreCategoria.Text = nombreCategoria.Trim();
            //aparecer en el centro
            StartPosition = FormStartPosition.CenterScreen;
            //no se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;



        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            ModificarCategoria();
        }

        private void ModificarCategoria()
        {
            //Validar que el campo no esté vacío y registrar la categoria
            if (TB_NombreCategoria.Text != "")
            {
                _categoriaService.ModificarCategoria(_idCategoria, TB_NombreCategoria.Text);
                MessageBox.Show("Categoria modificada exitosamente", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_NombreCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            //Permitir solo 50 caracteres
            if (TB_NombreCategoria.Text.Length >= 50 && e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
