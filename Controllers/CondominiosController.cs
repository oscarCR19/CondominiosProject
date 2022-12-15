using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto.Models;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Controllers
{
    public class CondominiosController : Controller
    {
        // GET: CondominiosController/Create
        public IActionResult CreateCondominios()
        {
            return View();
        }
        // GET: CondominiosController
       
        public IActionResult EditCondominios(int Id)
        {
            Condominium condominium = new Condominium()
            {
                Id = Convert.ToInt32(Id)
            };

            ViewBag.Condominios = Condominios.Condominios.GetIDCondominio(Id);
            return View();
        }       
        public IActionResult DeleteCondominios(int Id)
        {
            Condominium condominium = new Condominium()
            {
                Id = Convert.ToInt32(Id)
            };

            ViewBag.Condominios = Condominios.Condominios.GetIDCondominio(Id);
            return View();

        }
        public IActionResult DeleteIDCondominio(int Id)
        {
            Condominium condominium = new Condominium()
            {
                Id = Convert.ToInt32(Id)
            };

            ViewBag.Condominios = Condominios.Condominios.DeleteCondominio(Id);
            return RedirectToAction("GetCondominios", "Condominios");
        }
        public IActionResult GetCondominios()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("userCompanySession")))
            {       //este objeto es para tener una empresa donde tomar ids
                Company company = new Company();
                company = JsonConvert.DeserializeObject<Company>(HttpContext.Session.GetString("userCompanySession"));

                ViewBag.CondominiosList = Condominios.Condominios.getListCondomonios(company.Id);
                return View();

            }

            return RedirectToAction("login2", "Login");
        }

        public IActionResult SearchCondominios(string txtBuscar)
        {
            Condominium condominium = new Condominium()
            {
                Filtro = txtBuscar
            };
            ViewBag.Condominios = Condominios.Condominios.SearchCondominios(txtBuscar);
            return View();
        }

        // GET: CondominiosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // POST: CondominiosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CondominiosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CondominiosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveCondominios(IFormFile photo, string txtNombre, string txtDireccion, string txtPhone)
        {
            string nombreArchivo = photo.FileName;
            string rutaArchivo = Directory.GetCurrentDirectory() + @"\wwwroot\img\condominios\" + nombreArchivo;

            photo.CopyTo(new FileStream(rutaArchivo, FileMode.Create));

            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("userCompanySession")))
            {       //este objeto es para tener una empresa donde tomar ids
                Company company = new Company();
                company = JsonConvert.DeserializeObject<Company>(HttpContext.Session.GetString("userCompanySession"));
            
            Condominium condominium = new Condominium()
            {
                Id_Company = company.Id,
                Name = txtNombre,
                Address = txtDireccion,
                Phone = txtPhone,
                Logo = "/img/condominios/" + nombreArchivo
            };
            Condominios.Condominios.CreateCondominio(condominium);
            }
            return RedirectToAction("GetCondominios", "Condominios");
        }
        public IActionResult SaveEditCondominio(IFormFile photo, string txtId, string txtNombre, string txtDireccion, string txtPhone)
        {
            string nombreArchivo = photo.FileName;
            string rutaArchivo = Directory.GetCurrentDirectory() + @"\wwwroot\img\condominios\" + nombreArchivo;

            photo.CopyTo(new FileStream(rutaArchivo, FileMode.Create));

            Condominium condominium = new Condominium()
            {
                Id = Convert.ToInt32(txtId),
                Name = txtNombre,
                Address = txtDireccion,
                Phone = txtPhone,
                Logo = "/img/condominios/" + nombreArchivo
            };
            Condominios.Condominios.EditCondominio(condominium);
            return RedirectToAction("GetCondominios", "Condominios");
        }

        // GET: CondominiosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CondominiosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
