using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        public Deck()//constructor, name is always the same as name of class
        {
            Cards = new List<Card>(); //instantiate empty list of cards
            
            //=== Create a deck of cards:
            //=== 52 for loops (cards created); 13 times 4 = 52
            for (int i = 0; i < 13; i++) //loop through each face
            {
                for(int j = 0; j < 4; j++) //loop through each suit
                {
                    Card card = new Card();
                    card.Face = (Face)i; //cast to Face, assign card face
                    card.Suit = (Suit)j; //cast to Suit, assign card suit
                    Cards.Add(card); //add card to Cards list
                }
            }

        }
        public List<Card> Cards { get; set; } // properties

        // This CLASS METHOD takes deck as an argument, and returns a shuffled deck
        public void Shuffle(int times = 1) //dont need to return anything
        // when a default value is set (ex: 1), this creates an optional parameter
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
