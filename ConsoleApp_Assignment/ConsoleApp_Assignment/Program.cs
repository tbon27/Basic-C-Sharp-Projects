using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE STATEMENT DEMO - COUNTDOWN FROM 5 to 1

            int count = 5; // start counter at 5
            //bool isCounting = false; // set bool to false by default

            while (count > 0) // while isCounting is true (is not false)
            {
                Console.WriteLine(count); //display current count
                count--; // decrement count by one

                if (count < 1) //if count is less than 1
                {
                    Console.WriteLine("BLASTOFF!"); // display blastoff messsage
                }
                if (count == 0) // if count is equal to 0 break out of while loop
                    break;
            }

            // DO WHILE STATEMENT DEMO - Guess my Fave Day of the Week

            Console.WriteLine("Guess my favorite day of the week: ");
            Console.WriteLine("(Tip: Enter \"monday\", \"tuesday\", \"wednesday\", \"thursday\", \"friday\", \"saturday\", \"sunday\")");
            string userGuess = Console.ReadLine(); // take user input and assign to userGuess string var
            bool isCorrect = userGuess == "friday"; // assign user guess "friday" as userGuess var as the true/isCorrect bool

            do // make sure to run at least once
            {
                switch (userGuess) // user guesses/options in switch statement with default case
                {
                    case "monday":
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Guess my favorite day of the week: ");
                        userGuess = Console.ReadLine();
                        break;
                    case "tuesday":
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Guess my favorite day of the week: ");
                        userGuess = Console.ReadLine();
                        break;
                    case "wednesday":
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Guess my favorite day of the week: ");
                        userGuess = Console.ReadLine();
                        break;
                    case "thursday":
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Guess my favorite day of the week: ");
                        userGuess = Console.ReadLine();
                        break;
                    case "friday":
                        Console.WriteLine("You're right! TGIF!");
                        isCorrect = true; // since answer is a match, change bool to true (will stop the do while)
                        break;
                    case "saturday":
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Guess my favorite day of the week: ");
                        userGuess = Console.ReadLine();
                        break;
                    case "sunday":
                        Console.WriteLine("Wrong!");
                        Console.WriteLine("Guess my favorite day of the week: ");
                        userGuess = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("I don't recognize that day of the week...");
                        Console.WriteLine("(Tip: Enter \"monday\", \"tuesday\", \"wednesday\", \"thursday\", \"friday\", \"saturday\", \"sunday\")");
                        userGuess = Console.ReadLine();
                        break;
                }
            }
            while (!isCorrect); // run while isCorrect is not userGuess == "friday" (while user guess is not correct)
            Console.ReadLine();
        }
    }
}

    


