using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_CHITOS.Inventario;

namespace POS_CHITOS.PI
{
    public class ProveedoresInventario
    {
        [Key]
        [Column("idPI")]
        public int IdPI { get; set; }

        [Column("idProveedor")]
        public int IdProveedor { get; set; }

        [Column("codigoProducto")]
        public string CodigoProducto { get; set; }

        [Column("PrecioCompra")]
        public float PrecioCompra { get; set; }

        [Column("estado")]
        public string Estado { get; set; } // Enum o string según tu diseño

        // Relaciones
        public virtual Proveedores Proveedor { get; set; }
        public virtual inventario Producto { get; set; } // Relación con Inventario

    }
}
