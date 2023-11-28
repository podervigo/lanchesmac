using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositorios
{
    public class LancheRepositorio : ILancheRepositorio
    {
        private readonly AppDbContext _context;

        public LancheRepositorio(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(l => l.IsLanchePreferido == true).Include(c=>c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
