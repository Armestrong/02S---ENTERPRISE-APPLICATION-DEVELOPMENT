using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _02_Fiap.Web.AspNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet] // Abrir a pagina do form 
        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost] // Cadastar no clique do botao
        public IActionResult Cadastrar(Cliente cliente)
        {
            // Envia info para a tela
            ViewData["nome"] = cliente.Nome;
            ViewBag.cpf = cliente.Cpf;
            TempData["msg"] = "Usuario Cadastrodo";
            return View();
        }
    }
}