using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Inventario
{
    public class InventarioDTO
    {
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int Stock { get; set; }
        public float PrecioVenta { get; set; }
        public float PrecioCompra { get; set; }
        public string Estante { get; set; }
        public string Estado { get; set; }
        public string NombreCategoria { get; set; }  // Nombre de la categoría
    }

}
