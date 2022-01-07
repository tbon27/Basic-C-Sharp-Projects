using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName + "!");
            //Console.ReadLine();

            //Console.WriteLine("What is your favorite number?");
            //string favNumStr = Console.ReadLine();
            //int favNumInt = Convert.ToInt32(favNumStr);
            //int total = favNumInt + 101;
            //Console.WriteLine("Your favorite number is " + favNumInt);
            //Console.ReadLine();
            //Console.WriteLine("Your favorite number added to 101 is " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42; // 8-bit unsigned integer - byte is 0-255
            sbyte currentTemperature = -23; // signed 8-bit (1-byte) integers - sbyte is -128 through 127
            char questionMark = '\u2103'; // unicode question mark
            Console.WriteLine(questionMark);

            decimal moneyInBank = 100.5m;
            Console.WriteLine(moneyInBank);

            int currentAge = 32;
            string yearOld = currentAge.ToString();
            Console.WriteLine(yearOld);

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);

        }
    }
}
