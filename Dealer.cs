using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Dealer
    {
        private Hand _hand;
        int value;
        public Dealer()
        {

        }
        public void AddHand(Hand hand)
        {
            _hand = hand;
            Console.WriteLine(hand.Value);
            if (hand.Value > 21)
            {
                Console.WriteLine("You are Busted!");
                return;
            }
            if (hand.Value >= 17)
            {

            }
        }

    }
}
