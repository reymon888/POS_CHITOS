using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_CHITOS.Inventario;

namespace POS_CHITOS.Compras
{
    public class DetalleCompra
    {
        [Key]
        public int idDetalleCompra { get; set; }

        [ForeignKey("Compra")]
        public int idCompra { get; set; }

        [ForeignKey("Inventario")]
        public string CodigoProducto { get; set; }

        public int Cantidad { get; set; }

        public float PrecioUnitario { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual inventario Inventario { get; set; }
    }

}
