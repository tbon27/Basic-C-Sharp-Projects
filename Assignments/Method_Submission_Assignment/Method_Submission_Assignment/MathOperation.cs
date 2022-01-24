using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission_Assignment
{
    public class MathOperation
    {
        public int DoMath(int number1, int number2 = 0) // 2 integers as parameters, one is optional, default is set to 0
        {
            int result = number1 + number2 + 1000; // add all values, and add 1000
            return result;
        }
    }
}
