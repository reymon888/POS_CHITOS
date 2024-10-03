using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class CortesCaja
    {
        public int IdCorte { get; set; } // Identificador del corte
        public DateTime Fecha { get; set; } // Fecha del corte
        public int IdUsuario { get; set; } // Usuario que realizó el corte
        public float MontoInicio { get; set; } // Monto inicial del corte
        public float TotalVentas { get; set; } = 0; // Total de ventas registradas en el corte
        public float TotalCompras { get; set; } = 0; // Total de compras durante el corte
        public float TotalEntradas { get; set; } = 0; // Total de entradas de efectivo adicionales
        public float TotalSalidas { get; set; } = 0; // Total de salidas de efectivo
        public string EstadoCorte { get; set; } = "No Realizado"; // Estado del corte

        // Relación con la entidad Usuarios
        public Usuario Usuario { get; set; }
    }
}
