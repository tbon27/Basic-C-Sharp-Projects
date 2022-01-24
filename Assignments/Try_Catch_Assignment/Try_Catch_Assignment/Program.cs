using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //1. Create a list of integers.
                List<int> numList = new List<int>();
                numList.Add(1);
                numList.Add(15);
                numList.Add(37);
                numList.Add(80);
                numList.Add(22);
                numList.Add(31);
                numList.Add(4);
                numList.Add(98);
                numList.Add(127);
                numList.Add(45);
                numList.Add(87);

                //2. Ask the user for a number to divide each number in the list by.
                Console.WriteLine("Please enter a non-zero, whole number to divide each number in our list by:\nNote: result is rounded. ");
                int userNumber = Convert.ToInt32(Console.ReadLine()); //take user input

                //3. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                foreach (int num in numList)
                {
                    int result = num / userNumber; // store the calculation in result
                    Console.WriteLine(num.ToString() + " divided by " + userNumber.ToString() + " equals " + result.ToString());
                }
                Console.ReadLine();
            }

            //5. put the loop in a try/catch block, 
            catch (FormatException ex)
            {
                Console.WriteLine("Error Message: " + ex.Message + " \nEnter a number!"); //5. display the error message to the screen
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error Message: " + ex.Message + " \nDon't divide by 0!"); //5. display the error message to the screen
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message: " + ex.Message); //5. display the error message to the screen
            }
            finally //5. print a message to let user know the program has emerged from the try/catch block and continued on with program execution
            {
                Console.WriteLine("The program has emerged from the try/catch block; continuing program...\nPress enter. ");
                Console.ReadLine();
            }
 
            Console.WriteLine("The program will end now.\nPress enter.");
            Console.ReadLine();

        }
    }
}
