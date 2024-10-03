using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class Proveedores
    {
        [Key]
        public int idProveedor { get; set; }

        [Column("nombre")]
        public string NombreProveedor { get; set; }

        [Column("telefono")]
        public string TelefonoProveedor { get; set; }

        [Column("correo_electronico")]
        public string CorreoElectronico { get; set; }

        [Column("direccion")]
        public string DireccionProveedor { get; set; }
    }
}
