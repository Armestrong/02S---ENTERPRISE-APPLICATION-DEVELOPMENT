using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistence;
using DocumentFormat.OpenXml.EMMA;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class AnimalController : Controller
    {
        private AllZooContext _context;


        public AnimalController(AllZooContext context)
        {
            _context = context;
        }


        ///RETORNA UMA LISTA
        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Animals.ToList());
        }




        // CADASTRA
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Cadastrar(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado !";
            return RedirectToAction("Listar");
        }


        //ATUALIZAR
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            var animal = _context.Animals.Find(id);
            return View(animal);
        }

        [HttpPost]
        public IActionResult Atualizar(Animal animal, Model model)
        {
            _context.Animals.Update(animal);
            _context.SaveChanges();
            TempData["msg"] = "Atualizado !";
            return RedirectToAction("Listar");
        }

        //  Remover seria um metodo [HttpGet] mas por conta do modal que usarmos para passar um Id O metodo muda para [HttpPost]
        [HttpPost]
        public IActionResult Remover(int id)

        {
            var anil = _context.Animals.Find(id);
            _context.Animals.Remove(anil);
            _context.SaveChanges();
            TempData["msg"] = "Removido !";
            return RedirectToAction("Listar");
        }
     

    }
}