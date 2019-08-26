using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _05_Fiap.Web.AspNet.Controllers
{
    public class ZooController : Controller
    {


        private static IList<Zoo> _lista = new List<Zoo>();

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return View(_lista);
        }




        [HttpPost]
        public IActionResult Cadastrar(Zoo zoo)
        {
            _lista.Add(zoo);
            TempData["msg"] = "Cadastrado com sucesso";
            return RedirectToAction("Listar");
        }
    }
}