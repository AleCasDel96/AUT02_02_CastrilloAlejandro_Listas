using AUT02_02_CastrilloAlejandro_Listas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace AUT02_02_CastrilloAlejandro_Listas.Controllers
{
    public class PersonajeController : Controller
    {
        public static List<Personaje> listaperson = new List<Personaje>();
        public IActionResult Index()
        {
            if (listaperson.Count == 0)
            {
                iniciarpersonajes();
            }
            return View(listaperson);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Personaje perso)
        {
            if (ModelState.IsValid)
            {
                agregarpersonaje(perso.Name, perso.Family, perso.NChildren);
                return RedirectToAction("Index");
            }
            return View(perso);
        }

        public void iniciarpersonajes()
        {

            agregarpersonaje("primero", "no se", 0);
            agregarpersonaje("segundo", "alguien", 0);
        }
        public void agregarpersonaje(string Nombre, string Familia, int NChildren)
        {
            if (listaperson.Count == 0)
            {
                listaperson.Add(new Personaje(1, Nombre, Familia, NChildren));
            }
            else
            {
                listaperson.Add(new Personaje(listaperson[listaperson.Count - 1].Id + 1, Nombre, Familia, NChildren));
            }

        }
    }
}
