using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5]; // create an array object of integers called numArray, with array length
            // assign values to the array, matching array size
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            Console.WriteLine(numArray[3]);
            Console.WriteLine("Press Enter to display second array result");
            Console.ReadLine();

            // Alternative method for array - SAME OUTPUT AND DATA AS ABOVE
            int[] numArray2 = new int[] { 5, 2, 10 , 200, 5000};
            Console.WriteLine(numArray2[1]);
            Console.ReadLine();
        }
    }
}
