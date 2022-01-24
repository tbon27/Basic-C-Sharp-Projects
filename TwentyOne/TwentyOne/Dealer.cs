using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\tbong\OneDrive\Documents\GitHub\Basic-C-Sharp-Projects\TwentyOne\Logs\log.txt", true)) //false creates new files, this appends
            {
                file.WriteLine(card); // write cards to text file
            }

            Deck.Cards.RemoveAt(0); // index 0 - remove that first item from deck after added to hand
        }
    }
}
