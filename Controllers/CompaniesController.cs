using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;
using System.Numerics;

namespace Proyecto.Controllers
{
    public class CompaniesController : Controller
    {
        // GET: CompaniesController
        public ActionResult companies()
        {
            return View();
        }

        // GET: CompaniesController/Details/5

        public ActionResult InsertCompany(string txtNombre,string txtDirrec, string txtCedJur, string txtTelefono, string txtCorreo, string txtContra, IFormFile logo)
        {
            string nameLogo = txtCedJur + ".Jpg";

            using (var stream = new FileStream(Directory.GetCurrentDirectory() + "\\wwwroot\\logos"+nameLogo,FileMode.Create))
            {
                logo.CopyTo(stream);
            }

            Company company = new Company()

            {
                Name = txtNombre,
                Location = txtDirrec,
                CedJur = txtTelefono,
                Phone = txtTelefono,
                Email = txtCorreo,
                Password = txtContra,
                Logo = "\\wwwroot\\logos" + nameLogo
            };

            

            if (Companies.Companies.ValidateCompany(txtCorreo, txtCedJur) != null)
            {
                ViewBag.Message = "EL correo o la cédula jurídica se encuentra registrada";
                return View("companies");
            }else
                 
            Companies.Companies.InsertCompanie(company);

            return View();
        }


        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CompaniesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CompaniesController/Create
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

        // GET: CompaniesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CompaniesController/Edit/5
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

        // GET: CompaniesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CompaniesController/Delete/5
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
