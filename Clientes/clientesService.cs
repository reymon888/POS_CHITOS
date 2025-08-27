using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS.Clientes
{
    public class clientesService
    {
        private readonly POSContext _ctx;
        public clientesService(POSContext ctx) => _ctx = ctx;

        public int Crear(string nombre, string tel, string rfc, string dir, bool activo = true)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre es obligatorio.");
            var c = new clientes { Nombre = nombre.Trim(), Telefono = tel?.Trim(), RFC = rfc?.Trim(), Direccion = dir?.Trim(), Activo = activo };
            _ctx.Clientes.Add(c); _ctx.SaveChanges(); return c.IdCliente;
        }

        public void Actualizar(int id, string nombre, string tel, string rfc, string dir, bool activo)
        {
            var c = _ctx.Clientes.Find(id) ?? throw new KeyNotFoundException();
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("Nombre es obligatorio.");
            c.Nombre = nombre.Trim(); c.Telefono = tel?.Trim(); c.RFC = rfc?.Trim(); c.Direccion = dir?.Trim(); c.Activo = activo;
            _ctx.SaveChanges();
        }

        public void CambiarEstado(int id, bool activo)
        { var c = _ctx.Clientes.Find(id) ?? throw new KeyNotFoundException(); c.Activo = activo; _ctx.SaveChanges(); }

        public List<ClientesDTO> Listar(string filtro = null, bool? soloActivos = null)
        {
            var q = _ctx.Clientes.AsNoTracking().AsQueryable();
            if (!string.IsNullOrWhiteSpace(filtro))
                q = q.Where(c => c.Nombre.Contains(filtro) || (c.Telefono ?? "").Contains(filtro) || (c.RFC ?? "").Contains(filtro));
            if (soloActivos.HasValue) q = q.Where(c => c.Activo == soloActivos.Value);

            return q.OrderBy(c => c.Nombre).Select(c => new ClientesDTO
            {
                IdCliente = c.IdCliente,
                Nombre = c.Nombre,
                Telefono = c.Telefono,
                RFC = c.RFC,
                Direccion = c.Direccion,
                Estado = c.Activo ? "Habilitado" : "Deshabilitado"
            }).ToList();
        }

        public List<ClienteComboDTO> ListarParaCombo(string filtro = null)
        {
            var q = _ctx.Clientes.AsNoTracking().Where(c => c.Activo);
            if (!string.IsNullOrWhiteSpace(filtro)) q = q.Where(c => c.Nombre.Contains(filtro) || (c.Telefono ?? "").Contains(filtro));
            return q.OrderBy(c => c.Nombre).Select(c => new ClienteComboDTO { IdCliente = c.IdCliente, Nombre = c.Nombre }).ToList();
        }
    }
}

