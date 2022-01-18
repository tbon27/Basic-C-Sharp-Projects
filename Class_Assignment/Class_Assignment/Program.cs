using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Divider demoClass = new Divider(); // instantiate class Divider
            
            Console.WriteLine("Please enter a number...");
            int userInput = Convert.ToInt32(Console.ReadLine()); // take user input and conver str to int, assign to userInput

            demoClass.DivideMethod(userInput); // call method, result is userInput / 2, and results displayed
            Console.WriteLine("Press any key to go to output parameter demo...");

            Console.ReadLine();

            //Create a method with output parameters.
            int x = 5; //set initial value
            Console.WriteLine("Starting value = {0}", x);
            Console.WriteLine("Press any key to run method...");
            Console.ReadLine();

            demoClass.OutDemo(out x); // call method using output parameter, get initial value set in method (20)
            Console.WriteLine("Value after using method = {0}", x);
            Console.ReadLine();

            Console.WriteLine("Press any key to go to overload demo...");
            Console.ReadLine();

            //Overload a method
            string input1 = "ORIGINAL STRING"; //this will change depending on the overloaded method
            Console.WriteLine("Original string = " + input1);
            Console.WriteLine("Press any key to run method...");
            Console.ReadLine();
            demoClass.OutDemo(input1); // call method, results will reflect the string words in the method
            Console.ReadLine();

            Console.WriteLine("Press any key to go to static class demo...");
            Console.ReadLine();

            // Declare a class to be static
            Console.WriteLine("Sport #1: "+ MyStaticClass.sport1); //get data from static class
            Console.WriteLine("Sport #2: "+ MyStaticClass.sport2); //get data from static class
            Console.WriteLine("Sport #3: "+ MyStaticClass.sport3); //get data from static class
            Console.ReadLine();
            

        }

    }
}
