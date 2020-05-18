using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Hand
    {
        private List<Card> _hand = new List<Card>;
        public int value { get; set; }

        public Hand()
        {
           
        }
        //method to add card into player hand
        public void AddCard(Card card)
        {
            value = value + card.value;
            _hand.Add(card);
        }

        public void ShowHand()
        {
            foreach (Card card in _hand)
            {
                Console.WriteLine(card.display);
            }
        
        }

    }
}
