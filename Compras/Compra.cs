using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS.Compras
{
    public class Compra
    {
        [Key]
        [Column("idCompra")]
        public int idCompra { get; set; }

        [ForeignKey("Proveedor")]
        public int idProveedor { get; set; }

        [ForeignKey("Usuario")]
        public int idUsuario { get; set; }

        public DateTime FechaCompra { get; set; }

        public float TotalCompra { get; set; }

        public virtual Proveedores Proveedor { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<DetalleCompra> DetallesCompras { get; set; }
        public string Estado { get; set; }

        public string FolioCompraOriginal { get; set; }  // Nuevo campo

        public int IdCorte { get; set; }  // Nuevo campo
    }

}
