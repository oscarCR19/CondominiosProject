using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class CondominosPersonController : Controller
    {
        // GET: CondominiosPersonController
        public ActionResult CreatePerson(string txtIdRol,
                                            string txtCed,
                                            string txtNombre1,
                                            string txtNombre2,
                                            string txtApellido1,
                                            string txtApellido2, 
                                            string txtTelefono,
                                            string txtCorreo,
                                            string txtContra)
        {
            Person person = new Person()
            {
                Id_Rol=Convert.ToInt32(txtIdRol),
                Ced=txtCed,
                FirstName=txtNombre1,
                MiddleName=txtNombre2,
                LastName1=txtApellido1,
                LastName2=txtApellido2,
                Phone=txtTelefono,
                Email=txtCorreo,
                User=txtCed,
                Password=txtContra
            };
            if (Persons.Persons.ValidatePerson(txtCed, txtCorreo, txtTelefono).Count != 0)
            {
                
                return View();
            }
            else

                Persons.Persons.InserPerson(person);

            ////falta retornar la vista
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
