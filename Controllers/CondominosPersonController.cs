using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Proyecto.Models;

namespace Proyecto.Controllers
{
    public class CondominosPersonController : Controller
    {

        // GET: CondominiosPersonController
        public ActionResult Create(string txtIdRol,
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

        public ActionResult EditPerson(string txtIdPerson)
        {
            HttpContext.Session.GetString("SessionIdCond");
            Person person = Persons.Persons.GetPerson(Convert.ToInt32(txtIdPerson));
            ViewBag.Person=person;
            return View("EditPerson","CondominosPerson");
        }

        public ActionResult GetPerson(string txtIdCond)
        {
            string idCond = HttpContext.Session.GetString("IdCond");
            
            Company company = new Company();
            company = JsonConvert.DeserializeObject<Company>(HttpContext.Session.GetString("userCompanySession"));
            ViewBag.ListCondominos = Condominos.Condominos.GetCondominosPorCondominio(Convert.ToInt32(idCond));
            ViewBag.IdCond = idCond;
            return View();
        }

        public ActionResult DeletePerson(string txtIdPerson)
        {
            Persons.Persons.Delete(txtIdPerson);
            HttpContext.Session.GetString("userCompanySession");
            return RedirectToAction("mainmenu", "MainMenu");
        }


        public ActionResult SavePerson(string txtCedula,string txtPrimerNombre,string txtSegundoNombre,string txtPrimerApellido,string txtSegundoApellido,string txtTelefono,string txtCorreo,string txtPassword,string txtIdPerson,string txtIdRol) {
            Person person = new Person()
            {
                Id = Convert.ToInt32(txtIdPerson),
                Id_Rol=Convert.ToInt32(txtIdRol),
                Ced=txtCedula,
                FirstName=txtPrimerNombre,
                MiddleName=txtSegundoNombre,
                LastName1=txtPrimerApellido,
                LastName2=txtSegundoApellido,
                Phone=txtTelefono,
                Email=txtCorreo,
                Password=txtPassword
            };

            //aqui valido los datos proporcionados, si falla alguno se queda en un bucle hasta que introduzca un dato que no exista en db
             if (Persons.Persons.ValidateUpdatePerson(person.Ced, person.Email, person.Phone,person.Id).Count> 0)
            {
                HttpContext.Session.GetString("userCompanySession");
                ViewBag.Message = "Algunos valores ya estan en uso";
                ViewBag.Person = person;
                return View("EditPerson","CondominosPerson");
            }


            Persons.Persons.updatePerson(person);
            HttpContext.Session.GetString("userCompanySession");
            return RedirectToAction("mainmenu","MainMenu"); 
        
        
        }


        // GET: CondominiosPersonController/Create
        public ActionResult CreatePerson()
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
