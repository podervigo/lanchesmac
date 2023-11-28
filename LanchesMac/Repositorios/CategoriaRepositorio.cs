using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositorios.Interfaces;

namespace LanchesMac.Repositorios
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly AppDbContext _context;

        public CategoriaRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
