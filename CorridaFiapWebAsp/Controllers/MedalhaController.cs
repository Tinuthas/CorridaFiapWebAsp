using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorridaFiapWebAsp.Models;
using CorridaFiapWebAsp.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CorridaFiapWebAsp.Controllers
{
    public class MedalhaController : Controller
    {

        private RacerContext _context;

        public MedalhaController(RacerContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Cadastrar()
        {

            CarregarSelectCorrida();
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Medalha medalha)
        {
            _context.Medatlhas.Add(medalha);
            _context.SaveChanges();
            TempData["msg"] = "Medalha cadastrada";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public IActionResult Listar(int corridaBusca)
        {
            CarregarSelectCorrida();
            return View(_context.Medatlhas.Include(m => m.Corrida)
                .Where(m => m.CorridaId == corridaBusca || corridaBusca == 0).ToList());
        }

        public void CarregarSelectCorrida()
        {
            var lista = _context.Corridas.ToList();
            ViewBag.corridas = new SelectList(lista, "CorridaId", "Nome");
        }
    }
}