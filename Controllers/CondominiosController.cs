using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCondominios.Controllers
{
    public class CondominiosController : Controller
    {
        // GET: CondominiosController
        public ActionResult CreateCondominios()
        {
            return View();
        }

        public ActionResult EditCondominios()
        {
            return View();
        }

        // GET: CondominiosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CondominiosController/Create
        public ActionResult Create()
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
