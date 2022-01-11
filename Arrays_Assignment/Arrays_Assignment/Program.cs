using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part #1:
            string[] strArray1 = { "red", "green", "blue", "purple", "yellow", "orange", "white", "black", "pink"}; // assign strings of color names to string array
            Console.WriteLine("Please enter a number/index between 0 and 8"); 
            int userInput1 = Convert.ToInt32(Console.ReadLine()); // take user input and convert from string to int

            if (userInput1 > strArray1.Length || userInput1 < 0) // if input is outside the index display this
            {
                Console.WriteLine("This array does not contain this index...");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else // input index is within range and valid, run this
            {
                Console.WriteLine("You have chosen index #" + userInput1 + ".\nThis results in color: " + strArray1[userInput1]); //display results
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

            // Part #2:
            int[] intArray1 = {15, 22, 2, 7003, 432, 43, 987}; // assign ints to int array
            Console.WriteLine("Please enter a number/index between 0 and 6");
            int userInput2 = Convert.ToInt32(Console.ReadLine());  // take user input and convert from string to int

            if (userInput2 > intArray1.Length || userInput2 < 0) // if input is outside the index display this
            {
                Console.WriteLine("This array does not contain this index...");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else // input index is within range and valid, run this
            {
                Console.WriteLine("You have chosen index #" + userInput2 + ".\nThis results in number: " + intArray1[userInput2]); //display results
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }

            // Part #3: added in a message that displays when the user selects an index that doesn’t exist.
            // Part #4: LIST of strings
            List<string> strList1 = new List<string>(); // create a list and initialize strList1
            strList1.Add("tree");
            strList1.Add("river");
            strList1.Add("mountain");
            strList1.Add("lake");
            strList1.Add("rock");

            Console.WriteLine("Please enter a number/index between 0 and 4");
            int userInput3 = Convert.ToInt32(Console.ReadLine());  // take user input and convert from string to int


            if (userInput3 > strList1.Count || userInput3 < 0) // if input is outside the index display this
            {
                Console.WriteLine("This array does not contain this index...");
                Console.WriteLine("Press enter to continue...");
                Console.ReadLine();
            }
            else // input index is within range and valid, run this
            {
                Console.WriteLine("You have chosen index #" + userInput3 + ".\nThis results in string item: " + strList1[userInput3]); //display results
                Console.ReadLine();
            }
        }
    }
}
