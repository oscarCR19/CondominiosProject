using MVCondominios.Models;
using Microsoft.AspNetCore.Mvc;
//using MVCondominios.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace MVCondominios.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("userSession")))
            {
                ViewBag.User = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("userSession"));

                //ViewBag.Employees = true;
                //ViewBag.Sales = true;

                return View();
            }
            else
            {
                ViewBag.Error = new ErrorHandler()
                {
                    Title = "You must need to login to access this page",
                    ErrorMessage = "Please login",
                    Path = "/Login"
                };

                return View("ErrorHandler");
            }
        }

        public IActionResult CreateVisitas()
        {
            return View();
        }

        public IActionResult CreateCondominios()
        {
            return View();
        }

        [HttpPost]
        //public IActionResult GuardarVisita(string txtIdMovie, string txtName, string selectGenere, string txtDate)
        //{

        //    Movies movie = new Movies()
        //    {
        //        IdMovie = Convert.ToInt32(txtIdMovie),
        //        Name = txtName,
        //        Genere = selectGenere,
        //        Date = txtDate,
        //        Photo = "/images/0.jpg",
        //    };

        //    DatabaseHelper.DatabaseHelper.CreateMovie(movie);

        //    return RedirectToAction("Index", "Home");
        //}


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}