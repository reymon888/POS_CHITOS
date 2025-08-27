using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Usuarios
{
    public class Usuario
    {
        public int Id { get; set; }

        [Column("nombre_usuario")]
        public string NombreUsuario { get; set; }

        [Column("contrasena")]
        public string Contrasena { get; set; }

        [Column("rol")]
        public string Rol { get; set; }

        [Column("activo")]
        public bool Activo { get; set; }  // Nueva columna para marcar si el usuario está activo

        // Relación inversa con CortesCaja
        //public List<CortesCaja> CortesCajas { get; set; }
    }
}
