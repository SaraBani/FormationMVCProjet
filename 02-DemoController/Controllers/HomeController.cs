using _02_DemoController.Models;
using _02_DemoController.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace _02_DemoController.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //1-une action qui peut retourner un autre vue
            //action avec un resultat de type WiewResult
            //return View("Contact");

            //elle permet d'envoyer au client un ordre de redirection vers l'URL qui est dans la paramétre de la méthode
            //return Redirect("/Home/Contact");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
           /*return RedirectToAction("Index", "Test", new { nom = "Dawan", prenom = "Formation" });*/
           /*return RedirectToRoute("ContactDetails");*/
           /*return File(Server.MapPath("~/Demo.txt"), "text/plain", "test.txt");*/

          return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            /*return Content("Ceci est le contenu de l'action");*/
            /*return Content("<Personne><nom>Dawan</nom><perenom>Jehan</prenom></Personne>", "text/xml", Encoding.UTF8);*/
            /*return null;*/
            /*return JavaScript("alert('test de la methode JavaScript')");*/

            Personne p = new Personne { Nom = "Dawan", Prenom = "Jehan" };
            //Action avec un resultat de type JsonResult
            //return Json(p, JsonRequestBehavior.AllowGet);

            string str = MyJsonTool.ToJson<Personne>(p);
            byte[] contenu = Encoding.UTF8.GetBytes(str);
            //return File(contenu, "application/json", "personne.json");

            //return HttpNotFound();

            //return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Mauvais requête");

            return new HttpUnauthorizedResult("Autorisation refusée");

            /*return View();*/
        }
    }
}