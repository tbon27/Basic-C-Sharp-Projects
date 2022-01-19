using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //abstract will never become an object, meant to be inherited from
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); 
        // abstract methods only exist in abstract class, contains NO IMPLEMENTATION
        // Any class inheriting this class, must implement this method

        public virtual void ListPlayers() 
        // virtual method in abstract class means method is inherited by inheriting class but has ability to override it
        // virtual have implementation, but CAN BE overwritten. Customization possibilities with virtual vs abstract
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
