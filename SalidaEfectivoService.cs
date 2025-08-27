using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class SalidaEfectivoService
    {
        private readonly POSContext _context;

        public SalidaEfectivoService(POSContext context)
        {
            _context = context;
        }

        // Método para registrar una salida de efectivo
        public void RegistrarSalidaEfectivo(int idUsuario, string concepto, float monto, int idCorte)
        {
            var nuevaSalida = new SalidaEfectivo
            {
                Fecha = DateTime.Now,
                Concepto = concepto,
                Monto = monto,
                idUsuario = idUsuario,
                idCorte = idCorte
            };

            _context.salidaEfectivo.Add(nuevaSalida);
            _context.SaveChanges(); // Aquí debería guardarse correctamente el idCorte
        }

        // Obtener todas las salida de efectivo
        public List<SalidaEfectivo> ListarSalidas()
        {
            //lISTAR SALIDAS DE EFECTIVO PERO SOLO LAS DE EL DIA ACTUAL Y EN ORDEN DESCENDENTE
            return _context.salidaEfectivo.Where(s => s.Fecha.Date == DateTime.Now.Date).OrderByDescending(s => s.Fecha).ToList();

        }

        //Listar salidas por usuario y fecha actual en order descendiente, si el usuario es superadministraro, listar todas las salidas
        public List<SalidaEfectivoDTO> ListarSalidasPorUsuario(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);

            if (usuario.Rol == "Superadministrador")
            {
                return _context.salidaEfectivo
                    .Include(s => s.Usuario) // Incluye la relación con Usuario
                    .Where(s => s.Fecha.Date == DateTime.Now.Date)
                    .OrderByDescending(s => s.Fecha)
                    .Select(s => new SalidaEfectivoDTO
                    {
                        idSalida = s.idSalida,
                        Fecha = s.Fecha,
                        Concepto = s.Concepto,
                        Monto = s.Monto,
                        NombreUsuario = s.Usuario.NombreUsuario, // Proyecta el nombre del usuario
                        Estado = s.Estado
                    })
                    .ToList();
            }
            else
            {
                return _context.salidaEfectivo
                    .Include(s => s.Usuario) // Incluye la relación con Usuario
                    .Where(s => s.idUsuario == idUsuario && s.Fecha.Date == DateTime.Now.Date)
                    .OrderByDescending(s => s.Fecha)
                    .Select(s => new SalidaEfectivoDTO
                    {
                        idSalida = s.idSalida,
                        Fecha = s.Fecha,
                        Concepto = s.Concepto,
                        Monto = s.Monto,
                        NombreUsuario = s.Usuario.NombreUsuario, // Proyecta el nombre del usuario
                        Estado = s.Estado
                    })
                    .ToList();
            }
        }


        //Metodo para modificar una salida de efectivo
        public void ModificarSalida(int idSalida, string concepto, float monto)
        {
            var salida = _context.salidaEfectivo.Find(idSalida);

            if (salida != null)
            {
                salida.Concepto = concepto;
                salida.Monto = monto;
                _context.SaveChanges();
            }
        }

        // Método para cambiar el estado de una entrada de efectivo si esta realizada pasar a cancelada y viceversa
        public void CambiarEstadoSalida(int idSalida, string nuevoEstado)
        {
            var salida = _context.salidaEfectivo.Find(idSalida);

            if (salida != null)
            {
                salida.Estado = nuevoEstado;
                _context.SaveChanges();
            }
        }

        public List<SalidaEfectivoDTO> ObtenerSalidasPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.salidaEfectivo
                .Include(s => s.Usuario)
                .Where(s => s.Fecha >= fechaDesde && s.Fecha <= fechaHasta)
                .Select(s => new SalidaEfectivoDTO
                {
                    Fecha = s.Fecha,
                    Monto = s.Monto,
                    Concepto = s.Concepto,
                    NombreUsuario = s.Usuario.NombreUsuario
                })
                .ToList();
        }

      
        /// Obtiene las salidas de efectivo de un usuario específico dentro de un rango de fechas.
       
        public List<SalidaEfectivoDTO> ObtenerSalidasPorUsuarioYFecha(int idUsuario, DateTime fechaDesde, DateTime fechaHasta)
        {
            return _context.salidaEfectivo
                .Include(s => s.Usuario)
                .Where(s => s.idUsuario == idUsuario && s.Fecha >= fechaDesde && s.Fecha <= fechaHasta)
                .Select(s => new SalidaEfectivoDTO
                {
                    Fecha = s.Fecha,
                    Monto = s.Monto,
                    Concepto = s.Concepto,
                    NombreUsuario = s.Usuario.NombreUsuario
                })
                .ToList();
        }
    }
}

