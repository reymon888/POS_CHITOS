using POS_CHITOS.Compras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_CHITOS.Reportes
{
    public partial class V_MenuReportes : Form
    {

        public V_MenuReportes()
        {
            InitializeComponent();
        }

        private void B_NuevaVenta_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de reporte de ventas
            V_ReporteVentas reporteVentas = new V_ReporteVentas();
            reporteVentas.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de reporte de compras y enviarle el servicio de compras
            V_ReporteCompras reporteCompras = new V_ReporteCompras();
            reporteCompras.Show();




        }

        private void B_ReporteInventario_Click(object sender, EventArgs e)
        {
            V_ReporteInventario reporteInventario = new V_ReporteInventario();
            reporteInventario.Show();
        }

        private void B_ReporteIngresos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de reporte de ingresos
            V_ReporteIngresos reporteIngresos = new V_ReporteIngresos();
            reporteIngresos.Show();

        }

        private void B_ReporteGastos_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de reporte de gastos
            V_ReporteGastos reporteGastos = new V_ReporteGastos();
            reporteGastos.Show();
        }

        //metodo para abrir los botones con comandos que no sea keydown
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.V))
            {
                B_NuevaVenta.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.C))
            {
                button1.PerformClick();
                return true;
            }
            if (keyData == (Keys.Control | Keys.P))
            {
                B_ReporteInventario.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.I))
            {
                B_ReporteIngresos.PerformClick();
                return true;
            }

            if (keyData == (Keys.Control | Keys.G))
            {
                B_ReporteGastos.Focus();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
