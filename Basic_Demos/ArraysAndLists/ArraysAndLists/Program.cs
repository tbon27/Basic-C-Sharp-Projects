using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //===========================
            //==== ARRAY FUNDAMENTALS ===
            //===========================
            // Arrays are mainly for a fixed quantity
            //int[] numArray = new int[5]; // create an array object of integers called numArray, with array length
            //// assign values to the array, matching array size
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //Console.WriteLine(numArray[3]);
            //Console.WriteLine("Press Enter to display second array result");
            //Console.ReadLine();

            //// Alternative method for array
            //int[] numArray2 = new int[] { 5, 2, 10 , 200, 5000, 600, 2300};
            //Console.WriteLine(numArray2[5]);
            //Console.WriteLine("Press Enter to display third array result");
            //Console.ReadLine();

            //// ANOTHER Alternative method for array
            //int[] numArray3 = { 5, 2, 10, 200, 5000, 600, 2300};
            //Console.WriteLine(numArray2[6]);
            //Console.ReadLine();

            //===========================
            //==== LIST FUNDAMENTALS ====
            //===========================

            List<int> intList1 = new List<int>();
            intList1.Add(4);
            intList1.Add(10);
 
            Console.WriteLine(intList1[0]);
            Console.WriteLine(intList1[1]);

            intList1.Remove(4);
            Console.WriteLine(intList1[0]);

            Console.ReadLine();
        }
    }
}
