using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03_PassingDataToWiew.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index(int? id)
        {
            //ViewData: un dictionnaire d'objets (clé,valeur), il contient donc des paires clé-valeur
            //ou chaque clé doit être une chaine de caractère
            //ViewBag: c'est le même objet que ViwData

            if(id.HasValue)
            {
                ViewData["ID"] = id.Value;
            }
            else
            {
                ViewData["ID"] = 0;
            }


            if (id.HasValue)
            {
                ViewBag.Id = id.Value;
            }
            else
            {
                ViewBag.Id = 0;
            }


            if (id.HasValue)
            {
                TempData["ID"] = id.Value;
            }
            else
            {
                TempData["ID"] = 0;
            }

            TempData.Keep(); 
            return View();
        }*/
        //Get
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string nom)
        {
            ViewBag.Nom = nom;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}