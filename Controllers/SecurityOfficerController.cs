using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class SecurityOfficerController : Controller
    {
        // GET: SecurityOfficerController
        public ActionResult securityofficer()
        {
            return View();
        }

        public ActionResult GetSecurityOfficer()
        {
            return View();
        }

        // GET: SecurityOfficerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SecurityOfficerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecurityOfficerController/Create
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

        // GET: SecurityOfficerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SecurityOfficerController/Edit/5
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

        // GET: SecurityOfficerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SecurityOfficerController/Delete/5
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
