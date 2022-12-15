using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class VisitasController : Controller
    {
        // GET: VisitsController
        public ActionResult CreateVisita()
        {
            return View();
        }

        public ActionResult EditVisita()
        {
            return View();
        }
        public ActionResult GetVisita()
        {

            return View();
        }

        // GET: VisitsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VisitsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VisitsController/Create
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

        // GET: VisitsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VisitsController/Edit/5
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

        // GET: VisitsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VisitsController/Delete/5
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
