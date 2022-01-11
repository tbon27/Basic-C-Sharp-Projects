using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("Please enter the weight of the package: ");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine()); // take in user input as string and convert to decimal; assign to packageWeight

            if (packageWeight > 50) // if user inputs package weight greater than 50, run this block
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else // if user enters a package weight <= 50, continue with this block
            {
                Console.WriteLine("Please enter the width of the package: ");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine()); // take in user input as string and convert to decimal; assign to packageWidth

                Console.WriteLine("Please enter the height of the package: ");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine()); // take in user input as string and convert to decimal; assign to packageHeight

                Console.WriteLine("Please enter the length of the package: ");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine()); // take in user input as string and convert to decimal; assign to packageLength


                decimal dimensionsTotal = packageWidth + packageLength + packageHeight; // calculate the dimensions total
                if (dimensionsTotal > 50) // If the dimensions total greater than 50, display the error message..
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else // if dimensions are <= 50, run this block
                {
                    decimal resultQuote = ((packageHeight * packageLength * packageWidth) * packageWeight) / 100; // result of this calc is the quote
                    Console.WriteLine("Your estimated total for shipping this package is: $" + resultQuote.ToString("F2")); // return the quote to user (F2 - 2 decimal spots)
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
