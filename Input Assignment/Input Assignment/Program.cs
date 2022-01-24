using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\Input Assignment\Logs\log.txt", false)) //false creates new files
            {
                file.WriteLine(userInput); // write cards to text file
            }
            Console.ReadLine();
        }
    }
}
