using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation mathOps = new MathOperation(); // create instance of the class

            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine()); // take user input and convert to int, assign to userInput
            
            Console.WriteLine("Enter another number, or press Enter to leave blank:");
            string input2 = Console.ReadLine(); // take second number from user as string
            if (input2 == "")//if blank, run first if block
            {
                int result1 = mathOps.DoMath(number1: userInput); // call DoMath method passing users first response
                Console.WriteLine("Result of {0} plus 0 (default) plus 1000 is " + result1, userInput);
                Console.ReadLine();
            }
            else // if value entered in by user is valid run this else block
            { 
                int userInput2 = Convert.ToInt32(input2);
                int result2 = mathOps.DoMath(number1: userInput, number2: userInput2); // call DoMath method passing both of users responses
                Console.WriteLine("Result of {0} plus {1} plus 1000 is " + result2, userInput, userInput2);
                Console.ReadLine();
            }
        }
    }
}
