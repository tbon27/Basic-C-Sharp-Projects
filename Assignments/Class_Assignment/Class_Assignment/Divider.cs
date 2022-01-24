using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Divider
    {
        public void DivideMethod(int number) //create void method that outputs int
        {
            int result = number / 2; // do math on input passed and assign to result
            Console.WriteLine("The result of {0} divided by 2 is: " + result, number);
        }        
        
        public void OutDemo(out int number2) // use output parameters to reference number2
        {
            int valueAfterMethod = 20;
            number2 = valueAfterMethod;
        }
        public void OutDemo(string string1) //overload OutDemo with string
        {
            string outputWords = "This string is part of the overloaded OutDemo() method.";
            Console.WriteLine(outputWords);
        }
    }
}
