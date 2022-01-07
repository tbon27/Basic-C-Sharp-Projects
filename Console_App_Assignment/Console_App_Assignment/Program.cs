using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculation #1 
            Console.WriteLine("#1: Please enter a number to be multiplied by 50: ");
            string userInput = Console.ReadLine(); // Take user input as string
            int userNumber = Convert.ToInt32(userInput); // Take userInput str and convert to int

            int userMultiply = userNumber * 50; // mutiply user number by 50
            Console.WriteLine("Calculation #1 = " + userMultiply); // print userMultiply result

            // Calculation #2 
            Console.WriteLine("#2: Please enter a number to be added to 25: ");
            userInput = Console.ReadLine(); // Take user input as string (overwrite str variable userInput used earlier)
            userNumber = Convert.ToInt32(userInput); // Take userInput str and convert to int

            int userAddition = userNumber + 25; // userNumber add 25 and result is set to int userAddition
            Console.WriteLine("Calculation #2 = " + userAddition); // display result

            // Calculation #3 
            Console.WriteLine("#3: Please enter a number to be divided by 12.5: ");
            userInput = Console.ReadLine(); // Take user input as string (overwrite str variable userInput used earlier)
            userNumber = Convert.ToInt32(userInput); // Take userInput str and convert to int

            double userDivide = userNumber / 12.5; // use double for decimals, divide userNumber by 12.5 and assign to userDivide
            Console.WriteLine("Calculation #3 = " + userDivide); // display result

            // Calculation #4 
            Console.WriteLine("#4: Please enter a number to check if it is greater than 50: ");
            userInput = Console.ReadLine(); // Take user input as string (overwrite str variable userInput used earlier)
            userNumber = Convert.ToInt32(userInput); // Take userInput str and convert to int

            bool userBool = userNumber > 50; // create bool, if userNumber is greater than 50 then true, otherwise false
            Console.WriteLine("Calculation #4: " + userNumber + " is greater than 50: " + userBool); // display results


            // Calculation #5 
            Console.WriteLine("#5: Please enter a number to check its remainder when divided by 7: ");
            userInput = Console.ReadLine(); // Take user input as string (overwrite str variable userInput used earlier)
            userNumber = Convert.ToInt32(userInput); // Take userInput str and convert to int

            double userMod = userNumber % 7; // use double for resulting userMod, remainder of userNumber divided by 7
            Console.WriteLine("Calculation #5: " + userNumber + " divided by 7 has a remainder of: " + userMod); // display remainder results
        }
    }
}
