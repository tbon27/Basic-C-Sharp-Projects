using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment
{
    public class MathOperation
    {
        public void Method1(int number1, int number2)
        { 
            int result1 = number1 * 200; // do math and assign to int result1
            
            Console.WriteLine("The result of " + number1.ToString() +" multiplied by 200 is: "+ result1.ToString() + "\nThe value of the second integer is: " + number2.ToString());
        }
    }
}
