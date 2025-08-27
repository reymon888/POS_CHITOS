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

        public float ObtenerTotalVentasRealizadas(int idCorte)
        {
            return _context.ventas
                           .Where(v => v.IdCorte == idCorte)
                           .Sum(v => v.TotalVenta);
        }

        public float ObtenerTotalVentasCanceladas(int idCorte)
        {
            return _context.ventas
                           .Where(v => v.IdCorte == idCorte && v.Estado == "Cancelada")
                           .Sum(v => v.TotalVenta);
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
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var corteActual = _context.CortesCaja.FirstOrDefault(c => c.IdCorte == idCorte && c.EstadoCorte == "No Realizado");

                    if (corteActual == null)
                    {
                        throw new Exception("No se encontró el corte o ya ha sido realizado.");
                    }

                    // Validar que el corte pertenece al usuario actual
                    if (corteActual.IdUsuario != idUsuario)
                    {
                        throw new Exception("No tienes permiso para finalizar este corte. Solo el usuario que inició el corte puede cerrarlo.");
                    }

                    // Obtener los totales
                    float totalVentasRealizadas = ObtenerTotalVentasRealizadas(idCorte);
                    float totalVentasCanceladas = ObtenerTotalVentasCanceladas(idCorte);
                    float totalComprasRealizadas = ObtenerTotalComprasRealizadas(idCorte);
                    float totalComprasCanceladas = ObtenerTotalComprasCanceladas(idCorte);
                    float totalEntradasRealizadas = ObtenerTotalEntradasRealizadas(idCorte);
                    float totalEntradasCanceladas = ObtenerTotalEntradasCanceladas(idCorte);
                    float totalSalidasRealizadas = ObtenerTotalSalidasRealizadas(idCorte);
                    float totalSalidasCanceladas = ObtenerTotalSalidasCanceladas(idCorte);

                    // Calcular los valores netos
                    float totalVentas = totalVentasRealizadas - totalVentasCanceladas;
                    float totalCompras = totalComprasRealizadas - totalComprasCanceladas;
                    float totalEntradas = totalEntradasRealizadas - totalEntradasCanceladas;
                    float totalSalidas = totalSalidasRealizadas - totalSalidasCanceladas;

                    // Calcular el monto final del corte
                    float montoFinal = corteActual.MontoInicio + totalVentas + totalEntradas - totalCompras - totalSalidas;

                  

                    // Actualizar los valores en el corte
                    corteActual.TotalVentas = totalVentas;
                    corteActual.TotalCompras = totalCompras;
                    corteActual.TotalEntradas = totalEntradas;
                    corteActual.TotalSalidas = totalSalidas;
                    corteActual.EstadoCorte = "Realizado";
                 

                    // Guardar los cambios en la base de datos
                    _context.SaveChanges();

                    // Confirmar la transacción
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al finalizar el corte: " + ex.Message);
                }
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
    }
}

