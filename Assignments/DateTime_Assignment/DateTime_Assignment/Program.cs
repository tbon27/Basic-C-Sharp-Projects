using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date and time: " + DateTime.Now); // display current date/time
            Console.WriteLine("Press enter...");
            Console.ReadLine();
            Console.WriteLine("Please enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //get user input, convert to int and set to userInput
            DateTime inXhours = DateTime.Now.AddHours(userInput); //get current date and time, and add hours using userInput, set this to DateTime type variable inXhours
            Console.WriteLine("In {0} hours, the date and time will be: " + inXhours, userInput); //display result of userInput added to current hour
        }
    }
}
