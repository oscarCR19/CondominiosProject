using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proyecto.Controllers
{
    public class CasasCondominioController : Controller
    {
        // GET: CasasCondominioController
        public ActionResult createCasa(string txtIdCond)
        {
            Condominios.Condominios.CrearCasa(txtIdCond);
            return RedirectToAction("mainmenu", "MainMenu");
        }

        public ActionResult EditCasa()
        {
            return View();
        }

        public ActionResult GetCasa(string txtIdCond)
        {
            ViewBag.ListaCasas= Condominios.Condominios.GetCasasPorCondominios(txtIdCond);
            return View();
        }

        public ActionResult deleteCasa(string txtIdCas)
        {
            Condominios.Condominios.DeleteCasa(txtIdCas);
            return RedirectToAction("mainmenu", "MainMenu");
        }










    }
}
