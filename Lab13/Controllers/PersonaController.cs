using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab13.Models;

namespace Lab13.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar(string searchString)
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

            if (!String.IsNullOrEmpty(searchString))
            { 
                personas = new List<Persona>(
                    personas.Where(s => s.Nombre.ToLower().Contains(searchString.ToLower()) 
                                        || s.Apellido.ToLower().Contains(searchString.ToLower())));
            }

            return View(personas);
        }

        public ActionResult Mostrar(int id)
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
            
            Persona persona = (from p in personas
                where p.PersonaID == id
                select p).FirstOrDefault();
            return View(persona);
        }
    }
}