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
            Dealer = new TwentyOneDealer(); //instantiate new dealer
            foreach(Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;

            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
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
                            Console.WriteLine("BlackJack! {0} wins ${1}. New balance is ${2}", player.Name, Bets[player], player.Balance);
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
                        return;
                    }
                }
            }
            foreach(Player player in Players)
            {
                while(!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit of stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); // returns if player busted true or false
                    if (busted)
                    {
                        Dealer.Balance += Bets[player]; //give player bets to dealer
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to player again?");
                        answer = Console.ReadLine().ToLower();
                        if(answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);

            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }            
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won ${1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); ; //lambda, get first result/balance of x.name in dictionary and add winnings
                    Dealer.Balance -= entry.Value; //subtract dealer money
                }
                return;
            }
            foreach(Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);// this is now a nullable bool (because of ?)
                if(playerWon == null)
                {
                    Console.WriteLine("Push!");
                    player.Balance += Bets[player];
                    //Bets.Remove(player);
                }
                else if(playerWon == true)
                {
                    Console.WriteLine("{0} won {1}", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); // payout player initial bet and winnings
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}.", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
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
