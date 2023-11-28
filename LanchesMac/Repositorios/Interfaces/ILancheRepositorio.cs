using LanchesMac.Models;

namespace LanchesMac.Repositorios.Interfaces
{
    public interface ILancheRepositorio
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheById(int lancheId);


    }
}
