using FirstWindow.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWindow.Controllers
{
    public class CadastroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {

            }
            return View(cadastro);
        }
    }
}
