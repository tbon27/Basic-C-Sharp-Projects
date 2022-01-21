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
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face); //results in King


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
