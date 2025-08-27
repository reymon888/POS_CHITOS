using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class ProveedoresService
    {
        private readonly POSContext _context;

        public ProveedoresService(POSContext context)
        {
            _context = context;
        }

        //Crear proveedor 
        public void crearProveedor(string nombreProveedor, string telefonoProveedor, string correoElectronico, string direccionProveedor)
        {
            var nuevoProveedor = new Proveedores
            {
                NombreProveedor = nombreProveedor,
                TelefonoProveedor = telefonoProveedor,
                CorreoElectronico = correoElectronico,
                DireccionProveedor = direccionProveedor,
                Estado = "Activo"
            };

            _context.Proveedores.Add(nuevoProveedor);
            _context.SaveChanges();

        }

        public Proveedores ObtenerProveedorPorId(int idProveedor)
        {
            return _context.Proveedores.FirstOrDefault(p => p.idProveedor == idProveedor);
        }

        public void modificarProveedor(int idProveedor, string nombreProveedor, string telefonoProveedor, string correoElectronico, string direccionProveedor)
        {
            var proveedor = _context.Proveedores.Find(idProveedor);
            if (proveedor != null)
            {
                proveedor.NombreProveedor = nombreProveedor;
                proveedor.TelefonoProveedor = telefonoProveedor;
                proveedor.CorreoElectronico = correoElectronico;
                proveedor.DireccionProveedor = direccionProveedor;
                _context.Proveedores.Update(proveedor);
                _context.SaveChanges();  // Asegúrate de que este guardado se ejecute correctamente
            }
            else
            {
                throw new Exception("Proveedor no encontrado.");
            }
        }





        //eliminar proveedor

        public void eliminarProveedor(int idProveedor)
        {
            var proveedor = _context.Proveedores.Find(idProveedor);
            if (proveedor != null)
            {
                _context.Proveedores.Remove(proveedor);
                _context.SaveChanges();
            }
        }

        //metodo de cambiar estado del proveedor de Activo a Inactivo y viceversa
        public void cambiarEstadoProveedor(int idProveedor)
        {
            var proveedor = _context.Proveedores.Find(idProveedor);
            if (proveedor != null)
            {
                if (proveedor.Estado == "Activo")
                {
                    proveedor.Estado = "Inactivo";
                }
                else
                {
                    proveedor.Estado = "Activo";
                }
                _context.Proveedores.Update(proveedor);
                _context.SaveChanges();
            }
        }

        //listar proveedores
        public List<Proveedores> listarProveedores()
        {
            return _context.Proveedores.ToList();
        }

        //listarProveedoresPorNombre
        public List<Proveedores> listarProveedoresPorNombre(string nombreProveedor)
        {
            return _context.Proveedores.Where(p => p.NombreProveedor.Contains(nombreProveedor)).ToList();
        }



        //metodo de obtener proveedor por nombre
        public Proveedores ObtenerProveedorPorNombre(string nombreProveedor)
        {
            return _context.Proveedores.FirstOrDefault(p => p.NombreProveedor == nombreProveedor);
        }
    }
}
