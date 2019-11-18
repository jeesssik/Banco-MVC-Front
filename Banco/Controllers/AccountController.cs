using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Banco.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginUsuario()
        {
            return View();
        }

        public IActionResult LoginAdmin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginAdmin(string username, string pass)
        {

            // implementar login. en este momento simplemente redirigimos a la página principal.
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult LoginUsuario(string username, string pass)
        {

            // implementar login. en este momento simplemente redirigimos a la página principal.
            return RedirectToAction("Index", "Home");
        }
    }
}