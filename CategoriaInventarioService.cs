using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_CHITOS
{
    public class CategoriaInventarioService
    {
        private readonly POSContext _context;

        public CategoriaInventarioService(POSContext context)
        {
            _context = context;
        }

        public List<CategoriaInventario> ObtenerCategorias()
        {
            //Mostrar todas las categorias y si no hay ninguna mostrar una lista vacia
            return _context.CategoriasInventario.ToList() ?? new List<CategoriaInventario>();



        }

        public void RegistrarCategoria(string nombre)
        {
            var nuevaCategoria = new CategoriaInventario { NombreCategoria = nombre };
            _context.CategoriasInventario.Add(nuevaCategoria);
            _context.SaveChanges();
        }

        public void CambiarEstadoCategoria(int idCategoria, string nuevoEstado)
        {
            var categoria = _context.CategoriasInventario.Find(idCategoria);
            if (categoria != null)
            {
                categoria.Estado = nuevoEstado;
                _context.SaveChanges();
            }
        }

        public void ModificarCategoria(int idCategoria, string nuevoNombre)
        {
            var categoria = _context.CategoriasInventario.Find(idCategoria);
            if (categoria != null)
            {
                categoria.NombreCategoria = nuevoNombre;
                _context.SaveChanges();
            }
        }
    }

}
