using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POS_CHITOS.Usuarios;

namespace POS_CHITOS
{
    public class LoginService
    {
        private readonly POSContext _context;
        private readonly CortesService _cortesService;

        public LoginService(POSContext context)
        {
            _context = context;
        }

        public Usuario AutenticarUsuario(string nombreUsuario, string contrasenaHasheada)
        {
            return _context.Usuarios
                           .FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contrasena == contrasenaHasheada && u.Activo);
        }
    }
}

