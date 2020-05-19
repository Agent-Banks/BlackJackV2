﻿using System;
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
            var keepPlaying = true;

            while (keepPlaying)
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

                while (playerHand.TotalValue() <= 21)
                {
                    Console.WriteLine();
                    playerHand.ShowHand();
                    Console.WriteLine($"For a total value of {playerHand.TotalValue()}");
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
                Console.WriteLine($"For a total value of {playerHand.TotalValue()}");
                Console.WriteLine();

                while (dealerHand.TotalValue() < 17)
                {
                    dealerHand.AddCard(_deck.DealCard());
                }

                Console.WriteLine();
                Console.WriteLine("Dealer has:");
                dealerHand.ShowHand();
                Console.WriteLine($"For a total value of {dealerHand.TotalValue()}");

                Console.WriteLine();

                if (playerHand.TotalValue() > 21)
                {
                    Console.WriteLine("Dealer Wins!");
                }
                else
                if (dealerHand.TotalValue() > 21)
                {
                    Console.WriteLine("Player Wins!");
                }
                else if (dealerHand.TotalValue() >= playerHand.TotalValue())
                {
                    Console.WriteLine("Dealer Wins!");
                }
                else
                {
                    Console.WriteLine("Player Wins!");
                }

                Console.Write("Play again? (Y/N): ");
                var playAgainString = Console.ReadLine();
                keepPlaying = (playAgainString == "Y");
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing");

        }

    }
}
