using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations operations = new MathOperations(); //create instance of class MathOperations

            Console.WriteLine("Please enter a whole number to perform math operations on: ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //take in user input

            int resultAddition = operations.Add(userInput); //using userInput as the value to be calculated with, assign result of method in result int var
            Console.WriteLine("Addition calculation: " + userInput.ToString() + " plus 20 equals " + resultAddition.ToString()); //display result

            int resultSubtraction = operations.Subtract(userInput);  //using userInput as the value to be calculated with, assign result of method in result int var
            Console.WriteLine("Subtraction calculation: " + userInput.ToString() + " minus 2 equals " + resultSubtraction.ToString()); //display result

            int resultMultiplication = operations.Multiply(userInput);  //using userInput as the value to be calculated with, assign result of method in result int var
            Console.WriteLine("Multiplication calculation: " + userInput.ToString() + " multiplied by 50 equals " + resultMultiplication.ToString()); //display result

            Console.WriteLine();
        }
    }
}
