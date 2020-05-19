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
        public int HandValue { get; set; }
        int value;
        public Player()
        {

        }

        public void AddHand(Hand hand)
        {
            _hand = hand;
            if (hand.Value > 21)
            {
                Console.WriteLine("You are Busted!");
            }

            HandValue = hand.Value;

        }

    }
}
