using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto.Models;
using System.Security.Policy;



namespace Proyecto.Controllers
{
    public class MainMenuController : Controller
    {
        // GET: MainMenuController
        public ActionResult mainmenu()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("userCompanySession"))) 
            { 
                Company company = new Company();
            company = JsonConvert.DeserializeObject<Company>(HttpContext.Session.GetString("userCompanySession"));

            var idCond = TempData["idCond"];
            ViewBag.IdCond = idCond;
            ViewBag.Session = company;
            HttpContext.Session.GetString("userCompanySession");
            return View();
            }

            return RedirectToAction("login2", "Login");
        }

        // GET: MainMenuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MainMenuController/Createhttps://localhost:7133/img/Empleados.jpg
        public ActionResult Create()
        {
            return View();
        }

        // POST: MainMenuController/Create
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

        // GET: MainMenuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MainMenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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

        // GET: MainMenuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MainMenuController/Delete/5
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
