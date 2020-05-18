using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate deck class into program to create a new deck
            Deck _deck = new Deck();
            // instantiate player and dealer class into program to create new player and dealer
            Player _player = new Player();
            Dealer _dealer = new Dealer();

            // creates new hand for player and deals card with method DealCard
            Hand playerHand = new Hand();
            playerHand.AddCard(_deck.DealCard());
            playerHand.AddCard(_deck.DealCard());
            // uses method to add a new hand into player hand
            _player.AddHand(playerHand);
            // logic to allow a hit for the player
            int _hit = 1;
            while (_hit == 1)
                {
                Console.WriteLine("Hit=1 or Stand=2");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    playerHand.AddCard(_deck.DealCard());
                    _player.AddHand(playerHand);
                }
            }

            //creates a new hand for the dealer from the Hand class and uses method to deal card
            Hand dealerHand = new Hand();
            dealerHand.AddCard(_deck.DealCard());
            dealerHand.AddCard(_deck.DealCard());

            _hit = 1;
            while (_hit == 1)
            {
                Console.WriteLine("Hit=1 or Stand=2");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    playerHand.AddCard(_deck.DealCard());
                    _player.AddHand(playerHand);
                }
            }


        }
    }
}
