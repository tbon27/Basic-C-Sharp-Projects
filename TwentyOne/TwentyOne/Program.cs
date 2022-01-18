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
            //TwentyOneGame game = new TwentyOneGame(); // instantiate TwentyOneGame class
            //game.Players = new List<string>() { "Tony", "Rachel", "Indie" }; //instantiate with these values
            //game.ListPlayers(); // call method listplayers from twentyonegame inherited from game class
            ////calling from SUPERCLASS METHOD - Game is the superclass in this example, inherited from
            


            Deck deck = new Deck(); // instantiate Deck class
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

        //// First Method for shuffling the deck multiple times
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
