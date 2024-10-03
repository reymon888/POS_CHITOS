using Microsoft.EntityFrameworkCore;

namespace POS_CHITOS
{
    public class VentasService
    {
        private readonly POSContext _context;

        public VentasService(POSContext context)
        {
            _context = context;
        }

        // Registrar nueva venta

        public Venta RegistrarVenta(int idUsuario, List<DetalleVenta> detalles, float pagoRecibido, float cambio, string estado, int IdCorte)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Crear la venta
                    var nuevaVenta = new Venta
                    {
                        FechaVenta = DateTime.Now,
                        TotalVenta = detalles.Sum(d => d.Cantidad * d.PrecioUnitario),
                        PagoRecibido = pagoRecibido,
                        Cambio = cambio,
                        IdUsuario = idUsuario,
                        Estado = estado,
                        IdCorte = IdCorte
                    };

                    _context.ventas.Add(nuevaVenta);
                    _context.SaveChanges();

                    // Agregar los detalles de la venta
                    foreach (var detalle in detalles)
                    {
                        detalle.FolioVenta = nuevaVenta.FolioVenta;
                        _context.DetallesVentas.Add(detalle);

                        // Actualizar el stock
                        var producto = _context.Inventario.Find(detalle.CodigoProducto);
                        if (producto != null)
                        {
                            producto.Stock -= detalle.Cantidad;
                            _context.Inventario.Update(producto);
                        }
                    }

                    _context.SaveChanges();
                    transaction.Commit();

                    return nuevaVenta; // Devolver la venta registrada
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        // Obtener ventas en general

        public List<VentaDTO> ObtenerVentas()
        {
            var ventas = (from venta in _context.ventas
                          join usuario in _context.Usuarios on venta.IdUsuario equals usuario.Id
                          select new VentaDTO
                          {
                              FolioVenta = venta.FolioVenta,
                              FechaVenta = venta.FechaVenta,
                              TotalVenta = venta.TotalVenta,
                              PagoRecibido = venta.PagoRecibido, // Incluye el pago recibido
                              Cambio = venta.Cambio,             // Incluye el cambio
                              Usuario = usuario.NombreUsuario,
                              Estado = venta.Estado
                          }).ToList();

            return ventas;
        }


        // Ejemplo en el service o método de carga
        public List<DetalleVentaDTO> ObtenerDetallesVenta(int folioVenta)
        {
            var detallesVenta = _context.DetallesVentas
                .Where(d => d.FolioVenta == folioVenta)
                .Select(d => new DetalleVentaDTO
                {
                    CodigoProducto = d.CodigoProducto,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    Total = d.Cantidad * d.PrecioUnitario,
                    // Obtener la descripción del producto desde inventario
                    DescripcionProducto = _context.Inventario
                        .Where(i => i.CodigoProducto == d.CodigoProducto)
                        .Select(i => i.DescripcionProducto)
                        .FirstOrDefault() ?? "Descripción no encontrada"
                })
                .ToList();

            return detallesVenta;
        }


        public VentaDTO ObtenerVentaPorFolio(int folioVenta)
        {
            var venta = _context.ventas
                .Include(v => v.DetallesVenta)
                .ThenInclude(d => d.Inventario)
                .Include(v => v.Usuario)
                .FirstOrDefault(v => v.FolioVenta == folioVenta);

            if (venta == null)
            {
                return null;
            }

            return new VentaDTO
            {
                FolioVenta = venta.FolioVenta,
                FechaVenta = venta.FechaVenta,
                TotalVenta = venta.TotalVenta,
                PagoRecibido = venta.PagoRecibido,  // Incluye el pago recibido
                Cambio = venta.Cambio,              // Incluye el cambio
                NombreUsuario = venta.Usuario?.NombreUsuario ?? "N/A",
                Estado = venta.Estado,
                DetallesVenta = venta.DetallesVenta?.Select(d => new DetalleVentaDTO
                {
                    CodigoProducto = d.CodigoProducto,
                    DescripcionProducto = d.Inventario?.DescripcionProducto ?? "Sin Descripción",
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    Total = d.Cantidad * d.PrecioUnitario
                }).ToList() ?? new List<DetalleVentaDTO>()
            };
        }


        public void ModificarVenta(int folioVenta, List<DetalleVenta> detallesVenta, float pagoRecibido, float cambio)
        {
            try
            {
                var venta = _context.ventas.Include(v => v.DetallesVenta).FirstOrDefault(v => v.FolioVenta == folioVenta);

                if (venta != null)
                {
                    // Actualizar el pago recibido y el cambio
                    venta.PagoRecibido = pagoRecibido;
                    venta.Cambio = cambio;

                    // Obtener los detalles existentes para comparar con los nuevos
                    var detallesExistentes = venta.DetallesVenta.ToList();

                    // Identificar los detalles que han sido eliminados y restaurar el stock
                    var detallesAEliminar = detallesExistentes.Where(d => !detallesVenta.Any(nd => nd.CodigoProducto == d.CodigoProducto)).ToList();
                    foreach (var detalleEliminar in detallesAEliminar)
                    {
                        var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == detalleEliminar.CodigoProducto);
                        if (producto != null)
                        {
                            producto.Stock += detalleEliminar.Cantidad; // Restaurar el stock
                            _context.Inventario.Update(producto);
                        }
                        _context.DetallesVentas.Remove(detalleEliminar);
                    }

                    // Actualizar los detalles existentes y ajustar el stock
                    foreach (var detalle in detallesVenta)
                    {
                        var detalleExistente = venta.DetallesVenta.FirstOrDefault(d => d.CodigoProducto == detalle.CodigoProducto);

                        if (detalleExistente != null)
                        {
                            // Ajustar el inventario según la diferencia en cantidad
                            var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == detalle.CodigoProducto);
                            if (producto != null)
                            {
                                // Calcular la diferencia en cantidades
                                int diferencia = detalle.Cantidad - detalleExistente.Cantidad;
                                producto.Stock -= diferencia; // Ajustar el stock según la diferencia
                                _context.Inventario.Update(producto);
                            }

                            // Actualiza los detalles existentes
                            detalleExistente.Cantidad = detalle.Cantidad;
                            detalleExistente.PrecioUnitario = detalle.PrecioUnitario;
                        }
                        else
                        {
                            // Agregar nuevos detalles a la venta y ajustar el inventario
                            venta.DetallesVenta.Add(detalle);
                            var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == detalle.CodigoProducto);
                            if (producto != null)
                            {
                                producto.Stock -= detalle.Cantidad; // Descontar la cantidad agregada
                                _context.Inventario.Update(producto);
                            }
                        }
                    }

                    // Recalcular el total de la venta
                    venta.TotalVenta = venta.DetallesVenta.Sum(d => d.Cantidad * d.PrecioUnitario);

                    // Guardar los cambios
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Venta no encontrada.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar los cambios de la venta: {ex.Message}");
            }
        }













    }
}