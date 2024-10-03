using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class ComprasService
    {
        private readonly POSContext _context;

        public ComprasService(POSContext context)
        {
            _context = context;
        }

        // Registrar nueva compra
        public void RegistrarCompra(int idProveedor, DateTime fechaCompra, List<DetalleCompra> detalles, int idUsuario, string estado, string folioCompraOriginal, int IdCorte)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Crear la compra
                    var nuevaCompra = new Compra
                    {
                        idProveedor = idProveedor,
                        FechaCompra = fechaCompra,
                        TotalCompra = detalles.Sum(d => d.Cantidad * d.PrecioUnitario),
                        idUsuario = idUsuario,
                        Estado = estado,
                        FolioCompraOriginal = folioCompraOriginal,
                        IdCorte = IdCorte

                    };

                    _context.Compras.Add(nuevaCompra);
                    _context.SaveChanges();

                    // Agregar los detalles de la compra
                    foreach (var detalle in detalles)
                    {
                        detalle.idCompra = nuevaCompra.idCompra;
                        _context.DetallesCompras.Add(detalle);

                        // Solo actualizar el stock si la compra está en estado "Realizada"
                        if (estado == "Realizada")
                        {
                            var producto = _context.Inventario.Find(detalle.CodigoProducto);
                            if (producto != null)
                            {
                                producto.Stock += detalle.Cantidad;
                                _context.Inventario.Update(producto);
                            }
                        }

                        // Solo actualizar el precio de compra si la compra está en estado "Realizada"
                        if (estado == "Realizada")
                        {
                            var producto = _context.Inventario.Find(detalle.CodigoProducto);
                            if (producto != null)
                            {
                                producto.PrecioCompra = detalle.PrecioUnitario;
                                _context.Inventario.Update(producto);
                            }
                        }
                    }

                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    // Obtener mensaje detallado de la excepción interna
                    var detailedError = ex.InnerException != null ? ex.InnerException.Message : "Sin detalles adicionales.";
                    MessageBox.Show($"Error al registrar la compra: {ex.Message}\nDetalles: {detailedError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Listar las compras
        public List<CompraDTO> ListarCompras()
        {
            var compras = _context.Compras
                                  .Include(c => c.Proveedor)
                                  .Include(c => c.Usuario)
                                  .Select(c => new CompraDTO
                                  {
                                      idCompra = c.idCompra,
                                      FolioCompraOriginal = c.FolioCompraOriginal,
                                      NombreProveedor = c.Proveedor.NombreProveedor,
                                      NombreUsuario = c.Usuario.NombreUsuario,
                                      FechaCompra = c.FechaCompra,
                                      TotalCompra = c.TotalCompra,
                                      Estado = c.Estado
                                     
                                  })
                                  .ToList();

            return compras;
        }


        // Obtener los detalles de una compra
        public List<DetalleCompraDTO> ObtenerDetallesCompra(int idCompra)
        {
            var detalles = _context.DetallesCompras
                                   .Include(dc => dc.Inventario) // Incluye el producto del inventario
                                   .Where(dc => dc.idCompra == idCompra)
                                   .Select(dc => new DetalleCompraDTO
                                   {
                                       CodigoProducto = dc.CodigoProducto,
                                       DescripcionProducto = dc.Inventario.DescripcionProducto,
                                       Cantidad = dc.Cantidad,
                                       PrecioUnitario = dc.PrecioUnitario,
                                       Total = dc.Cantidad * dc.PrecioUnitario
                                   })
                                   .ToList();

            return detalles;
        }


        //ObtenerDetallesCompra
        public Compra ObtenerDetalCompra(int idCompra)
        {
            var compra = _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Usuario)
                .FirstOrDefault(c => c.idCompra == idCompra);

            return compra;
        }

        public void ActualizarCompra(int idCompra, int idProveedor,String folioCompraOriginal, DateTime nuevaFechaCompra, float totalCompra, List<DetalleCompraDTO> detallesCompra)
        {
            // Obtener la compra existente incluyendo los detalles
            var compra = _context.Compras.Include(c => c.DetallesCompras).FirstOrDefault(c => c.idCompra == idCompra);

            if (compra == null)
            {
                throw new Exception("Compra no encontrada.");
            }

            // Actualizar el proveedor y la fecha
            compra.idProveedor = idProveedor;
            compra.FechaCompra = nuevaFechaCompra;
            compra.FolioCompraOriginal = folioCompraOriginal;
            compra.TotalCompra = totalCompra;

            // Limpiar los detalles actuales de la compra
            var detallesExistentes = _context.DetallesCompras.Where(dc => dc.idCompra == idCompra).ToList();
            _context.DetallesCompras.RemoveRange(detallesExistentes);

            // Añadir los nuevos detalles de la compra
            foreach (var detalle in detallesCompra)
            {
                _context.DetallesCompras.Add(new DetalleCompra
                {
                    idCompra = compra.idCompra,
                    CodigoProducto = detalle.CodigoProducto,
                    Cantidad = detalle.Cantidad,
                    PrecioUnitario = detalle.PrecioUnitario
                });
            }

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
        }


        //Cambiar estado de la compra de realizada a cancelada y de cancelada a realizada
        public void CambiarEstadoCompra(int idCompra, String estado)
        {
            //Si cancelo la compra que regresen los productos al inventario y si la realizo que los productos agreguen al inventario
            var compra = _context.Compras.Include(c => c.DetallesCompras).FirstOrDefault(c => c.idCompra == idCompra);

            if (compra == null)
            {
                throw new Exception("Compra no encontrada.");
            }
            compra.Estado = estado;


            if (estado == "Realizada")
            {
                foreach (var detalle in compra.DetallesCompras)
                {
                    var producto = _context.Inventario.Find(detalle.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock += detalle.Cantidad;
                        _context.Inventario.Update(producto);
                    }
                }
            }
            else if (estado == "Cancelada")
            {
                foreach (var detalle in compra.DetallesCompras)
                {
                    var producto = _context.Inventario.Find(detalle.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock -= detalle.Cantidad;
                        _context.Inventario.Update(producto);
                    }
                }
            }

            _context.SaveChanges();




        }

        // Método para obtener el usuario por su ID
        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            // Busca el usuario en la base de datos por ID
            var usuario = _context.Usuarios.Find(idUsuario);
            if (usuario == null)
            {
                // Lanzar una excepción si el usuario no se encuentra para un mejor manejo de errores
                throw new Exception("El usuario no existe. Verifica el ID del usuario logueado.");
            }
            return usuario;
        }

    }


}
