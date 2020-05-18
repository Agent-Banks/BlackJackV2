using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Card
    {
        private string _rank;
        private string _suit;
        // int value used to track value of the card
        public int value { get; }
        // display is used to show the card to the player as a string
        public string display { get; }
        
        //assigning rank and suit to Card constructor
        public Card (String rank, String suit)
        {
            _rank = rank;
            _suit = suit;







        }
    }
}
