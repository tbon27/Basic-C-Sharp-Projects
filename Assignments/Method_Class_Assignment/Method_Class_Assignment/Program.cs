using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation operations = new MathOperation(); // instantiate class MathOperation

            operations.Method1(1, 2); // Call the method in the class, passing in two numbers.
            Console.WriteLine("Press any key to continue:");
            Console.ReadLine();

            operations.Method1(number1: 11, number2: 14); // Call the method in the class, specifying the parameters by name.
            Console.ReadLine();

        }
    }
}
