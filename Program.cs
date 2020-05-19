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
            //Dealer
            Hand dealerHand = new Hand();
            playerHand.AddCard(_deck.DealCard());
            dealerHand.AddCard(_deck.DealCard());
            playerHand.AddCard(_deck.DealCard());
            dealerHand.AddCard(_deck.DealCard());

            _player.AddHand(playerHand);
            _dealer.AddHand(dealerHand);

            while (_player.HandValue <= 21)
            {
                Console.WriteLine();
                playerHand.ShowHand();
                Console.WriteLine($"For a total value of {_player.HandValue}");
                Console.WriteLine();

                Console.Write("(H)it or (S)tand: ");
                var answer = Console.ReadLine();

                if (answer == "H")
                {
                    playerHand.AddCard(_deck.DealCard());

                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
            playerHand.ShowHand();
            Console.WriteLine($"For a total value of {_player.HandValue}");
            Console.WriteLine();


        }
    }
}
