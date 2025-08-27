using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Inventario
{

    public class inventarioService
    {
        private readonly POSContext _context;

        public inventarioService(POSContext context)
        {
            _context = context;
        }

        //Crear producto en inventario
        public void crearProducto(string CodigoProducto, string DescripcionProducto, int Stock, float PrecioVenta, string Estante, int? IdCategoria)
        {
            var nuevoProducto = new inventario
            {
                CodigoProducto = CodigoProducto,
                DescripcionProducto = DescripcionProducto,
                Stock = Stock,
                PrecioVenta = PrecioVenta,
                Estante = Estante,
                IdCategoria = IdCategoria  // Puede ser null si no se asigna una categoría
            };

            _context.Inventario.Add(nuevoProducto);
            _context.SaveChanges();
        }

        //obtener categorias existentes sus nombres
        public List<CategoriaInventario> ObtenerCategorias()
        {
            return _context.CategoriasInventario.ToList();
        }

        // obtener ObtenerProductosFiltrados(categoriaId, proveedorId, stockFilter);
        // Obtener productos del inventario filtrados
        public List<InventarioDTO> ObtenerProductosFiltrados(int? categoriaId, int? proveedorId, string stockFilter, int? stockCantidad)
        {
            // Obtener todos los productos
            var query = _context.Inventario.AsQueryable();

            // Filtrar por categoría si se especifica
            if (categoriaId.HasValue && categoriaId.Value > 0) // 0 es "todas las categorías"
            {
                query = query.Where(p => p.IdCategoria == categoriaId.Value);
            }

            // Filtrar por proveedor si se especifica
            if (proveedorId.HasValue && proveedorId.Value > 0) // 0 es "todos los proveedores"
            {
                var productosProveedor = _context.ProveedoresInventario
                    .Where(pi => pi.IdProveedor == proveedorId.Value)
                    .Select(pi => pi.CodigoProducto)
                    .ToList();

                query = query.Where(p => productosProveedor.Contains(p.CodigoProducto));
            }

            // Filtrar por stock
            if (!string.IsNullOrEmpty(stockFilter))
            {
                if (stockFilter == "ConStock")
                {
                    query = query.Where(p => p.Stock > 0);
                }
                else if (stockFilter == "SinStock")
                {
                    query = query.Where(p => p.Stock == 0);
                }
                else if (stockFilter == "DebajoStock" && stockCantidad.HasValue)
                {
                    query = query.Where(p => p.Stock < stockCantidad.Value);
                }
            }

            // Proyectar a DTO
            var productosFiltrados = query.Select(p => new InventarioDTO
            {
                CodigoProducto = p.CodigoProducto,
                DescripcionProducto = p.DescripcionProducto,
                Stock = p.Stock,
                PrecioCompra = p.PrecioCompra,
                PrecioVenta = p.PrecioVenta,
                NombreCategoria = p.Categoria.NombreCategoria,
                Estante = p.Estante,
                Estado = p.Estado
            }).ToList();

            return productosFiltrados;
        }

        //Obrener productos que su precio de compra sea mayor al precio de venta
        public List<InventarioDTO> ObtenerProductosConPrecioCompraMayorVenta()
        {
            var productos = _context.Inventario
                .Where(p => p.PrecioCompra > p.PrecioVenta)
                .Select(p => new InventarioDTO
                {
                    CodigoProducto = p.CodigoProducto,
                    DescripcionProducto = p.DescripcionProducto,
                    Stock = p.Stock,
                    PrecioCompra = p.PrecioCompra,
                    PrecioVenta = p.PrecioVenta,
                    NombreCategoria = p.Categoria.NombreCategoria,
                    Estante = p.Estante,
                    Estado = p.Estado
                }).ToList();

            return productos;
        }



        public inventario ObtenerProductoPorCodigo(string CodigoProducto)
        {
            return _context.Inventario.FirstOrDefault(p => p.CodigoProducto == CodigoProducto);
        }
        public List<inventario> listarInventarioParaVentas(bool incluirDeshabilitados = false)
        {
            if (incluirDeshabilitados)
            {
                return _context.Inventario.Include(i => i.Categoria.NombreCategoria)
                                          .Where(p => p.Stock > 0) // Solo productos con stock mayor a 0
                                          .ToList();
            }
            else
            {
                return _context.Inventario.Where(p => p.Estado == "Habilitado" && p.Stock > 0) // Solo productos habilitados con stock mayor a 0
                                          .ToList();
            }
        }

        public void modificarProducto(string CodigoProducto, string DescripcionProducto, int Stock, float PrecioVenta, string Estante, int? IdCategoria)
        {
            var producto = _context.Inventario.Find(CodigoProducto);
            if (producto != null)
            {
                producto.DescripcionProducto = DescripcionProducto;
                producto.Stock = Stock;
                producto.PrecioVenta = PrecioVenta;

                producto.Estante = Estante;
                producto.IdCategoria = IdCategoria;  // Asignar nueva categoría


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
        public List<inventario> listarInventario(bool incluirDeshabilitados = false)
        {
            if (incluirDeshabilitados)
            {
                return _context.Inventario.Include(i => i.Categoria.NombreCategoria).ToList(); // Lista todos los productos
            }
            else
            {
                return _context.Inventario.Where(p => p.Estado == "Habilitado").ToList(); // Lista solo productos habilitados
            }
        }

        public List<InventarioDTO> listarInventarioDTO()
        {
            var inventario = (from i in _context.Inventario
                              join c in _context.CategoriasInventario on i.IdCategoria equals c.IdCategoria into categoriaJoin
                              from categoria in categoriaJoin.DefaultIfEmpty() // Permite que se incluyan productos sin categoría
                              select new InventarioDTO
                              {
                                  CodigoProducto = i.CodigoProducto,
                                  DescripcionProducto = i.DescripcionProducto,
                                  Stock = i.Stock,
                                  PrecioVenta = i.PrecioVenta,
                                  PrecioCompra = i.PrecioCompra,
                                  Estante = i.Estante,
                                  Estado = i.Estado,
                                  NombreCategoria = (i.IdCategoria == null || i.IdCategoria == 0) ? "Sin Asignar" : categoria.NombreCategoria
                              }).ToList();

            return inventario;
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

        public List<inventario> listarInventarioPorCategoria(int idCategoria)
        {
            return _context.Inventario.Where(p => p.IdCategoria == idCategoria && p.Estado == "Habilitado").ToList();
        }

        //ObtenerCategoriasHabilitadas
        public List<CategoriaInventario> ObtenerCategoriasHabilitadas()
        {
            return _context.CategoriasInventario.Where(c => c.Estado == "Habilitado").ToList();
        }

        public void CambiarEstadoProducto(string selectedCodigoProducto)
        {
            //Cambiar estado del producto de Hablitado a Deshabilitado y viceversa
            var producto = _context.Inventario.Find(selectedCodigoProducto);
            if (producto != null)
            {
                producto.Estado = producto.Estado == "Habilitado" ? "Deshabilitado" : "Habilitado";
                _context.Inventario.Update(producto);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Producto no encontrado.");
            }
        }

        // Método para obtener el último producto vario
        public inventario ObtenerUltimoProductoVario()
        {
            // Buscar en la base de datos el último producto cuyo código comience con 'VARIO'
            var ultimoProductoVario = _context.Inventario
                                              .Where(p => p.CodigoProducto.StartsWith("VARIO"))
                                              .OrderByDescending(p => p.CodigoProducto)
                                              .FirstOrDefault();

            return ultimoProductoVario;
        }
        public string ObtenerDescripcionPorCodigo(string codigoProducto)
        {
            var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == codigoProducto);
            return producto?.DescripcionProducto ?? "Sin Descripción";
        }

        //Metodo para obtener productos dependiento el estado si es habilitado o deshabilitado
        public List<InventarioDTO> ObtenerProductosPorEstado(string estado)
        {
            return _context.Inventario
                .Where(p => p.Estado == estado)
                .Select(p => new InventarioDTO
                {
                    CodigoProducto = p.CodigoProducto,
                    DescripcionProducto = p.DescripcionProducto,
                    Stock = p.Stock,
                    PrecioVenta = p.PrecioVenta,
                    PrecioCompra = p.PrecioCompra,
                    Estante = p.Estante,
                    Estado = p.Estado,
                    NombreCategoria = p.Categoria.NombreCategoria
                }).ToList();
        }

        public bool PuedeEliminarProducto(string codigoProducto)
        {
            // Verificar si el producto está relacionado con otras entidades
            var tieneRelaciones = _context.DetallesVentas.Any(dv => dv.CodigoProducto == codigoProducto) ||
                                  _context.DetallesCompras.Any(dc => dc.CodigoProducto == codigoProducto) ||
                                  _context.ProveedoresInventario.Any(cp => cp.CodigoProducto == codigoProducto);

            return !tieneRelaciones; // Retorna true si no tiene relaciones
        }

        public void EliminarProducto(string codigoProducto)
        {
            if (!PuedeEliminarProducto(codigoProducto))
            {
                throw new InvalidOperationException("El producto no se puede eliminar porque está relacionado con otros registros.");
            }

            // Obtener el producto
            var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == codigoProducto);
            if (producto != null)
            {
                _context.Inventario.Remove(producto); // Eliminar el producto
                _context.SaveChanges();             // Guardar los cambios
            }
        }


    }
}
