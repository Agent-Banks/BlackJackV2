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

            Deck _deck = new Deck();

            Player _player = new Player();
            Dealer _dealer = new Dealer();

            //Player
            Hand playerHand = new Hand();
            playerHand.AddCard(_deck.DealCard());
            playerHand.AddCard(_deck.DealCard());
            _player.AddHand(playerHand);
            
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

            //Dealer
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
