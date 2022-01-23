using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame: Game, IWalkAway // inherit a class from Game class, and inherit from INTERFACE class IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        public override void Play() // override - we will define this method. contract with Game satisfied (abstract method).
        {
            //throw new NotImplementedException(); // just create method, no implementation, do not call method
            Dealer = new TwentyOneDealer(); //instantiate new dealer
            foreach(Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;

            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet");

            foreach(Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool succefullyBet = player.Bet(bet);
                if (!succefullyBet)
                {
                    return; //void doesnt return, but this does a plain "return"/end this method, return nothing
                }
                Bets[player] = bet; //add entry to dictionary player name and bet
            }
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach(Player player in Players)
                {
                    Console.Write("{0}:", player.Name); //write to console but dont go to new line
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins ${1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return; //end round here
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if(i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach(KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
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
