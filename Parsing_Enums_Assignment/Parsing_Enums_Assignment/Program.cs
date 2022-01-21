using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment
{
    class Program
    {
        enum DaysOfTheWeek //create enum
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week: ");
            
            string userInput = Console.ReadLine(); // take in user input
            userInput = userInput.ToLower(); //assign input to lower cases

            DaysOfTheWeek day;
            try
            {
               day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput); // parse enum type DaysOfTheWeek, looking for userInput string
                                                                                  // now asssigned enum data type        
                                                                                  // [public static object Parse(Type enumType, string value);]

                Console.WriteLine(day + " exists in the enum");
                Console.ReadLine();
            }
            catch (Exception ex) // if there is an error
            {
                Console.WriteLine("Please enter an actual day of the week...");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
