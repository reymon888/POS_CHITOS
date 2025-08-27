using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.PI
{
    public class ProveedoresInventarioDTO
    {
        public int IdPI { get; set; }             // ID de la relación en ProveedoresInventario
        public string CodigoProducto { get; set; } // Código del producto
        public string DescripcionProducto { get; set; } // Nombre o descripción del producto
        public float PrecioCompra { get; set; } // Nullable float
        public string Estado { get; set; }         // Estado del producto en el catálogo (Activo/Inactivo)
    }
}
