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
            if (listaperson.Count == 0){ 
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
                agregarpersonaje(perso.Id, perso.Name, perso.Family, perso.NChildren);
                RedirectToAction("index");
            }
            return View(perso);
        }

        public void iniciarpersonajes()
        {

            agregarpersonaje(1, "primero", "no se", 0);
            agregarpersonaje(2, "segundo", "alguien", 0);
        }
        public void agregarpersonaje(int Id,string Nombre,string Familia,int NChildren)
        {
            listaperson.Add(new Personaje(Id, Nombre, Familia, NChildren));
        }
    }
}
