using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine()); //get user input
                if (userInput < 1) throw new ArgumentOutOfRangeException(); //if user input is 0 or negative number, throw specific exception
                int currentYear = DateTime.Now.Year; //assign current year to int variable
                int yearBorn = currentYear - userInput; //calc yearBorn

                Console.WriteLine(yearBorn); //display
            }
            catch (ArgumentOutOfRangeException) //using specific exception; we want positive numbers
            {
                Console.WriteLine("Please enter positive, non-zero numbers...");
                Console.ReadLine();
                return;
            }
            catch (Exception) //general exception
            {
                Console.WriteLine("An error occured, please contact your System Administrator");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
