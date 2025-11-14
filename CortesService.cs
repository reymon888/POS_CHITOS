using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace POS_CHITOS
{
    public class CortesService
    {
        private readonly POSContext _context;

        public CortesService(POSContext context)
        {
            _context = context;
        }

        public CortesCaja ObtenerCorteNoRealizado(int idUsuario)
        {
            return _context.CortesCaja
                .FirstOrDefault(c => c.EstadoCorte == "No Realizado" && c.IdUsuario == idUsuario);
        }



        public void CrearCorteNuevo(int idUsuario, float montoInicial)
        {
            var nuevoCorte = new CortesCaja
            {
                Fecha = DateTime.Now,
                IdUsuario = idUsuario,
                MontoInicio = montoInicial,
                EstadoCorte = "No Realizado"
            };

            _context.CortesCaja.Add(nuevoCorte);
            _context.SaveChanges();
        }

        public float ObtenerTotalVentasRealizadasPorMetodo(int idCorte, string metodo)
        {
            var total = _context.ventas
                .Where(v => v.IdCorte == idCorte && v.Estado == "Realizada" && v.MetodoPago == metodo)
                .SelectMany(v => v.DetallesVenta)
                .Sum(d => d.Cantidad * d.PrecioUnitario);

            return total;
        }

        public float ObtenerTotalVentasRealizadas(int idCorte)
        {
            var total = _context.ventas
                .AsNoTracking()
                .Where(v => v.IdCorte == idCorte && v.Estado == "Realizada")
                .SelectMany(v => v.DetallesVenta)
                .Sum(d => d.Cantidad * d.PrecioUnitario);

            return total;
        }

        public float ObtenerTotalVentasCanceladas(int idCorte)
        {
            var total = _context.ventas
                .AsNoTracking()
                .Where(v => v.IdCorte == idCorte && v.Estado == "Cancelada")
                .SelectMany(v => v.DetallesVenta)
                .Sum(d => d.Cantidad * d.PrecioUnitario);

            return total;
        }

        public float ObtenerTotalComprasRealizadas(int idCorte)
        {
            return _context.Compras
                           .Where(c => c.IdCorte == idCorte)
                           .Sum(c => c.TotalCompra);
        }

        public float ObtenerTotalComprasCanceladas(int idCorte)
        {
            return _context.Compras
                           .Where(c => c.IdCorte == idCorte && c.Estado == "Cancelada")
                           .Sum(c => c.TotalCompra);
        }

        public float ObtenerTotalEntradasRealizadas(int idCorte)
        {
            return _context.entradaEfectivo
                           .Where(e => e.idCorte == idCorte)
                           .Sum(e => e.Monto);
        }

        public float ObtenerTotalEntradasCanceladas(int idCorte)
        {
            return _context.entradaEfectivo
                           .Where(e => e.idCorte == idCorte && e.Estado == "Cancelado")
                           .Sum(e => e.Monto);
        }

        public float ObtenerTotalSalidasRealizadas(int idCorte)
        {
            return _context.salidaEfectivo
                           .Where(s => s.idCorte == idCorte)
                           .Sum(s => s.Monto);
        }

        public float ObtenerTotalSalidasCanceladas(int idCorte)
        {
            return _context.salidaEfectivo
                           .Where(s => s.idCorte == idCorte && s.Estado == "Cancelado")
                           .Sum(s => s.Monto);
        }

        public float ObtenerMontoInicialCorte(int idCorte)
        {
            return _context.CortesCaja
                           .Where(c => c.IdCorte == idCorte)
                           .Select(c => c.MontoInicio)
                           .FirstOrDefault();
        }

        //ObtenerCortesCaja
        public List<CortesCaja> ObtenerCortesCaja()
        {
            return _context.CortesCaja.ToList();
        }

        // Regresar el corte de caja no realizado del usuario actual (o todos si es Superadministrador)
        // Regresar los cortes de caja no realizados (todos si es Superadministrador, solo el propio si es Cajero)
        public List<CortesCaja> ObtenerCortesCajaNoRealizados(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);

            if (usuario.Rol == "Superadministrador")
            {
                // Si es Superadministrador, devolver todos los cortes abiertos
                return _context.CortesCaja
                    .Include(c => c.Usuario) // Incluir la relación con Usuario
                    .Where(c => c.EstadoCorte == "No Realizado")
                    .ToList();
            }
            else
            {
                // Si es Cajero, devolver solo su corte abierto
                return _context.CortesCaja
                    .Include(c => c.Usuario) // Incluir la relación con Usuario
                    .Where(c => c.EstadoCorte == "No Realizado" && c.IdUsuario == idUsuario)
                    .ToList();
            }
        }





        // Método para finalizar el corte
        public void FinalizarCorte(int idCorte, int idUsuario)
        {
            using var tx = _context.Database.BeginTransaction();
            try
            {
                var corte = _context.CortesCaja.FirstOrDefault(c => c.IdCorte == idCorte && c.EstadoCorte == "No Realizado")
                           ?? throw new Exception("No se encontró el corte o ya ha sido realizado.");

                if (corte.IdUsuario != idUsuario)
                    throw new Exception("No tienes permiso para finalizar este corte.");

                // --- Totales por método (solo Realizada) ---
                float ventasEfec = ObtenerTotalVentasRealizadasPorMetodo(idCorte, "EFECTIVO");
                float ventasTar = ObtenerTotalVentasRealizadasPorMetodo(idCorte, "TARJETA");
                float ventasTrf = ObtenerTotalVentasRealizadasPorMetodo(idCorte, "TRANSFERENCIA");

                // --- Totales globales ya existentes ---
                float ventasRealizadas = ObtenerTotalVentasRealizadas(idCorte);
                float ventasCanceladas = ObtenerTotalVentasCanceladas(idCorte);

                float comprasRealizadas = ObtenerTotalComprasRealizadas(idCorte);
                float comprasCanceladas = ObtenerTotalComprasCanceladas(idCorte);
                float entradasRealizadas = ObtenerTotalEntradasRealizadas(idCorte);
                float entradasCanceladas = ObtenerTotalEntradasCanceladas(idCorte);
                float salidasRealizadas = ObtenerTotalSalidasRealizadas(idCorte);
                float salidasCanceladas = ObtenerTotalSalidasCanceladas(idCorte);

                // Netos
                float totalVentas = ventasRealizadas - ventasCanceladas;          // (incluye todos los métodos)
                float totalCompras = comprasRealizadas - comprasCanceladas;
                float totalEntradas = entradasRealizadas - entradasCanceladas;
                float totalSalidas = salidasRealizadas - salidasCanceladas;

                // *** Caja física: SOLO EFECTIVO ***
                // Lo normal es que Compras/Entradas/Salidas ya estén en efectivo;
                // si luego tipificas por método, ajustas esta fórmula.
                float montoFinalCaja = corte.MontoInicio + ventasEfec + totalEntradas - totalCompras - totalSalidas;

                // Persistir desglose en Corte (agrega estos campos en tu modelo si no existen)
                corte.TotalVentas = totalVentas; // todos los métodos
                corte.TotalVentasEfectivo = ventasEfec;
                corte.TotalVentasTarjeta = ventasTar;
                corte.TotalVentasTransfer = ventasTrf;
                corte.TotalEntradas = totalEntradas;
                corte.TotalSalidas = totalSalidas;
                corte.TotalCompras = totalCompras;
                corte.EstadoCorte = "Realizado";

                _context.SaveChanges();
                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                throw new Exception("Error al finalizar el corte: " + ex.Message);
            }
        }

        public CortesCaja ObtenerCortePorId(int idCorte)
        {
            return _context.CortesCaja.FirstOrDefault(c => c.IdCorte == idCorte);
        }

        public string ObtenerNombreUsuarioPorCorte(int idCorte)
        {
            // Obtener el nombre del usuario que realiz
            return _context.CortesCaja
                           .Where(c => c.IdCorte == idCorte)
                           .Select(c => c.Usuario.NombreUsuario)
                           .FirstOrDefault();
        }

        //obtener actualmente cuanto hay en caja, si es usuario de tipo cajero, solo mostrar la suma y resta de sus propios movimientos, si es superadministrador mostrar todo
        public float ObtenerTotalCaja(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);

            if (usuario.Rol == "Superadministrador")
            {
                return _context.CortesCaja
                               .Where(c => c.EstadoCorte == "No Realizado")
                               .Sum(c => c.MontoInicio + c.TotalVentas + c.TotalEntradas - c.TotalCompras - c.TotalSalidas);
            }
            else
            {
                return _context.CortesCaja
                               .Where(c => c.EstadoCorte == "No Realizado" && c.IdUsuario == idUsuario)
                               .Sum(c => c.MontoInicio + c.TotalVentas + c.TotalEntradas - c.TotalCompras - c.TotalSalidas);
            }
        }
        public bool ExisteMontoInicialHoy(int idUsuario)
        {
            // Ejemplo: valida si hay un corte abierto con monto inicial del día
            var hoy = DateTime.Today;
            return _context.CortesCaja
                           .Any(c => c.IdUsuario == idUsuario && c.EstadoCorte == "No Realizado" && c.Fecha.Date == hoy && c.MontoInicio > 0) ;

        }

    }
}

