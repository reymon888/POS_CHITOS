using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS.Ventas
{
    [Table("ventas")] // opcional si tu tabla se llama distinto
    public class Venta
    {
        [Key]
        [Column("FolioVenta")]
        public int FolioVenta { get; set; }

        [Column("FechaVenta")]
        public DateTime FechaVenta { get; set; }  // DEFAULT CURRENT_TIMESTAMP en DB

        [Column("TotalVenta")]
        public float TotalVenta { get; set; }

        [Column("MetodoPago")]
        public string MetodoPago { get; set; } = "EFECTIVO"; // ENUM en DB

        [Column("ReferenciaPago")]
        public string? ReferenciaPago { get; set; }

        [Column("PagoRecibido")]
        public float PagoRecibido { get; set; } = 0f;

        [Column("Cambio")]
        public float Cambio { get; set; } = 0f;

        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        public Usuario Usuario { get; set; } = null!;

        // Corte puede ser NULL en la tabla → propiedad nullable
        [Column("IdCorte")]
        public int? IdCorte { get; set; }

        // Si tienes entidad Corte, puedes agregar la navegación:
        // [ForeignKey(nameof(IdCorte))]
        // public Corte? Corte { get; set; }

        [Column("PlacaCarro")]
        public string? PlacaCarro { get; set; }

        [Column("Estado")]
        public string Estado { get; set; } = "Realizada";  // ENUM('Realizada','Cancelada','EnEspera','Pagada')

        // Detalle
        public virtual ICollection<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
    }
}
