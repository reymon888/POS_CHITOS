using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Clientes
{
    public class ClientesDTO
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string RFC { get; set; }
        public string Direccion { get; set; }
        public string Estado { get; set; } // "Habilitado"/"Deshabilitado"
    }

    public class ClienteComboDTO
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
    }
}
