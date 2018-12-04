using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;
using Sucursales.Models;

namespace Sucursales.Controllers
{
    public class VendedoresController : Controller
    {
        // GET: Vendedores
        public ActionResult Grid(string order)
        {
            ViewBag.Sucursales = new SelectList(Initialized.InitSucursales(), "Codigo", "Descripcion");

            List<Vendedores> _listaVendedores = Initialized.InitVendedores();

            if (order == "")
                order = "void";

            switch (order)
            {
                case "codigo":
                    _listaVendedores = _listaVendedores.OrderBy(x => x.Codigo).ToList();
                    break;
                case "identification":
                    _listaVendedores = _listaVendedores.OrderBy(x => x.Identificacion).ToList();
                    break;
                case "name":
                    _listaVendedores = _listaVendedores.OrderBy(x => x.Nombre).ToList();
                    break;
                case "surname":
                    _listaVendedores = _listaVendedores.OrderBy(x => x.Apellido).ToList();
                    break;
                default:
                    _listaVendedores = _listaVendedores.OrderBy(x => x.Codigo).ToList();
                    break;
            }

            return View(_listaVendedores);
        }

        [HttpPost]
        public ActionResult Filter() {

            int suc = Convert.ToInt32(Request.Form["Sucursal"]);

            ViewBag.Sucursales = new SelectList(Initialized.InitSucursales(), "Codigo", "Descripcion", suc);

            List<Vendedores> _listaVendedores = Initialized.InitVendedores().Where(x => x.Sucursal == suc).ToList();

            return View("Grid", _listaVendedores);
        }

        public ActionResult Edit(int id) {

            Vendedores _vendedor = Initialized.InitVendedores().Where(x => x.Codigo == id).FirstOrDefault();

            return View(_vendedor);
        }

        [HttpPost]
        public ActionResult Edit(Vendedores _vendedor)
        {
            Vendedores _vendedorOrg = Initialized.InitVendedores().Where(x => x.Codigo == _vendedor.Codigo).FirstOrDefault();

            _vendedorOrg.Codigo = _vendedor.Codigo;
            _vendedorOrg.Identificacion = _vendedor.Identificacion;
            _vendedorOrg.Nombre = _vendedor.Nombre;
            _vendedorOrg.Sucursal = _vendedor.Sucursal;
            _vendedorOrg.TipoIdentificacion = _vendedor.TipoIdentificacion;
            _vendedorOrg.Apellido = _vendedor.Apellido;

            // aqui se aplicaria la actualizacion a la base de datos

            return RedirectToAction("Grid");
        }

        public ActionResult Delete(int id)
        {
            Vendedores _vendedor = Initialized.InitVendedores().Where(x => x.Codigo == id).FirstOrDefault();

            // aqui se aplicaaria la eliminacion a la base de datos
            // Context.Vendedores.Remove(_vendedor)

            return RedirectToAction("Grid");
        }

        public ActionResult ExportToExcel()
        {
            //Load Data
            var data = Initialized.InitVendedores();
            string xml = String.Empty;
            XmlDocument xmlDoc = new XmlDocument();

            XmlSerializer xmlSerializer = new XmlSerializer(data.GetType());

            using (MemoryStream xmlStream = new MemoryStream())
            {
                xmlSerializer.Serialize(xmlStream, data);
                xmlStream.Position = 0;
                xmlDoc.Load(xmlStream);
                xml = xmlDoc.InnerXml;
            }

            var fName = string.Format("Vendedores.xls", DateTime.Now.ToString("s"));

            byte[] fileContents = Encoding.UTF8.GetBytes(xml);

            return File(fileContents, "application/vnd.ms-excel", fName);
        }

    }
}