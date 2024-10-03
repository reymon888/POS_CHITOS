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
    public partial class V_UpdateProveedor : Form
    {
        private readonly ProveedoresService _proveedoresService;
        private readonly int _idProveedor;
        public V_UpdateProveedor(int idProveedor, ProveedoresService proveedoresService)
        {
            InitializeComponent();
            
            
            _proveedoresService = proveedoresService;
            _idProveedor = idProveedor;
            TB_NombreProveedor.Focus();

            CargarDatosProveedor();
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

        private void B_CrearProveedor_Click(object sender, EventArgs e)
        {
            if (TB_NombreProveedor.Text != "" && TB_TelefonoProveedor.Text != "" && TB_DireccionProveedor.Text != "")
            {
                _proveedoresService.modificarProveedor(_idProveedor, TB_NombreProveedor.Text, TB_TelefonoProveedor.Text, TB_CEProveedor.Text, TB_DireccionProveedor.Text);
                MessageBox.Show("Proveedor modificado exitosamente");
                this.DialogResult = DialogResult.OK;
                this.Close();  // Asegúrate de que el formulario se cierra después de guardar los cambios
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
        }


        private void CargarDatosProveedor()
        {
            var proveedor = _proveedoresService.ObtenerProveedorPorId(_idProveedor); // Método para obtener datos, no modificar
            if (proveedor != null)
            {
                TB_NombreProveedor.Text = proveedor.NombreProveedor;
                TB_TelefonoProveedor.Text = proveedor.TelefonoProveedor;
                TB_CEProveedor.Text = proveedor.CorreoElectronico;
                TB_DireccionProveedor.Text = proveedor.DireccionProveedor;
            }
            else
            {
                MessageBox.Show("No se encontró el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
