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
    public partial class V_DetallesCorteCaja : Form
    {
        private readonly CortesService _corteService;
        private readonly int _idCorte;
        public V_DetallesCorteCaja(int idCorte, CortesService corteService)
        {
            InitializeComponent();

            _idCorte = idCorte;
            _corteService = corteService;

            // Cargar los valores iniciales
            CargarTotales();
        }

        private void CargarTotales()
        {
            // Obtener las ventas realizadas y canceladas
            float totalVentasRealizadas = _corteService.ObtenerTotalVentasRealizadas(_idCorte);
            float totalVentasCanceladas = _corteService.ObtenerTotalVentasCanceladas(_idCorte);
            TB_TotalVentasRealizadas.Text = totalVentasRealizadas.ToString("C2");
            TB_TotalVentasCanceladas.Text = totalVentasCanceladas.ToString("C2");

            // Calcular el total neto de ventas
            float totalVentas = totalVentasRealizadas - totalVentasCanceladas;
            TB_TotalVentas.Text = totalVentas.ToString("C2");

            // Obtener las compras realizadas y canceladas
            float totalComprasRealizadas = _corteService.ObtenerTotalComprasRealizadas(_idCorte);
            float totalComprasCanceladas = _corteService.ObtenerTotalComprasCanceladas(_idCorte);
            TB_TotalComprasRealizadas.Text = totalComprasRealizadas.ToString("C2");
            TB_TotalComprasCanceladas.Text = totalComprasCanceladas.ToString("C2");

            // Calcular el total neto de compras
            float totalCompras = totalComprasRealizadas - totalComprasCanceladas;
            TB_TotalCompras.Text = totalCompras.ToString("C2");

            // Obtener las entradas de efectivo realizadas y canceladas
            float totalEntradasRealizadas = _corteService.ObtenerTotalEntradasRealizadas(_idCorte);
            float totalEntradasCanceladas = _corteService.ObtenerTotalEntradasCanceladas(_idCorte);
            TB_TotalEntradasEfectivoRealizadas.Text = totalEntradasRealizadas.ToString("C2");
            TB_TotalEntradasEfectivoCanceladas.Text = totalEntradasCanceladas.ToString("C2");

            // Calcular el total neto de entradas de efectivo
            float totalEntradasEfectivo = totalEntradasRealizadas - totalEntradasCanceladas;
            TB_TotalEntradasEfectivo.Text = totalEntradasEfectivo.ToString("C2");

            // Obtener las salidas de efectivo realizadas y canceladas
            float totalSalidasRealizadas = _corteService.ObtenerTotalSalidasRealizadas(_idCorte);
            float totalSalidasCanceladas = _corteService.ObtenerTotalSalidasCanceladas(_idCorte);
            TB_TotalSalidasEfectivoRealizadas.Text = totalSalidasRealizadas.ToString("C2");
            TB_TotalSalidasEfectivoCanceladas.Text = totalSalidasCanceladas.ToString("C2");

            // Calcular el total neto de salidas de efectivo
            float totalSalidasEfectivo = totalSalidasRealizadas - totalSalidasCanceladas;
            TB_TotalSalidasEfectivo.Text = totalSalidasEfectivo.ToString("C2");

            // Obtener el monto inicial del corte
            float montoInicial = _corteService.ObtenerMontoInicialCorte(_idCorte);
            TB_MontoInicial.Text = montoInicial.ToString("C2");

            // Calcular el monto final (con todos los ajustes de ventas, compras, entradas y salidas)
            float montoFinal = montoInicial + totalVentas + totalEntradasEfectivo - totalCompras - totalSalidasEfectivo;
            TB_MontoFinal.Text = montoFinal.ToString("C2");


        }
    }
}
