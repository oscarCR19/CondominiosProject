using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models.CodeQR;

namespace Proyecto.Controllers
{
    public class PruebasController : Controller
    {
        // GET: PruebasController
        public ActionResult pruebas()
        {
            return View();
        }

        public ActionResult getQrCode()
        {
            CodeQR codeQR = new CodeQR();
            int num = codeQR.GetCode2();
            ViewBag.code = num;

           
            
           
            return View("pruebas");
        }






        // GET: PruebasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PruebasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PruebasController/Create
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

        // GET: PruebasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PruebasController/Edit/5
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

        // GET: PruebasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PruebasController/Delete/5
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
