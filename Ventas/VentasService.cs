using Microsoft.EntityFrameworkCore;

namespace POS_CHITOS.Ventas
{
    public class VentasService
    {
        private readonly POSContext _context;

        public VentasService(POSContext context)
        {
            _context = context;
        }

        // Registrar nueva venta

        // Registrar nueva venta
        public List<DetalleVentaDTO> ObtenerDetallesVentaPorFolio(int folioVenta)
        {
            return _context.DetallesVentas
                .Where(d => d.FolioVenta == folioVenta)
                .Select(d => new DetalleVentaDTO
                {
                    CodigoProducto = d.CodigoProducto,
                    DescripcionProducto = d.DescripcionProducto,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    Total = d.Cantidad * d.PrecioUnitario
                })
                .ToList();
        }
        public Venta RegistrarVenta(int idUsuario, DateTime FechaVenta, List<DetalleVenta> detalles, float pagoRecibido, float cambio, string estado, int IdCorte)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Crear la venta
                    var nuevaVenta = new Venta
                    {
                        FechaVenta = FechaVenta,
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
                        // Asignar el folio de venta a cada detalle
                        detalle.FolioVenta = nuevaVenta.FolioVenta;

                        // Verificar si el producto es vario (sin código específico) o está en el inventario
                        if (detalle.CodigoProducto != "0")
                        {
                            // Obtener la descripción desde el inventario para productos normales
                            var producto = _context.Inventario.Find(detalle.CodigoProducto);
                            if (producto != null)
                            {
                                detalle.DescripcionProducto = producto.DescripcionProducto;
                                producto.Stock -= detalle.Cantidad; // Actualizar stock del producto
                                _context.Inventario.Update(producto);
                            }
                            else
                            {
                                detalle.DescripcionProducto = "Sin Descripción"; // Descripción por defecto si no se encuentra en inventario
                            }
                        }
                        else
                        {
                            // Para productos varios, la descripción ya debe estar asignada en el objeto `detalle`
                            // y no afecta al inventario
                        }

                        // Agregar el detalle de la venta a la base de datos
                        _context.DetallesVentas.Add(detalle);
                    }

                    // Guardar los cambios de detalles y confirmar la transacción
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
            //mmostrar las ventas de la fecha de el dia actual pero en orden descendente
            var ventas = _context.ventas
                 .Where(v => v.FechaVenta.Date == DateTime.Now.Date)
                 .OrderByDescending(v => v.FechaVenta)
                 .Select(v => new VentaDTO
                 {
                     FolioVenta = v.FolioVenta,
                     FechaVenta = v.FechaVenta,
                     TotalVenta = v.TotalVenta,
                     PagoRecibido = v.PagoRecibido,
                     Cambio = v.Cambio,
                     NombreUsuario = v.Usuario.NombreUsuario,
                     Estado = v.Estado
                 })
                 .ToList();

            return ventas;

        }
        // Obtener ventas por usuario y fecha actual en orden descendente (si el usuario es superadministrador, mostrar todas las ventas) 
        public List<VentaDTO> ObtenerVentasPorUsuario(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);

