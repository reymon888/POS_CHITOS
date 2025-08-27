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
    public partial class V_CreateProveedor : Form
    {
        private readonly ProveedoresService _proveedoresService;
        public V_CreateProveedor()
        {
            InitializeComponent();

            var context = new POSContext(new DbContextOptions<POSContext>());
            _proveedoresService = new ProveedoresService(context);

            TB_NombreProveedor.Focus();


            //Quitar el botón de maximizar
            this.MaximizeBox = false;
            //Quitar el botón de minimizar
            this.MinimizeBox = false;
            //Centrar la ventana
            this.CenterToScreen();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //Limitar la cantidad de caracteres en el campo de texto de numero de telefono a solo 10 




        private void B_CrearProveedor_Click(object sender, EventArgs e)
        {
            //Validar todos los campos, si escribio en correo electronico, validar que sea un correo electronico 
            if (TB_NombreProveedor.Text == "" || TB_TelefonoProveedor.Text == "" || TB_CEProveedor.Text == "" || TB_DireccionProveedor.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
            else
            {
                //Validar que el correo electronico sea un correo electronico
                if (TB_CEProveedor.Text.Contains("@") && TB_CEProveedor.Text.Contains(".com"))
                {
                    //Crear el proveedor
                    _proveedoresService.crearProveedor(TB_NombreProveedor.Text, TB_TelefonoProveedor.Text, TB_CEProveedor.Text, TB_DireccionProveedor.Text);
                    MessageBox.Show("Proveedor creado exitosamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un correo electronico valido");
                }
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

        private void TB_TelefonoProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Limitar la cantidad de numeros a solo 10
            if (TB_TelefonoProveedor.Text.Length == 10)
            {
                e.Handled = true;
            }
            else
            {
                //Solo permitir numeros
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void TB_NombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //permitir solo 100 caracteres en el campo de texto
            if (TB_NombreProveedor.Text.Length == 100)
            {
                e.Handled = true;
            }
        }

        private void TB_CEProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo 50 caracteres en el campo de texto
            if (TB_CEProveedor.Text.Length == 50)
            {
                e.Handled = true;
            }

        }

        private void TB_DireccionProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pERMITIR SOLO 100 CARACTERES EN EL CAMPO DE TEXTO
            if (TB_DireccionProveedor.Text.Length == 100)
            {
                e.Handled = true;
            }
        }
    }
}
