using Sucursales.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sucursales.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]
        public ActionResult Create(Person _person)
        {
            try
            {
                string path = Server.MapPath("~/App_Data/registro.txt");

                using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine("Nombre: "+_person.Name);
                    sw.WriteLine("Apellido: " + _person.Surname);
                    sw.WriteLine("Identificador: " + _person.Identification);
                    sw.WriteLine("TipoDoc: " + _person.TypeDoc);
                }

                return RedirectToAction("Grid","Vendedores");
            }
            catch
            {
                return View();
            }
        }     
      
    }
}
