using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card 
        //class is a model or design for an object --> CHANGED to struct because good candidate..
        //our card is a small value, and once set we dont want it changed..
        //doesnt inherit anything. Structs cant be inherited
    {
        //public Card() //this is a constructor; if we dont assign any values later, these are default
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}

        public Suit Suit { get; set; } //get data type Suit (instead of string) from enum below
        public Face Face { get; set; } //get data type Suit (instead of string) from enum below

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }

    //=== using enums to limit the possibilities of our card and suit values (with consts)
    //==since this enum specifically relates to this class..
    //==..(judgement) maybe better to define here (rather than sep. file)
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }    
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
