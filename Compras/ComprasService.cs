using Microsoft.EntityFrameworkCore;
using POS_CHITOS.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Compras
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
            //Mostrar las compras del dia actual y que esten en orden descendente
            var compras = _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Usuario)
                .Where(c => c.FechaCompra.Date == DateTime.Today)
                .OrderByDescending(c => c.FechaCompra)
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


        //Listar compras por fecha desde y hasta
        public List<CompraDTO> ListarComprasPorFecha(DateTime desde, DateTime hasta)
        {
            var compras = _context.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Usuario)
                .Where(c => c.FechaCompra >= desde && c.FechaCompra <= hasta)
                .OrderByDescending(c => c.FechaCompra)
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

        public void ActualizarCompra(int idCompra, int idProveedor, string folioCompraOriginal, DateTime nuevaFechaCompra, float totalCompra, List<DetalleCompraDTO> detallesCompra)
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

            // Obtener los detalles actuales de la compra
            var detallesExistentes = _context.DetallesCompras.Where(dc => dc.idCompra == idCompra).ToList();

            // Iterar sobre los nuevos detalles de compra y actualizar el inventario
            foreach (var detalleNuevo in detallesCompra)
            {
                var detalleExistente = detallesExistentes.FirstOrDefault(d => d.CodigoProducto == detalleNuevo.CodigoProducto);

                if (detalleExistente != null)
                {
                    // Comparar la cantidad nueva con la cantidad existente
                    int diferenciaCantidad = detalleNuevo.Cantidad - detalleExistente.Cantidad;

                    // Actualizar el inventario dependiendo de si la diferencia es positiva o negativa
                    var producto = _context.Inventario.Find(detalleNuevo.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock += diferenciaCantidad;  // Sumar o restar la diferencia al stock
                        _context.Inventario.Update(producto);
                    }

                    // Actualizar el detalle existente con la nueva cantidad y precio
                    detalleExistente.Cantidad = detalleNuevo.Cantidad;
                    detalleExistente.PrecioUnitario = detalleNuevo.PrecioUnitario;
                    _context.DetallesCompras.Update(detalleExistente);
                }
                else
                {
                    // Si no existe en los detalles actuales, agregar el nuevo detalle y actualizar el inventario
                    _context.DetallesCompras.Add(new DetalleCompra
                    {
                        idCompra = compra.idCompra,
                        CodigoProducto = detalleNuevo.CodigoProducto,
                        Cantidad = detalleNuevo.Cantidad,
                        PrecioUnitario = detalleNuevo.PrecioUnitario
                    });

                    // Actualizar el stock del inventario con la nueva cantidad
                    var producto = _context.Inventario.Find(detalleNuevo.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock += detalleNuevo.Cantidad;  // Añadir la cantidad completa ya que es un nuevo detalle
                        _context.Inventario.Update(producto);
                    }
                }
            }

            // Eliminar los detalles que ya no existen en la nueva lista de detalles
            var detallesAEliminar = detallesExistentes.Where(d => !detallesCompra.Any(nuevo => nuevo.CodigoProducto == d.CodigoProducto)).ToList();
            foreach (var detalleAEliminar in detallesAEliminar)
            {
                var producto = _context.Inventario.Find(detalleAEliminar.CodigoProducto);
                if (producto != null)
                {
                    producto.Stock -= detalleAEliminar.Cantidad;  // Restar la cantidad del inventario
                    _context.Inventario.Update(producto);
                }

                _context.DetallesCompras.Remove(detalleAEliminar);
            }

            // Guardar los cambios en la base de datos
            _context.SaveChanges();
        }


        //Cambiar estado de la compra de realizada a cancelada y de cancelada a realizada
        public void CambiarEstadoCompra(int idCompra, string estado)
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
                // Si se reactiva la compra, agregar los productos al stock
                foreach (var detalle in compra.DetallesCompras)
                {
                    var producto = _context.Inventario.Find(detalle.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock += detalle.Cantidad;  // Aumentar el stock
                        _context.Inventario.Update(producto);
                    }
                }
            }
            else if (estado == "Cancelada")
            {
                // Si se cancela la compra, restar del stock
                foreach (var detalle in compra.DetallesCompras)
                {
                    var producto = _context.Inventario.Find(detalle.CodigoProducto);
                    if (producto != null)
                    {
                        // Validar que el stock actual sea suficiente para evitar un valor negativo
                        if (producto.Stock >= detalle.Cantidad)
                        {
                            producto.Stock -= detalle.Cantidad;  // Reducir el stock solo si hay suficientes unidades
                        }
                        else
                        {
                            MessageBox.Show($"El producto {producto.DescripcionProducto} no tiene suficientes unidades en stock para esta operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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

        // Listar las compras con filtros: por fecha, usuario, proveedor y estado (Realizadas/Canceladas)
        public List<CompraDTO> ListarComprasPorFiltro(DateTime desde, DateTime hasta, int? idUsuario, int? idProveedor, bool incluirCanceladas)
        {
            var comprasQuery = _context.Compras
                                       .Include(c => c.Proveedor)
                                       .Include(c => c.Usuario)
                                       .Where(c => c.FechaCompra >= desde && c.FechaCompra <= hasta);

            // Filtrar por usuario, si se ha seleccionado uno
            if (idUsuario.HasValue && idUsuario.Value > 0)
            {
                comprasQuery = comprasQuery.Where(c => c.idUsuario == idUsuario.Value);
            }

            // Filtrar por proveedor, si se ha seleccionado uno
            if (idProveedor.HasValue && idProveedor.Value > 0)
            {
                comprasQuery = comprasQuery.Where(c => c.idProveedor == idProveedor.Value);
            }

            // Filtrar por estado (Realizadas o incluir canceladas)
            if (!incluirCanceladas)
            {
                comprasQuery = comprasQuery.Where(c => c.Estado != "Cancelada");
            }

            return comprasQuery.Select(c => new CompraDTO
            {
                idCompra = c.idCompra,
                FolioCompraOriginal = c.FolioCompraOriginal,
                NombreProveedor = c.Proveedor.NombreProveedor,
                NombreUsuario = c.Usuario.NombreUsuario,
                FechaCompra = c.FechaCompra,
                TotalCompra = c.TotalCompra,
                Estado = c.Estado
            }).ToList();
        }

        // Método para obtener detalles de una compra, lo reusamos de tu código original
        public List<DetalleCompraDTO> ObtenerDetallesCompraReportes(int idCompra)
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


        //Metodo para obtener usuarios y meterlos a un combobox
        public List<Usuario> ObtenerUsuarios()
        {
            var usuarios = _context.Usuarios.ToList();
            return usuarios;
        }

        //Metodo para obtener proveedores y meterlos a un combobox
        public List<Proveedores> ObtenerProveedores()
        {
            var proveedores = _context.Proveedores.ToList();
            return proveedores;
        }


    }


}
