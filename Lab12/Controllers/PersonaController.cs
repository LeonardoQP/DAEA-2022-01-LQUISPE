using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;

namespace Lab12.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona
            {
                PersonaID = 1,
                Nombre = "Leonardo",
                Apellido = "Quispe",
                Direccion = "Pachacutec 628A Rio Seco",
                FechaNac = Convert.ToDateTime("1998-05-22"),
                Email = "fabrizioquispe.1250@gmail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 2,
                Nombre = "Carlos",
                Apellido = "Martinez",
                Direccion = "Av los Manzanos 101",
                FechaNac = Convert.ToDateTime("1992-02-28"),
                Email = "carlos@gmail.com"
            });

            personas.Add(new Persona
            {
                PersonaID = 3,
                Nombre = "Maria",
                Apellido = "Salas",
                Direccion = "Av Progreso 325",
                FechaNac = Convert.ToDateTime("1995-10-20"),
                Email = "maria@gmail.com"
            });
            return View(personas);
        }
    }
}