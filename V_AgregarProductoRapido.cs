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
    public partial class V_AgregarProductoRapido : Form
    {
        public string Descripcion { get; private set; }
        public int Cantidad { get; private set; }
        public float PrecioUnitario { get; private set; }

        public DetalleVentaDTO NuevoProductoRapido { get; private set; }
        public V_AgregarProductoRapido()
        {
            InitializeComponent();
        }
        private string GenerarCodigoServicio()
        {
            // Puedes usar un contador incremental o un timestamp para asegurar que cada servicio tiene un código único
            return $"SERV-{DateTime.Now.Ticks}";
        }
        private void B_AgregarProductoRapido_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TB_Descripcion.Text) ||
                string.IsNullOrWhiteSpace(TB_PrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(TB_Cantidad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la cantidad y el precio sean valores numéricos válidos
            if (!int.TryParse(TB_Cantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(TB_PrecioVenta.Text, out float precioVenta) || precioVenta <= 0)
            {
                MessageBox.Show("Por favor, ingresa un precio de venta válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generar un código único para el producto rápido
            string codigoProductoRapido = GenerarCodigoServicio();

            // Crear el nuevo detalle de producto rápido
            NuevoProductoRapido = new DetalleVentaDTO
            {
                CodigoProducto = codigoProductoRapido,
                DescripcionProducto = TB_Descripcion.Text.Trim(),
                Cantidad = cantidad,
                PrecioUnitario = precioVenta,
                Total = cantidad * precioVenta
            };

            // Indicar que el formulario se cerró con éxito
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
    }
    

