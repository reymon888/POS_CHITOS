using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Clientes
{
    [Table("clientes")]
    public class clientes
    {
        [Key, Column("id_cliente")] public int IdCliente { get; set; }
        [Column("nombre")] public string Nombre { get; set; }
        [Column("telefono")] public string Telefono { get; set; }
        [Column("rfc")] public string RFC { get; set; }
        [Column("direccion")] public string Direccion { get; set; }
        [Column("activo")] public bool Activo { get; set; } = true;
    }
}
