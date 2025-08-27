using Microsoft.EntityFrameworkCore;
//using POS_CHITOS.Proveedores;
using POS_CHITOS;
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
            //aparecer en el centro
            StartPosition = FormStartPosition.CenterScreen;

            //no se puede cambiar el tamaño de la ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;


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
            //Si escribio en la caja de correo, validar que sea un correo
            if (TB_NombreProveedor.Text == "" || TB_TelefonoProveedor.Text == "" || TB_CEProveedor.Text == "" || TB_DireccionProveedor.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                //Validar que el correo electronico sea un correo electronico
                if (TB_CEProveedor.Text.Contains("@") && TB_CEProveedor.Text.Contains(".com"))
                {
                    //Modificar el proveedor
                    _proveedoresService.modificarProveedor(_idProveedor, TB_NombreProveedor.Text, TB_TelefonoProveedor.Text, TB_CEProveedor.Text, TB_DireccionProveedor.Text);
                    MessageBox.Show("Proveedor modificado exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo electrónico inválido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TB_NombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo 100 caracteres
            if (TB_NombreProveedor.Text.Length == 100)
            {
                e.Handled = true;
            }
        }

        private void TB_TelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo 10 caracteres y puro numero
            if (TB_TelefonoProveedor.Text.Length == 10 || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TB_CEProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir 50 caracteres 
            if (TB_CEProveedor.Text.Length == 50)
            {
                e.Handled = true;
            }
        }

        private void TB_DireccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir 100 caracteres
            if (TB_DireccionProveedor.Text.Length == 100)
            {
                e.Handled = true;
            }
        }
    }
}
