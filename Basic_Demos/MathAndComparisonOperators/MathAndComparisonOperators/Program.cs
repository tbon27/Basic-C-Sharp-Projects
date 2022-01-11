using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Addition opertations
            int total = 5 + 10;
            int total_2 = 20 + 210;
            int combinedTotal = total + total_2;
            Console.WriteLine("Total 1 = Five plus ten equals: " + total.ToString());
            Console.WriteLine("Total 2 = twenty plus two hundred and ten equals: " + total_2.ToString());
            Console.WriteLine("Combined total is: " + combinedTotal.ToString());
            Console.ReadLine();

            // Subtration/difference
            int difference = 21 - 7;
            Console.WriteLine("Twenty one minus seven is " + difference.ToString());
            Console.ReadLine();

            // Multiplication/product
            int product = 39 * 23;
            Console.WriteLine("The product of thirty nine and twenty three = " + product);
            Console.ReadLine();

            // Division - This is using INT, this will round to whole numbers(change to double, etc otherwise)
            int quotient = 60 / 20;
            Console.WriteLine(quotient);
            Console.ReadLine();

            // Modulus / remainders
            int mod = 12 % 5; // the remainder of 12 divided by 5, which is 2 (10 rem 2)
            Console.WriteLine(mod);
            Console.ReadLine();

            // Boolean
            bool trueOrFalse = 17 > 15;
            bool trueOrFalse_2 = 12 > 15;
            Console.WriteLine(trueOrFalse);
            Console.WriteLine(trueOrFalse_2);
            Console.ReadLine();

            int roomTempSet= 70;
            int currentTemperature = 70;
            // Example - Temp is low, heating should engage
            int currentTemperatureLow = 69;
            // Example - Temp is high, cooling should engage
            int currentTemperatureHigh = 71;

            bool isSetTemp = currentTemperature == roomTempSet; // current temp matches room set temp
            bool isTooCool = currentTemperatureLow < roomTempSet; //if current temp is less than set temp then set bool isToolCool to true
            bool isTooWarm = currentTemperatureHigh > roomTempSet; // if current temp is greater than aet temp then set bool isTooWarm to true
            Console.WriteLine(
                "Desired Room Temperature set to: " + roomTempSet.ToString() +  
                "\nTemperature (lo example) = " + currentTemperatureLow.ToString() + " Heating is running now..."+ 
                "\nTemperature (hi example) = " + currentTemperatureHigh.ToString() + " Cooling is running now...");
            Console.ReadLine();

        }
    }
}
