using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //class is a model or design for an object
    {
        public Card() //this is a constructor; if we dont assign any values later, these are default
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
