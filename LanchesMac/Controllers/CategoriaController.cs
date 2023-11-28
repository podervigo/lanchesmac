using LanchesMac.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaController(ICategoriaRepositorio categoriaRepositorio)
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public IActionResult List()
        {
            var categorias = _categoriaRepositorio.Categorias; 
            return View(categorias);
        }
    }
}