            if (usuario.Rol == "Superadministrador")
            {
                return _context.ventas
                    .Include(v => v.Usuario) // Incluye la relación con Usuario
                    .Where(v => v.FechaVenta.Date == DateTime.Now.Date)
                    .OrderByDescending(v => v.FechaVenta)
                    .Select(v => new VentaDTO
                    {
                        FolioVenta = v.FolioVenta,
                        FechaVenta = v.FechaVenta,
                        TotalVenta = v.TotalVenta,
                        PagoRecibido = v.PagoRecibido,
                        Cambio = v.Cambio,
                        NombreUsuario = v.Usuario.NombreUsuario, // Proyecta el nombre del usuario
                        Estado = v.Estado
                    })
                    .ToList();
            }
            else
            {
                return _context.ventas
                    .Include(v => v.Usuario) // Incluye la relación con Usuario
                    .Where(v => v.IdUsuario == idUsuario && v.FechaVenta.Date == DateTime.Now.Date)
                    .OrderByDescending(v => v.FechaVenta)
                    .Select(v => new VentaDTO
                    {
                        FolioVenta = v.FolioVenta,
                        FechaVenta = v.FechaVenta,
                        TotalVenta = v.TotalVenta,
                        PagoRecibido = v.PagoRecibido,
                        Cambio = v.Cambio,
                        NombreUsuario = v.Usuario.NombreUsuario, // Proyecta el nombre del usuario
                        Estado = v.Estado
                    })
                    .ToList();
            }
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
                PagoRecibido = venta.PagoRecibido,
                Cambio = venta.Cambio,
                NombreUsuario = venta.Usuario?.NombreUsuario ?? "N/A",
                Estado = venta.Estado,
                DetallesVenta = venta.DetallesVenta?.Select(d => new DetalleVentaDTO
                {
                    CodigoProducto = d.CodigoProducto,
                    DescripcionProducto = d.DescripcionProducto ?? "Sin Descripción",
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario,
                    Total = d.Cantidad * d.PrecioUnitario
                }).ToList() ?? new List<DetalleVentaDTO>()
            };
        }




        public void ModificarVenta(int folioVenta, List<DetalleVenta> detallesVenta, float pagoRecibido, float cambio)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var venta = _context.ventas
                        .Include(v => v.DetallesVenta)
                        .FirstOrDefault(v => v.FolioVenta == folioVenta);

                    if (venta == null)
                    {
                        throw new Exception("Venta no encontrada.");
                    }

                    // Verificar si el corte de caja está realizado
                    if (venta.Estado == "Realizado")
                    {
                        throw new Exception("No se puede modificar la venta porque el corte está cerrado.");
                    }

                    // Actualizar el pago recibido y el cambio
                    venta.PagoRecibido = pagoRecibido;
                    venta.Cambio = cambio;

                    // Eliminar detalles que ya no están en la lista actual
                    var detallesAEliminar = venta.DetallesVenta
                        .Where(d => !detallesVenta.Any(nd => nd.CodigoProducto == d.CodigoProducto && nd.DescripcionProducto == d.DescripcionProducto))
                        .ToList();

                    foreach (var detalleEliminar in detallesAEliminar)
                    {
                        _context.DetallesVentas.Remove(detalleEliminar);
                    }

                    // Actualizar o agregar los detalles existentes
                    foreach (var detalle in detallesVenta)
                    {
                        var detalleExistente = venta.DetallesVenta.FirstOrDefault(d =>
                            d.CodigoProducto == detalle.CodigoProducto && d.DescripcionProducto == detalle.DescripcionProducto);

                        if (detalleExistente != null)
                        {
                            // Actualizar detalle existente
                            detalleExistente.Cantidad = detalle.Cantidad;
                            detalleExistente.PrecioUnitario = detalle.PrecioUnitario;
                            detalleExistente.DescripcionProducto = detalle.CodigoProducto == "0"
                                ? detalle.DescripcionProducto // Para productos varios, usa la descripción ingresada
                                : _context.Inventario.FirstOrDefault(i => i.CodigoProducto == detalle.CodigoProducto)?.DescripcionProducto; // Para productos normales, obtener del inventario
                        }
                        else
                        {
                            // Asignar descripción para productos normales
                            if (detalle.CodigoProducto != "0")
                            {
                                detalle.DescripcionProducto = _context.Inventario.FirstOrDefault(i => i.CodigoProducto == detalle.CodigoProducto)?.DescripcionProducto
                                    ?? "Sin Descripción"; // Manejo de productos que podrían no estar en el inventario
                            }

                            // Agregar nuevo detalle
                            venta.DetallesVenta.Add(detalle);
                        }
                    }

                    // Recalcular el total de la venta
                    venta.TotalVenta = detallesVenta.Sum(d => d.Cantidad * d.PrecioUnitario);

                    // Guardar los cambios
                    _context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception($"Error al guardar los cambios de la venta: {ex.Message}");
                }
            }
        }




        public List<VentaDTO> ObtenerVentasPorFecha(DateTime desde, DateTime hasta)
        {
            // Asegurarse de comparar fechas correctamente, incluyendo los límites
            var ventas = _context.ventas
                .Where(v => v.FechaVenta.Date >= desde.Date && v.FechaVenta.Date <= hasta.Date)
                .OrderByDescending(v => v.FechaVenta)
                .Select(v => new VentaDTO
                {
                    FolioVenta = v.FolioVenta,
                    FechaVenta = v.FechaVenta,
                    TotalVenta = v.TotalVenta,
                    PagoRecibido = v.PagoRecibido,
                    Cambio = v.Cambio,
                    NombreUsuario = v.Usuario.NombreUsuario,
                    Estado = v.Estado
                })
                .ToList();

            return ventas;
        }


        // Obtener todas las ventas
        public List<VentaDTO> ObtenerVentasReportes()
        {
            var ventas = (from venta in _context.ventas
                          join usuario in _context.Usuarios on venta.IdUsuario equals usuario.Id
                          select new VentaDTO
                          {
                              FolioVenta = venta.FolioVenta,
                              FechaVenta = venta.FechaVenta,
                              TotalVenta = venta.TotalVenta,
                              PagoRecibido = venta.PagoRecibido,
                              Cambio = venta.Cambio,
                              Usuario = usuario.NombreUsuario,
                              Estado = venta.Estado
                          }).ToList();

            return ventas;
        }

        // Obtener ventas por rango de fechas, con opción para incluir ventas canceladas
        public List<VentaDTO> ObtenerVentasPorFecha(DateTime desde, DateTime hasta, bool incluirCanceladas)
        {
            var query = _context.ventas.Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta);

            if (!incluirCanceladas)
            {
                query = query.Where(v => v.Estado != "Cancelada");
            }

            return query.Select(v => new VentaDTO
            {
                FolioVenta = v.FolioVenta,
                FechaVenta = v.FechaVenta,
                TotalVenta = v.TotalVenta,
                NombreUsuario = v.Usuario.NombreUsuario,
                Estado = v.Estado
            }).ToList();
        }

        // Obtener ventas por usuario y rango de fechas, con opción de incluir ventas canceladas
        public List<VentaDTO> ObtenerVentasPorUsuarioYFecha(int idUsuario, DateTime desde, DateTime hasta, bool incluirCanceladas)
        {
            var query = _context.ventas
                                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta && v.IdUsuario == idUsuario);

            if (!incluirCanceladas)
            {
                query = query.Where(v => v.Estado != "Cancelada");
            }

            return query.Select(v => new VentaDTO
            {
                FolioVenta = v.FolioVenta,
                FechaVenta = v.FechaVenta,
                TotalVenta = v.TotalVenta,
                NombreUsuario = v.Usuario.NombreUsuario,
                Estado = v.Estado
            }).ToList();
        }

        // Obtener detalles de una venta
        // Obtener detalles de una venta
        public List<DetalleVentaDTO> ObtenerDetallesDeVenta(int folioVenta)
        {
            return _context.DetallesVentas
                           .Where(d => d.FolioVenta == folioVenta)
                           .Select(d => new DetalleVentaDTO
                           {
                               CodigoProducto = d.CodigoProducto,
                               DescripcionProducto = d.DescripcionProducto ?? "Producto sin descripción",
                               Cantidad = d.Cantidad,
                               PrecioUnitario = d.PrecioUnitario,
                               Total = d.Cantidad * d.PrecioUnitario
                           })
                           .ToList();
        }



        //Metodo para cambiar el estado de una venta de Realizada a Cancelada y restaurar el stock de los productos, y de igual forma cambiar el estado de cancelado a realizada y descontar el stock de los productos
        public void CambiarEstadoVenta(int folioVenta, string nuevoEstado)
        {
            var venta = _context.ventas
    .Include(v => v.DetallesVenta) // Incluye los detalles de la venta
    .FirstOrDefault(v => v.FolioVenta == folioVenta);


            if (venta == null)
            {
                throw new Exception("Venta no encontrada.");
            }

            // Verificar si el corte de caja está realizado
            if (venta.Estado == "Realizado")
            {
                throw new Exception("No se puede cambiar el estado de la venta porque el corte está cerrado.");
            }

            if (nuevoEstado == "Cancelada")
            {
                foreach (var detalle in venta.DetallesVenta)
                {
                    var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == detalle.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock += detalle.Cantidad;
                        _context.Inventario.Update(producto);
                    }
                }
            }
            else if (nuevoEstado == "Realizada")
            {
                foreach (var detalle in venta.DetallesVenta)
                {
                    var producto = _context.Inventario.FirstOrDefault(p => p.CodigoProducto == detalle.CodigoProducto);
                    if (producto != null)
                    {
                        producto.Stock -= detalle.Cantidad;
                        _context.Inventario.Update(producto);
                    }
                }
            }

            venta.Estado = nuevoEstado;
            _context.SaveChanges();
        }


    }
}