using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Usuarios
{
    public class UsuarioService
    {
        private readonly POSContext _context;

        public UsuarioService(POSContext context)
        {
            _context = context;
        }

        // Método para crear un nuevo usuario
        public void CrearUsuario(string nombreUsuario, string rol, string contrasena)
        {
            // Hashear la contraseña
            string contrasenaHasheada = BitConverter.ToString(
                SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(contrasena))
            ).Replace("-", "");

            var nuevoUsuario = new Usuario
            {
                NombreUsuario = nombreUsuario,
                Rol = rol,
                Contrasena = contrasenaHasheada
            };

            _context.Usuarios.Add(nuevoUsuario);
            _context.SaveChanges();
        }


        // Método para obtener todos los usuarios
        public List<Usuario> listarUsuarios()
        {
            return _context.Usuarios.ToList();
        }



       
        // Método para modificar un usuario sin cambiar la contraseña
        public void ModificarUsuario(int id, string nombreUsuario, string rol)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario != null)
            {
                usuario.NombreUsuario = nombreUsuario;  // Modificar el nombre de usuario
                usuario.Rol = rol;  // Modificar el rol

                _context.SaveChanges();  // Guardar los cambios
            }
            else
            {
                throw new Exception("El usuario no fue encontrado.");
            }
        }


        // Método para eliminar un usuario
        public void EliminarUsuario(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }

        public void DarDeBajaUsuario(int userId)
        {
            var usuario = _context.Usuarios.Find(userId);
            if (usuario != null)
            {
                usuario.Activo = false;  // Cambiar a inactivo
                _context.SaveChanges();
            }
        }

        public void ActivarUsuario(int userId)
        {
            var usuario = _context.Usuarios.Find(userId);
            if (usuario != null)
            {
                usuario.Activo = true;  // Cambiar a activo
                _context.SaveChanges();
            }
        }

        public string ObtenerNombreUsuarioPorId(int idUsuario)
        {
            var usuario = _context.Usuarios.FirstOrDefault(u => u.Id == idUsuario);
            return usuario != null ? usuario.NombreUsuario : "Usuario no encontrado";
        }

        // Método para cambiar la contraseña de un usuario
        public void CambiarContrasena(int id, string nuevaContrasena)
        {
            var usuario = _context.Usuarios.Find(id);

            if (usuario != null)
            {
                // Convertir la contraseña en hash usando SHA256
                usuario.Contrasena = BitConverter.ToString(
                    SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(nuevaContrasena))
                ).Replace("-", "");

                _context.SaveChanges();  // Guardar los cambios
            }
            else
            {
                throw new Exception("El usuario no fue encontrado.");
            }
        }


    }



}
