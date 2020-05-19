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
        public int HandValue { get; set; }
        public Dealer()
        {

        }
        // adds a new hand from the Class Hand to the class Dealer
        public void AddHand(Hand hand)
        {
            _hand = hand;
            HandValue = hand.Value;

        }

    }
}
