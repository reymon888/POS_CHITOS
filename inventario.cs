using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class inventario
    {
        [Key]
        [Column("CodigoProducto")]
        public string CodigoProducto { get; set; }

        [Column("DescripcionProducto")]
        public string DescripcionProducto { get; set; }

        [Column("Stock")]
        public int Stock { get; set; }

        [Column("PrecioVenta")]
        public float PrecioVenta { get; set; }

        [Column("PrecioCompra")]
        public float PrecioCompra { get; set; }

        [Column("Estante")]
        public string Estante { get; set; }
    }
}
