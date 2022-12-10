using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult EditCondominios()
        {
            return View();
        }

        public IActionResult GetCondominios()
        {
            ViewBag.Condominios = Condominios.Condominios.GetCondominios();
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

            Condominium condominium = new Condominium()
            {
                Id_Company = 1,
                Name = txtNombre,
                Address = txtDireccion,
                Phone = txtPhone,
                Logo = "/img/condominios/" + nombreArchivo
            };
            Condominios.Condominios.CreateCondominio(condominium);
            return RedirectToAction("GetCondominios", "Condominios");
        }
        public ActionResult Edit(int id, IFormCollection collection)
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
