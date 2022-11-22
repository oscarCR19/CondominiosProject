using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using Proyecto.Models;
using Proyecto.DatabaseHelper;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Proyecto.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        public ActionResult Index()
        {
            //ViewBag.Employees = false;
            //ViewBag.Sales = false;

            return View();
        }

        [HttpPost]
        public ActionResult ValidateLogin(string txtUser, string txtPassword)
        {
            User? user = GetUser(txtUser, txtPassword);

            if (user != null)
            {
                string strUser = JsonConvert.SerializeObject(user);

                HttpContext.Session.SetString("userSession", strUser);

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = new ErrorHandler()
                {
                    Title = "Invalid Login",
                    ErrorMessage = "Incorrect User or Password",
                    Path = "/Login"
                };

                return View("ErrorHandler");
            }
        }

        private User? GetUser(string txtUser, string txtPassword)
        {
            DataTable ds = DatabaseHelper.DatabaseHelper.ExecuteStoreProcedure("[dbo].[spGetUser]", new List<SqlParameter>()
            {
                new SqlParameter("@NombreUsuario", txtUser),
                new SqlParameter("@Password", txtPassword)
            });

            if (ds.Rows.Count > 0)
            {
                User user = new User
                {
                    IdEstudiante = Convert.ToInt16(ds.Rows[0]["IdEstudiante"]),
                    NombreCompleto = ds.Rows[0]["NombreCompleto"].ToString(),
                    Cedula = ds.Rows[0]["Cedula"].ToString(),
                    NombreUsuario = ds.Rows[0]["NombreUsuario"].ToString(),
                    Password = ds.Rows[0]["Password"].ToString(),
                    IdRol = Convert.ToInt16(ds.Rows[0]["IdRol"]),
                };

                return user;
            }
            else
            {
                return null;
            }
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
