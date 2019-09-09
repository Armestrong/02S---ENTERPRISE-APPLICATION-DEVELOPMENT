using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _07_Fiap.Web.AspNet.Models;
using _07_Fiap.Web.AspNet.Persistence;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.AspNetCore.Mvc;

namespace _07_Fiap.Web.AspNet.Controllers
{
    public class CorridaController : Controller
    {

        private AllCorridaContext _context;

        public CorridaController(AllCorridaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Corridas.ToList());
        }




        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Corrida corrida)
        {
            _context.Corridas.Add(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado !";
            return RedirectToAction("Listar");
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            var corrida = _context.Corridas.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Editar(Corrida corrida, Model model)
        {
            _context.Corridas.Update(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Atualizado";
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public IActionResult Remover(int id)
        {
            var aux = _context.Corridas.Find(id);
            _context.Corridas.Remove(aux);
            _context.SaveChanges();
            TempData["msg"] = "Removido";
            return RedirectToAction("Listar");
        }



    }
}