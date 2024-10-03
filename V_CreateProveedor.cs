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
    public partial class V_CreateProveedor : Form
    {
        private readonly ProveedoresService _proveedoresService;
        public V_CreateProveedor()
        {
            InitializeComponent();

            var context = new POSContext(new DbContextOptions<POSContext>());
            _proveedoresService = new ProveedoresService(context);

            TB_NombreProveedor.Focus();
        }

        private void B_CrearProveedor_Click(object sender, EventArgs e)
        {
            //validar que los campos excepto correo electronico este lleno y cree al proveedor

            if (TB_NombreProveedor.Text != "" && TB_TelefonoProveedor.Text != "" && TB_DireccionProveedor.Text != "")
            {
                _proveedoresService.crearProveedor(TB_NombreProveedor.Text, TB_TelefonoProveedor.Text, TB_CEProveedor.Text, TB_DireccionProveedor.Text);
                MessageBox.Show("Proveedor creado exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }



        }

        private void B_Cancelar_Click(object sender, EventArgs e)
        {
            //Si tiene contenido en los campos, preguntar si desea cancelar
            if (TB_NombreProveedor.Text != "" || TB_TelefonoProveedor.Text != "" || TB_CEProveedor.Text != "" || TB_DireccionProveedor.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }


        }
    }
}
