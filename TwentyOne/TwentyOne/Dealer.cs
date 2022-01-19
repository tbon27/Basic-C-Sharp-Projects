using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer 
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) //input parameter a list of cards, a hand - method will add a card to that Hand
        {
            Hand.Add(Deck.Cards.First()); // grab the first card from Deck.Cards list and add to Hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // card about to be added to hand from deck
            Deck.Cards.RemoveAt(0); // index 0 - remove that first item from deck after added to hand
        }
    }
}
