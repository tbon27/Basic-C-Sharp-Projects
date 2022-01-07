using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print title of program
            Console.WriteLine("The Tech Academy"); 
            Console.WriteLine("Student Daily Report");

            // Ask user a question
            Console.WriteLine("What is your name?");
            // Get user input (name) as string
            string studentName = Console.ReadLine();

            // Ask user a question
            Console.WriteLine("What course are you on?");
            // Get user input (course) as string
            string courseName = Console.ReadLine();

            // Ask user a question
            Console.WriteLine("What page number?");
            // Get user input (page) as string
            string page = Console.ReadLine();
            // Convert string input to int
            int pageNumber = Convert.ToInt32(page);

            // Ask user a question
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            // Get user input
            string help = Console.ReadLine();
            // Convert string input to boolean
            bool helpNeeded = Convert.ToBoolean(help);

            // Ask user a question
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string extraFeedback = Console.ReadLine();
         
            // Ask user a question
            Console.WriteLine("How many hours did you study today?");
            // Get user input (hours) as string
            string hours = Console.ReadLine();
            // Convert string input to int
            int hoursStudied = Convert.ToInt32(hours);

            // Final response and end of program
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.WriteLine("Summary of Responses: ");
            //Summary of responses
            Console.WriteLine("Student Name: " + studentName + "\nCourse Name: " + courseName + "\nPage Number: " + pageNumber + "\nIs Help Needed? " + helpNeeded + "\nExtra Feedback: " + extraFeedback + "\nHours Studied: " + hoursStudied);
        }
    }
}
