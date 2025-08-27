using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class SalidaEfectivoDTO
    {
        public int idSalida { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public float Monto { get; set; }
        public string NombreUsuario { get; set; }
        public string Estado { get; set; }
    }
}
