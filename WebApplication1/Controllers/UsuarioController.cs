using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        { 
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario modelo) 
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Principal", "Home");
            }
            else 
            {
                return View(modelo);
            }
            
        }

        public ActionResult Login2()
        {
            return View();
        }


    }
}
