using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class EntradaEfectivoService
    {
        private readonly POSContext _context;

        public EntradaEfectivoService(POSContext context)
        {
            _context = context;
        }

        // Método para registrar una entrada de efectivo
        public void RegistrarEntradaEfectivo(int idUsuario, string concepto, float monto, int idCorte)
        {
            var nuevaEntrada = new EntradaEfectivo
            {
                Fecha = DateTime.Now,
                Concepto = concepto,
                Monto = monto,
                idUsuario = idUsuario,
                idCorte = idCorte
            };

            _context.entradaEfectivo.Add(nuevaEntrada);
            _context.SaveChanges(); // Aquí debería guardarse correctamente el idCorte
        }


        // Obtener todas las entradas de efectivo
        public List<EntradaEfectivo> ListarEntradas()
        {
            //lISTAR LAS ENTRADAS PERO SOLO DEL DIA ACTUAL Y EN ORDEN DESCENDENTE
            return _context.entradaEfectivo.Where(e => e.Fecha.Date == DateTime.Now.Date).OrderByDescending(e => e.Fecha).ToList();
        }

        //Listar entradas por usuario y fecha actual en order descendiente, si el usuario es superadministraro, listar todas las entradas 
        public List<EntradaEfectivoDTO> ListarEntradasPorUsuario(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);

            if (usuario.Rol == "Superadministrador")
            {
                return _context.entradaEfectivo
                    .Include(e => e.Usuario) // Incluye la relación con Usuario
                    .Where(e => e.Fecha.Date == DateTime.Now.Date)
                    .OrderByDescending(e => e.Fecha)
                    .Select(e => new EntradaEfectivoDTO
                    {
                        idEntrada = e.idEntrada,
                        Fecha = e.Fecha,
                        Concepto = e.Concepto,
                        Monto = e.Monto,
                        NombreUsuario = e.Usuario.NombreUsuario, // Proyecta el nombre del usuario
                        Estado = e.Estado
                    })
                    .ToList();
            }
            else
            {
                return _context.entradaEfectivo
                    .Include(e => e.Usuario) // Incluye la relación con Usuario
                    .Where(e => e.idUsuario == idUsuario && e.Fecha.Date == DateTime.Now.Date)
                    .OrderByDescending(e => e.Fecha)
                    .Select(e => new EntradaEfectivoDTO
                    {
                        idEntrada = e.idEntrada,
                        Fecha = e.Fecha,
                        Concepto = e.Concepto,
                        Monto = e.Monto,
                        NombreUsuario = e.Usuario.NombreUsuario, // Proyecta el nombre del usuario
                        Estado = e.Estado
                    })
                    .ToList();
            }
        }


        // Método para obtener el total de entradas de efectivo en un corte de caja
        public float ObtenerTotalEntradas(int idCorte)
        {
            return _context.entradaEfectivo.Where(e => e.idCorte == idCorte).Sum(e => e.Monto);
        }

        // Metodo para cambiar el estado de una entrada de efectivo de Realizado a Cancelado
        public void CancelarEntrada(int idEntrada)
        {
            var entrada = _context.entradaEfectivo.Find(idEntrada);

            if (entrada != null)
            {
                entrada.Estado = "Cancelado";
                _context.SaveChanges();
            }
        }

        // Método para obtener el total de entradas de efectivo en un corte de caja 
        // con estado "Realizado" (puedes personalizar para buscar por idCorte, fecha, etc.)
        public float ObtenerTotalEntradasRealizadas(int idCorte)
        {
            return _context.entradaEfectivo
                .Where(e => e.idCorte == idCorte && e.Estado == "Realizado")
                .Sum(e => e.Monto);
        }

        //Metodo para modificar una entrada de efectivo
        public void ModificarEntrada(int idEntrada, string concepto, float monto)
        {
            var entrada = _context.entradaEfectivo.Find(idEntrada);

            if (entrada != null)
            {
                entrada.Concepto = concepto;
                entrada.Monto = monto;
                _context.SaveChanges();
            }
        }

        // Método para cambiar el estado de una entrada de efectivo si esta realizada pasar a cancelada y viceversa
        public void CambiarEstado(int idEntrada, string nuevoEstado)
        {
            var entrada = _context.entradaEfectivo.Find(idEntrada);

            if (entrada != null)
            {
                entrada.Estado = nuevoEstado;
                _context.SaveChanges();
            }
        }

        public List<EntradaEfectivoDTO> ObtenerIngresosPorFecha(DateTime desde, DateTime hasta)
        {
            return _context.entradaEfectivo
                .Where(e => e.Fecha >= desde && e.Fecha <= hasta)
                .Select(e => new EntradaEfectivoDTO
                {
                    Fecha = e.Fecha,
                    NombreUsuario = e.Usuario.NombreUsuario,
                    Monto = e.Monto,
                    Concepto = e.Concepto // Incluimos la descripción del ingreso
                }).ToList();
        }

        public List<EntradaEfectivoDTO> ObtenerIngresosPorUsuarioYFecha(int idUsuario, DateTime desde, DateTime hasta)
        {
            return _context.entradaEfectivo
                .Where(e => e.Fecha >= desde && e.Fecha <= hasta && e.idUsuario == idUsuario)
                .Select(e => new EntradaEfectivoDTO
                {
                    Fecha = e.Fecha,
                    NombreUsuario = e.Usuario.NombreUsuario,
                    Monto = e.Monto,
                    Concepto = e.Concepto // Incluimos la descripción del ingreso
                }).ToList();
        }

    }

}
