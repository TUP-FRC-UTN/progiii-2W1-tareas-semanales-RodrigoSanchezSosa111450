using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.AccesoDeDatos;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonaController : Controller
    {
        public ActionResult AltaPersona()
        {            
            return View();
        }

        [HttpPost]
        public ActionResult AltaPersona(Persona model)
        {
            if (ModelState.IsValid)
            {
                bool resultado = AD_Personas.InsertarNuevaPersona(model);
                if (resultado)
                {
                    return RedirectToAction("ListadoPersonas", "Persona");
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }            
        }

        public ActionResult ListadoPersonas()
        {
            List<Persona> lista = AD_Personas.ObtenerListaPersonas();
            return View(lista);
        }

        public ActionResult DatosPersona(int idPersona)
        {
            Persona resultado = AD_Personas.ObtenerPersona(idPersona);
            ViewBag.Nombre = resultado.Nombre + " " + resultado.Apellido;
            return View(resultado);
        }
        
        [HttpPost]
        public ActionResult DatosPersona(Persona model)
        {
            if (ModelState.IsValid)
            {
                bool resultado = AD_Personas.ActualizarDatosPersona(model);
                if (resultado)
                {
                    return RedirectToAction("ListadoPersonas", "Persona");
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }            
        }

        public ActionResult EliminarPersona(int idPersona)
        {
            Persona resultado = AD_Personas.ObtenerPersona(idPersona);
            return View(resultado);
        }

        [HttpPost]
        public ActionResult EliminarPersona(Persona model)
        {
            if (ModelState.IsValid)
            {
                bool resultado = AD_Personas.EliminarPersona(model);
                if (resultado)
                {
                    return RedirectToAction("ListadoPersonas", "Persona");
                }
                else
                {
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }

    }
}

