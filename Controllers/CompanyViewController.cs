using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class CompanyViewController : Controller
    {
        // GET: CompanyViewController
        public ActionResult companyview()
        {

            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("userCompanySession")))
            {       //este objeto es para tener una empresa donde tomar ids
                Company company = new Company();
                company = JsonConvert.DeserializeObject<Company>(HttpContext.Session.GetString("userCompanySession"));

                ViewBag.CondominiosList= Condominios.Condominios.getListCondomonios(company.Id);
                return View();
            
            }

            return RedirectToAction("login2", "Login");
        }


        public ActionResult goToMainMenu()
        {
            return RedirectToAction("mainmenu", "MainMenu");
        }

        // GET: CompanyViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompanyViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompanyViewController/Create
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

        // GET: CompanyViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompanyViewController/Edit/5
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

        // GET: CompanyViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompanyViewController/Delete/5
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
