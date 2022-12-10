using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class DashboardPersonController : Controller
    {
        // GET: DashboardPersonController
        public ActionResult dasboardperson()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("userPersonSession")))
            {
                ViewBag.Session = HttpContext.Session.GetString("userPersonSession");
                return View();

            }

            return RedirectToAction("login2", "Login");

            
        }

        // GET: DashboardPersonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DashboardPersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DashboardPersonController/Create
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

        // GET: DashboardPersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DashboardPersonController/Edit/5
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

        // GET: DashboardPersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DashboardPersonController/Delete/5
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
