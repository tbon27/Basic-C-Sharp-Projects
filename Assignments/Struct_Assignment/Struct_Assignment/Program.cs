using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(); //create new instance of Number() called number
            Number number2 = number; //demo: set number to struct type Number named number2
            number.numberStruct = 2; // set number to 2
            number2.numberStruct = 7; // set demo number2 to 7
            Console.WriteLine(number.numberStruct); //using struct, will print 2 - class will print 7 (overwriting 2)
        }

    }
}
