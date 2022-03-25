using PersonasWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonasWeb.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View("");
        }
        public ActionResult Agregar()
        {
            Persona P = new Persona();
            return View(P);
        }
        [HttpPost]
        public ActionResult Agregar(Persona nuevaPersona)
        {
            new GestorPersona().AgregarPersona(nuevaPersona);
            return View("Index");
        }
        public ActionResult Listar()
        {
            List<Persona> lista = new GestorPersona().ListarPersona();
            return View(lista);
        }
    }
}