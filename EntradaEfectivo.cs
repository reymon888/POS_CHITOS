using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class EntradaEfectivo
    {
        [Key]
        public int idEntrada { get; set; }

        public DateTime Fecha { get; set; }

        public string Concepto { get; set; }

        public float Monto { get; set; }

        public string Estado { get; set; } = "Realizado";  // Valor por defecto "Realizado"

        public int idUsuario { get; set; }

        [ForeignKey("idUsuario")]
        public Usuario Usuario { get; set; }

        public int idCorte { get; set; } = 1;  // Asignar un valor por defecto 1 mientras no se maneje cortes dinámicos

        [ForeignKey("idCorte")]
        public CortesCaja CorteCaja { get; set; }
    }
}
