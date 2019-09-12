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

        

        // Istancia o AllCorridaContext
        private AllCorridaContext _context;


        public  CorridaController(AllCorridaContext context)
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
            TempData["msg"] = "Cadastrado com sucesso !";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult editar(int id)
        {
            var corrida = _context.Corridas.Find(id);
            return View(corrida);
        }

        public IActionResult editar(Corrida corrida, Model model)
        {
            _context.Corridas.Update(corrida);
            _context.SaveChanges();
            TempData["msg"] = "Atualizado com sucesso !";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult remover(int id)
        {
          var corri = _context.Corridas.Find(id);
            _context.Corridas.Remove(corri);
            _context.SaveChanges();
            TempData["msg"] = "Removido com sucesso !";
            return RedirectToAction("Listar");
        }
























    }
}