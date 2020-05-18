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
        public Player()
        {

        }

        public void AddHand(Hand hand)
        {
            _hand = hand;
            Console.WriteLine(hand.value);
            if (hand.value > 21)
            {
                Console.WriteLine("You are Busted!");
            }
        }
       
    }
}
