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
            //=== Starter/demo/example code

            /* //Example starter code:
                    *
                         * TwentyOneGame game = new TwentyOneGame(); // instantiate TwentyOneGame class
                         * game.Players = new List<string>() { "Tony", "Rachel", "Indie" }; //instantiate with these values
                         * game.ListPlayers(); // call method listplayers from twentyonegame inherited from game class
                         * //calling from SUPERCLASS METHOD - Game is the superclass in this example, inherited from
                         * Console.ReadLine();
                         * 
                    */
            /* //polymorphism example:
                    *  
                         *  //TwentyOneGame can morph into the inherited from class Game
                         *  //this is useful for when there are many classes to be added in this way (ex: list of many diff games included)
                         * 
                         * List<Game> games = new List<Game>();
                         * TwentyOneGame game = new TwentyOneGame();
                         * games.Add(game);
                         * 
                    */
            /* Example code:
                     * 
                         * Game game = new TwentyOneGame(); // instantiate new Game to add player to
                         * game.Players = new List<Player>(); // instantiate list Player, so we can to add to it
                         * Player player = new Player(); // instantiate new Player
                         * player.Name = "Tony"; //add name to player name property (string)
                         * game += player; // aka: game = game + player; // parameters are game and a player (adding player to Players), returns game (this is our "method")
                         * game -= player; // aka: game = game - player; // parameters are game and a player (removing player from Players), returns game (this is our "method")
                         * 
                    */
            /* First Method for shuffling the deck multiple times
             * public static Deck Shuffle(Deck deck, int times)
                {
                    for (int i = 0; i < times; i++)
                    {
                        deck = Shuffle(deck);
                    }
                    return deck;
                }
            */
            //=== start after here

          
            Deck deck = new Deck(); // instantiate Deck
            //deck = Shuffle(deck); // shuffling and reassigning the value to deck

            deck.Shuffle(3); 
            // this is for shuffling multiple times
            // deck = Shuffle(deck: deck, times: 3); 
            // these are named parameters, for readability - does not change results

            foreach (Card card in deck.Cards) //print deck of cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }



    }
}
