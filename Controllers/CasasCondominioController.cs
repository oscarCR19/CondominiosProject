using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class CasasCondominioController : Controller
    {
        // GET: CasasCondominioController
        public ActionResult CreateCasa()
        {
            return View();
        }

        public ActionResult EditCasa()
        {
            return View();
        }

        public ActionResult GetCasa()
        {
            return View();
        }

        // GET: CasasCondominioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CasasCondominioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CasasCondominioController/Create
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

        // GET: CasasCondominioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CasasCondominioController/Edit/5
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

        // GET: CasasCondominioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CasasCondominioController/Delete/5
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
