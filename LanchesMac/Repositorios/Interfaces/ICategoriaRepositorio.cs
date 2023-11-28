using LanchesMac.Models;

namespace LanchesMac.Repositorios.Interfaces
{
    public interface ICategoriaRepositorio
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
