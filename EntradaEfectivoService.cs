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
            return _context.entradaEfectivo.Include(e => e.Usuario)
                   .ToList();
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
    }
}
