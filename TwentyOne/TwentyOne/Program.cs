using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino!\nLet's start wby telling me your name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("And what is your budget today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "ya" || answer == "yeah" || answer == "yah"|| answer == "yep"||answer == "yup"|| answer == "y"){
                Player player = new Player(playerName, bank); // name and how much they brought
                Game game = new TwentyOneGame(); //polymorphism, creating a Game() because we want to expose the overloaded operators
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to browse the Casino. Bye for now!\nThank you for playing!");
        }



    }
}
