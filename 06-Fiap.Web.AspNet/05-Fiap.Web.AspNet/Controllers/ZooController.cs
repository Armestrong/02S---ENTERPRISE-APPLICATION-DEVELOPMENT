using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using _05_Fiap.Web.AspNet.Persistences;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class ZooController : Controller
    {
        //o cara que acessa o banco
        private AllZooContext _context;

        public ZooController(AllZooContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Atualizar(Zoo zoo)
        {
            _context.Attach(zoo).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            //Pesquisar o zoo no banco 
            var zoo = _context.Zoos.Find(id);
            //Retornar a view com o zoo
            return View(zoo);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_context.Zoos.ToList());
        }

        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            _context.Zoos.Add(zoo);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}