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
            Deck deck = new Deck();
            //deck = Shuffle(deck); // shuffling and reassigning the value to deck
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3); // this is for shuffling multiple times
            // deck = Shuffle(deck: deck, times: 3); // these are named parameters, for readability - does not change results

            foreach (Card card in deck.Cards) //print deck of cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times Shuffled: {0}", timesShuffled);
            Console.ReadLine();
        }


        // This method takes deck as an argument, and returns a shuffled deck
        // STATIC because we dont want to create an object Program before calling this
        // Deck is type, Shuffle is the name
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) 
            // when a default value is set (ex: 1), this creates an optional parameter
            // out is to assign the result to a variable already definted
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++; //add one each loop
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0,deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;   
            }
           return deck;
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
