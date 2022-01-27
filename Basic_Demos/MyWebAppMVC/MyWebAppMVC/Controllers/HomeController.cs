using MyWebAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebAppMVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            //string text = "Hello! The date and time is: " + DateTime.Now;
            //System.IO.File.WriteAllText(@"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\Basic_Demos\MyWebAppMVC\Logs\log.txt", text);

            //Random rnd = new Random(10);
            //int num = rnd.Next();

            //ViewBag.RandomNumber = num;
            User user = new User();
            user.id = 1;
            user.FirstName = "Tony";
            user.LastName = "Bongiovanni";
            user.Age = 32;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //throw new Exception("Invalid Page");
            return View();
        }

        public ActionResult Contact(int id = 110)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}