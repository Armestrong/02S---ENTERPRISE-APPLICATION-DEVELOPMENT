using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class ZooController : Controller
    {
       // private static IList<Zoo> _lista = new List<Zoo>();

        private AllZooContext _context;

       public ZooController(AllZooContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Listar()
        {

            return View(_context.Zoos.ToList());
        }


        // CADASTRAR
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            _context.Zoos.Add(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Listar");
        }


        //ATUALIZAR
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
           var zoo = _context.Zoos.Find(id);
     
            return View(zoo);
        }

        [HttpPost]
        public IActionResult Atualizar(Zoo zoo)
        {
            _context.Zoos.Update(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Atualizado !";
            return RedirectToAction("Listar");
        }

        // REMOVER
        [HttpGet]
        public IActionResult Remover (int id)
        {
            var zoo = _context.Zoos.Find(id);
            _context.Zoos.Remove(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Removido !";

            return RedirectToAction("Listar");
        }
    }
}