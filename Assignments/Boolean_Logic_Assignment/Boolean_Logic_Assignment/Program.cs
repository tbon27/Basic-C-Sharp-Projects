using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Boolean Logic Demo!");
            
            Console.WriteLine("What is your age?");
            string userAge_input = Console.ReadLine(); // take user input as string
            int userAge = Convert.ToInt32(userAge_input); // convert string to int and store as user age

            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\"");
            string userDUI_input = Console.ReadLine(); // take user input as string
            bool userDUI_status = Convert.ToBoolean(userDUI_input); // convert string to boolean and store as dui status (true or false)
            //Console.WriteLine("(status:" + userDUI_status + ")"); //debugging

            Console.WriteLine("How many speeding tickets do you have?");
            string userTickets_input = Console.ReadLine(); // take user input as string
            int userSpeedingTickets = Convert.ToInt32(userTickets_input); // convert string to int and store as user number of speeding tickets


            Console.WriteLine("Press any key to determine if you qualify for car insurance...");
            Console.ReadLine();
            bool canBeInsured = (userAge >= 15 && userDUI_status == false && userSpeedingTickets <= 3); // if age is greater than 15, no dui, and 3 or less speeding tickets
            
            if(canBeInsured) // if canBeInsured is true, meets all conditions set above
            {
                Console.WriteLine("Congrats - You Qualify! We can insure you!"); // if true display this
            }
            else
            {
                Console.WriteLine("Unlucky - You do not Qualify! No, we cannot insure you."); // if can be insured is false display this
            }

            Console.ReadLine();
        }
    }
}
