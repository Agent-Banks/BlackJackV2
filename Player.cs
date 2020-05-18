using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Player
    {
        private Hand _hand;
        int value;
        // constructor for player class
        public Player()
        {

        }
        // method to add a hand to the player class
        public void AddHand(Hand hand)
        {
            _hand = hand;
            Console.WriteLine(hand.value);
            // if the hand is over 21 defaults to a bust
            if (hand.value > 21)
            {
                Console.WriteLine("You are Busted!");
            }
        }

    }
}
