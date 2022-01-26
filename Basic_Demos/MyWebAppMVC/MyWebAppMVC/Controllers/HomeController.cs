using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //test
        public ActionResult Index()
        {
            string text = "Hello! The date and time is: " + DateTime.Now;
            System.IO.File.WriteAllText(@"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\Basic_Demos\MyWebAppMVC\Logs\log.txt", text);

            Random rnd = new Random(10);
            int num = rnd.Next();

            ViewBag.RandomNumber = num;
            
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