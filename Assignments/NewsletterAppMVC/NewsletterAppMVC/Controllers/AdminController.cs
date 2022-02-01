using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            //=== ADO.NET - First Method
            //==
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from SignUps";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using(SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read()) 
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup); //populate business model object List
            //    }
            //}

            //=== Entity Framework Calls
            //==
            using (NewsletterEntities db = new NewsletterEntities()) //instantiate object to get access to database
            {
                //Lambda syntax:
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList(); // get and assign db records to variable signups

                //LINQ, alternatively:
                var signups = (from c in db.SignUps
                               where c.Removed == null 
                               select c).ToList();
                var signupVms = new List<SignupVm>(); // new list of view models

                foreach (var signup in signups) //map view models from model to view model
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms); //pass this list to view model to view 
            }
        }

        public ActionResult Unsubscribe(int Id) //hit the button, gets the id...
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id); //passing in primary key, find the record
                signup.Removed = DateTime.Now; //changes removed column to datetime
                db.SaveChanges(); 
            }
            return RedirectToAction("Index");
        }
    }
}