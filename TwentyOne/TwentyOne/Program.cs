using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player newPlayer = new Player("Tony"); //demo- constructor callchain
            //var newPlayer = new Player("Tony"); // var demo- C# figures out data type on the fly

            const string casinoName = "Grand Hotel and Casino";//declaring constant demo - const cannot change

            Console.WriteLine("Welcome to the {0}! Let's start by telling me your name:", casinoName);
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;


            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); //try parse converts the string representation of a number, a return means success (failure then =0)
                if (!validAnswer) Console.WriteLine("Please enter digits only; no decimals."); //if not a valid answer
            }

            //Console.WriteLine("And what is your budget today?");
            //int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yess" || answer == "ya" || answer == "yeah" || answer == "yah"|| answer == "yep"||answer == "yup"|| answer == "y"){
                Player player = new Player(playerName, bank); // name and how much they brought
                player.id = Guid.NewGuid(); // GLOBAL UNIQUE IDENTIFIER
                using (StreamWriter file = new StreamWriter(@"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\TwentyOne\Logs\log.txt", true)) //false creates new files, this appends
                {
                    file.WriteLine(player.id); // write cards suit and face to text file
                }
                Game game = new TwentyOneGame(); //polymorphism, creating a Game() because we want to expose the overloaded operators
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException) //more specific exceptions
                    {
                        Console.WriteLine("SECURITY! Kick this person out!");
                        Console.ReadLine();
                        return; 
                    }
                    catch (Exception) //generic exception catches the rest
                    {
                        Console.WriteLine("An error occured, please contact your System Administrator");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to browse the Casino. Bye for now!");
        }

    }
}
