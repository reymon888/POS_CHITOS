using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS.Ventas
{
    public class Venta
    {
        [Key]
        [Column("FolioVenta")]
        public int FolioVenta { get; set; }

        [Column("FechaVenta")]
        public DateTime FechaVenta { get; set; }

        [Column("TotalVenta")]
        public float TotalVenta { get; set; }

        [Column("PagoRecibido")]
        public float PagoRecibido { get; set; }  // Nuevo campo para el pago recibido

        [Column("Cambio")]
        public float Cambio { get; set; }        // Nuevo campo para el cambio

        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]

        public Usuario Usuario { get; set; }

        public virtual ICollection<DetalleVenta> DetallesVenta { get; set; }

        [ForeignKey("IdCorte")]
        [Column("IdCorte")]
        public int IdCorte { get; set; }

        [Column("Estado")]
        public string Estado { get; set; }



    }
}
