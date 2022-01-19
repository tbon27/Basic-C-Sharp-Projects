using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame: Game, IWalkAway // inherit a class from Game class, and inherit from INTERFACE class IWalkAway
    {
        public override void Play() // override - we will define this method. contract with Game satisfied (abstract method).
        {
            throw new NotImplementedException(); // just create method, no implementation, do not call method
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players: ");
            base.ListPlayers(); // this is basically ListPlayers from Game class, but we can make changes - VIRTUAL implementation
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException(); // just create method, no implementation, do not call method
        }
    }
}
