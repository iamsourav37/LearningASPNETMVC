using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ContentResult PlainText()
        {
            return Content("Be Your Own Hero", "text/plain");
        }

        public ContentResult HtmlText()
        {
            return Content("<h1>Bengali Detectives: Byomkesh Bakshi, Feluda</h1.", "text/html");
        }
        
        public ContentResult JsonText()
        {
            string jsonString = "{\"Root\": {\"Name\":\"Sourav Ganguly\"}}";
            return Content(jsonString, "text/json");
        }
        
    }
}