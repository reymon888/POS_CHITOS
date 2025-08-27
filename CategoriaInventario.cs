using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_CHITOS.Inventario;

namespace POS_CHITOS
{
    public class CategoriaInventario
    {
        [Key]
        [Column("IdCategoria")]
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Estado { get; set; } = "Habilitado";

        // Relación con Inventario
        public virtual ICollection<inventario> Inventario { get; set; }
    }

}
