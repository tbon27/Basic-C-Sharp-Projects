using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {

        public Player(string name, int beginningBalance) //constructor taking two params
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough $ to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }



        public static Game operator+ (Game game, Player player) // overloading operator+, taking 2 operands, game and player 
        {
            game.Players.Add(player); // takes game and adds player to Players in Abstract game class
            return game; // returns game
        }

        public static Game operator- (Game game, Player player) // overloading operator-, taking 2 operands, game and player 
        {
            game.Players.Remove(player);  // takes game and removes player to Players in Abstract game class
            return game; // returns game
        }
    }
}
