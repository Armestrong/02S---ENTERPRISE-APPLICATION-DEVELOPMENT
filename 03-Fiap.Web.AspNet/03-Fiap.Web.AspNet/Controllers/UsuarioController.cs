using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _03_Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace _03_Fiap.Web.AspNet.Controllers
{
    public class UsuarioController : Controller
    {

        private static IList<Cliente> _lista = new List<Cliente>();

        public IActionResult Index()
        {
            return View();
        }

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

        [HttpPost] // Cadastar no clique do botao
       public IActionResult Cadastrar(Cliente cliente)
        {
            TempData["mensagem"] = "Cadastrado com Sucesso!";
            ViewData["nome"] = cliente.Nome;
            ViewData["email"] = cliente.Email;
            ViewData["data"] = cliente.DataNascimento;
            
            //Cadastrar no "banco" de dados
            _lista.Add(cliente);
            
            //Enviar objeto usuario para a tela
            return View(cliente);
        }


    }
}