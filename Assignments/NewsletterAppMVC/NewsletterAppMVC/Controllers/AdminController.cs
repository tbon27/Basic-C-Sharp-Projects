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
                var signups = db.SignUps; // assign db records to variable signups
                var signupVms = new List<SignupVm>(); // new list of view models
                foreach (var signup in signups) //map view models from model to view model
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms); //pass this list to view (just cause we're passing Id doesn't mean we need to display it)

            }
        }
    }
}