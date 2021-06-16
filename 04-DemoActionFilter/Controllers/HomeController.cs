using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04_DemoActionFilter.Controllers
{
    //[Authorize] 
    public class HomeController : Controller
    {
        [AllowAnonymous] //Permet d'autoriser l'accés à des utilisateurs non authentifier à des actions individuelle
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            TempData["Heure"] = DateTime.Now.ToLongTimeString();
            return View();
        }
        //1-Ce filtre gére les cas d'autorisation
        //[Authorize] //Action accéssible uniquement par les user Connectés
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HandleError]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            throw new Exception("Mon Exception");

            //return View();
        }
    }
}