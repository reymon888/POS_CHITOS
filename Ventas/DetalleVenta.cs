using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using POS_CHITOS.Inventario;

namespace POS_CHITOS.Ventas
{
    public class DetalleVenta
    {
        [Key]
        [Column("IdDetalleVenta")]
        public int IdDetalleVenta { get; set; }

        //[Column("FolioVenta")]
        public int FolioVenta { get; set; }
        public string CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }

        [ForeignKey("CodigoProducto")]
        public virtual inventario Inventario { get; set; }

        [ForeignKey("FolioVenta")]
        public virtual Venta Venta { get; set; }

        public string? DescripcionProducto { get; set; } // Nueva propiedad para productos varios
    }
}