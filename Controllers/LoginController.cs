using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Proyecto.Models;
using Proyecto.DatabaseHelper;
//using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using Newtonsoft.Json;

namespace Proyecto.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult login()
        {
           return View();
        }

        public ActionResult login2()
        {
            return View();
        }



        public ActionResult ValidatePersonLogin(string txtUsuario,string txtPassword)
        {

            if (Persons.Persons.ValidateLoginPerson(txtUsuario, txtPassword).User ==null)
            {
                ViewBag.Message = "Error en el usuario o contraseña";
                return View("login2");
            }

            HttpContext.Session.SetString("userPersonSession", txtUsuario);
            return RedirectToAction("dasboardperson", "DashboardPerson");
        }

        //validacion compañia
        public ActionResult ValidateCompanyLogin(string txtCorreo, string txtPassword)
        {

            if (Companies.Companies.ValidateLoginCompany(txtCorreo, txtPassword).CedJur == null)
            {
                ViewBag.Message = "Error en el usuario o contraseña";
                return View("login2");
            }
            string strCompany = JsonConvert.SerializeObject(Companies.Companies.ValidateLoginCompany(txtCorreo, txtPassword));

            HttpContext.Session.SetString("userCompanySession",strCompany);
            return RedirectToAction("companyview", "CompanyView");
        }





        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
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

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View("Index");
        }

        // POST: LoginController/Edit/5
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

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
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
