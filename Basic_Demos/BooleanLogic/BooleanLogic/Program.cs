using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND Operator &&
            Console.WriteLine(true && false); //false
            Console.WriteLine(true && true); //true
            Console.WriteLine(false && false); //false

            // OR Operator ||
            Console.WriteLine(true || true); //true
            Console.WriteLine(true || false); //true
            Console.WriteLine(false || false); //false

            // Equal to operator ==
            Console.WriteLine(true == true); //true
            Console.WriteLine(true == false); //false
            Console.WriteLine(false == false); //true

            //does not equal operator !=
            Console.WriteLine(true != true); //false
            Console.WriteLine(true != false); //true
            Console.WriteLine(false != false); //false

            // XOR operator - if one is true but NOT BOTH
            Console.WriteLine(true ^ true); //false
            Console.WriteLine(true ^ false); //true
            Console.WriteLine(false ^ false); //false

            Console.ReadLine();
        }
    }
}
