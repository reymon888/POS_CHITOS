using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public static class Session
    {
        public static int UserId { get; set; }  // ID del usuario logeado
        public static string UserName { get; set; }  // Nombre completo del usuario logeado
    }
}
