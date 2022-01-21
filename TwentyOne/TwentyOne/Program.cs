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
            Deck deck = new Deck(); // instantiate Deck

//demo
                                    //Card card1 = new Card();
                                    //Card card2 = card1;
                                    //card1.Face = Face.Eight;
                                    //card2.Face = Face.King;

            //Console.WriteLine(card1.Face); //results in King


//==****** LAMBDA DEMO ****** ==// note: difficult to debug
//==============================//
//How many aces (are left) in the deck?
//
//First approach:
/*int counter = 0;
foreach(Card card in deck.Cards)
{
    if(card.Face == Face.Ace)
    {
        counter++;
    }
}
Console.WriteLine(counter);*/

//Approach #2 using LAMBDA
//int count = deck.Cards.Count(x => x.Face == Face.Ace); //count all elements(x) where x.Face equals Face.Ace
//Console.WriteLine(count);

//==****** LAMBDA DEMO 2 ****** ==//
//==============================//
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList(); // "take this item, and apply this function to each item"
//foreach (Card card in newList)
//{
//    Console.WriteLine(card.Face);
//}

//==****** LAMBDA DEMO 3 ****** ==//
//==============================//
//List<int> numberList = new List<int>() { 10, 30, 70, 100, 105 };

//int sum = numberList.Sum(x => x + 5); //in other words - for each item, add 5 to each item
//Console.WriteLine(sum);
//int maxNum = numberList.Max();
//Console.WriteLine(maxNum);            
//int minNum = numberList.Min();
//Console.WriteLine(minNum);
//int demoNum1 = numberList.Where(x => x > 20).Sum(); //Where() creates a new list (we are then Sum() summing it)
//Console.WriteLine(demoNum1);

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
