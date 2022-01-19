using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
