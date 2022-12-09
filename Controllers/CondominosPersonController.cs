﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class CondominosPersonController : Controller
    {
        // GET: CondominosPersonController
        public ActionResult CreatePerson()
        {
            return View();
        }

        public ActionResult EditPerson()
        {
            return View();
        }

        public ActionResult GetPerson()
        {
            return View();
        }

        // GET: CondominiosPersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CondominiosPersonController/Create
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

        // GET: CondominiosPersonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CondominiosPersonController/Edit/5
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

        // GET: CondominiosPersonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CondominiosPersonController/Delete/5
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
