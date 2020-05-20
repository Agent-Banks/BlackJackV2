using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        private List<Card> _hand = new List<Card>();
        public int Value { get; set; }

        public Hand()
        {

        }
        // method to add card to hand class
        public void AddCard(Card card)
        {
            Value = Value + card.Value;
            _hand.Add(card);
        }

        // shows the hand and displays all cards
        public void ShowHand()
        {
            foreach (Card card in _hand)
            {
                Console.WriteLine(card.Display);
            }

        }

        // method to get total value of the hand
        public int TotalValue()
        {
            var total = 0;
            foreach (var card in _hand)
            {
                var cardValue = card.Value;

                total = total + cardValue;
            }

            return total;
        }
    }
}
