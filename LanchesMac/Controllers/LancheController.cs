﻿using LanchesMac.Repositorios;
using LanchesMac.Repositorios.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepositorio _lancheRepositorio;

        public LancheController(ILancheRepositorio lancheRepositorio)
        {
            _lancheRepositorio = lancheRepositorio;
        }

        public IActionResult List()
        {

            ViewData["Titulo"] = "Lanches Mc Donald's";
            ViewData["Data"] = DateTime.Now;
            var lanches = _lancheRepositorio.Lanches;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Número de lanches: ";
            ViewBag.TotalLanches = totalLanches;

            return View(lanches);
        }
    }
}
