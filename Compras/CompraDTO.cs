using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace POS_CHITOS.Compras
{
    public class CompraDTO
    {
        [Key]
        [Column("idCompra")]
        public int idCompra { get; set; }

        public string FolioCompraOriginal { get; set; }  // Nuevo campo
        public string NombreProveedor { get; set; }
        public string NombreUsuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public float TotalCompra { get; set; }
        public string Estado { get; set; }

        public string EstadoCorte { get; set; } // Nueva propiedad para el estado del corte


    }

}