using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{

    public class inventarioService
    {
        private readonly POSContext _context;

        public inventarioService(POSContext context)
        {
            _context = context;
        }

        //Crear producto en inventario
        public void crearProducto(String CodigoProducto, String DescripcionProducto, int Stock, float PrecioVenta, String Estante)
        {
            var nuevoProducto = new inventario
            {
                CodigoProducto = CodigoProducto,
                DescripcionProducto = DescripcionProducto,
                Stock = Stock,
                PrecioVenta = PrecioVenta,
                Estante = Estante
            };

            _context.Inventario.Add(nuevoProducto);
            _context.SaveChanges();

        }

        public inventario ObtenerProductoPorCodigo(string CodigoProducto)
        {
            return _context.Inventario.FirstOrDefault(p => p.CodigoProducto == CodigoProducto);
        }

        public void modificarProducto(string CodigoProducto, string DescripcionProducto, int Stock, float PrecioVenta, String Estante)
        {
            var producto = _context.Inventario.Find(CodigoProducto);
            if (producto != null)
            {
                producto.DescripcionProducto = DescripcionProducto;
                producto.Stock = Stock;
                producto.PrecioVenta = PrecioVenta;
                producto.Estante = Estante;


                // Guardar los cambios
                _context.Inventario.Update(producto);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Producto no encontrado.");
            }
        }


        //Eliminar producto
        public void eliminarProducto(string CodigoProducto)
        {
            var producto = _context.Inventario.Find(CodigoProducto);
            if (producto != null)
            {
                _context.Inventario.Remove(producto);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Producto no encontrado.");
            }
        }

        //Listar productos
        public List<inventario> listarInventario()
        {
            return _context.Inventario.ToList();
        }

        //Buscar producto por nombre
        public List<inventario> BuscarProductoPorNombre(string DescripcionProducto)
        {
            return _context.Inventario.Where(p => p.DescripcionProducto.Contains(DescripcionProducto)).ToList();
        }

        public inventario ObtenerProductoPorTexto(string productoTexto)
        {
            // Asumimos que el texto puede contener el código o parte de la descripción del producto
            return _context.Inventario
                .FirstOrDefault(p => p.CodigoProducto.Contains(productoTexto) || p.DescripcionProducto.Contains(productoTexto));
        }

        public List<string> BuscarProductosPorNombreOCodigo(string texto)
        {
            return _context.Inventario
                .Where(p => p.DescripcionProducto.Contains(texto) || p.CodigoProducto.Contains(texto))
                .Select(p => p.CodigoProducto + " - " + p.DescripcionProducto)
                .ToList();
        }

        // Método para aumentar el stock de un producto existente
        public void AumentarStock(string codigoProducto, int cantidad)
        {
            var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == codigoProducto);

            if (producto != null)
            {
                producto.Stock += cantidad;
                _context.Inventario.Update(producto);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Producto no encontrado.");
            }
        }

        //Validar que el precio de venta sea mayor o igual al precio de compra del producto
        public void ValidarPrecioVenta(string CodigoProducto, float PrecioVenta)
        {
            var producto = _context.Inventario.Find(CodigoProducto);
            if (producto != null)
            {
                if (PrecioVenta < producto.PrecioCompra)
                {
                    throw new Exception("El precio de venta es menor al precio de compra.");
                }
            }
            else
            {
                throw new Exception("Producto no encontrado.");
            }
        }
    }
}
