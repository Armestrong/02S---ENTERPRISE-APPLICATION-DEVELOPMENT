using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _06_Fiap.Web.AspNet.Controllers
{
    public class MedalhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}