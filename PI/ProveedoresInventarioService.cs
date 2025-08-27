using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.PI
{
    public class ProveedoresInventarioService
    {

        private readonly POSContext _context;

        public ProveedoresInventarioService(POSContext context)
        {
            _context = context;
        }

        // Obtener productos de un proveedor específico
        public List<ProveedoresInventarioDTO> ObtenerProductosPorProveedor(int idProveedor)
        {
            return _context.ProveedoresInventario
                .Where(pi => pi.IdProveedor == idProveedor )
                .Select(pi => new ProveedoresInventarioDTO
                {
                    IdPI = pi.IdPI,
                    CodigoProducto = pi.CodigoProducto,
                    DescripcionProducto = pi.Producto.DescripcionProducto, // Asumiendo que tienes la relación con Inventario
                    PrecioCompra = (pi.PrecioCompra == 0) ? 0 : pi.PrecioCompra,
                    Estado = pi.Estado
                })
                .ToList();
        }

        //obtener los proveedores 
        public List<Proveedores> ObtenerProveedores()
        {
            return _context.Proveedores.ToList();
        }

        // Agregar un producto a un proveedor
        public void AgregarProductoAProveedor(ProveedoresInventario productoProveedor)
        {
            _context.ProveedoresInventario.Add(productoProveedor);
            _context.SaveChanges();
        }

        // Actualizar el estado de un producto (activar/desactivar)
        public void CambiarEstadoProducto(int idPI, string nuevoEstado)
        {
            var productoProveedor = _context.ProveedoresInventario.Find(idPI);
            if (productoProveedor != null)
            {
                productoProveedor.Estado = nuevoEstado;
                _context.SaveChanges();
            }
        }

        //obtener roveedor por id

        public Proveedores ObtenerProveedorPorId(int idProveedor)
        {
            return _context.Proveedores.Find(idProveedor);
        }

        //Cambiar estado del catalogo Activo a Inactivo y viceversa
        public void CambiarEstadoCatalogo(int idProveedor, string nuevoEstado)
        {
            var catalogoProveedor = _context.ProveedoresInventario.Where(pi => pi.IdProveedor == idProveedor).ToList();
            if (catalogoProveedor != null)
            {
                foreach (var item in catalogoProveedor)
                {
                    item.Estado = nuevoEstado;
                }
                _context.SaveChanges();
            }
        }

    }
}
