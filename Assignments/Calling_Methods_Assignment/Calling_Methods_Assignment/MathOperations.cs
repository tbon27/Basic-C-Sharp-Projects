using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    public class MathOperations //create class
    {
        public int Add(int input) //create method requiring one int parameter
        {
            return input + 20; //do calculation when called
        }   
        public int Subtract(int input) //create method requiring one int parameter
        {
            return input - 2; //do calculation when called
        }   
        public int Multiply(int input) //create method requiring one int parameter
        {
            return input * 50; //do calculation when called
        }
    }
}
