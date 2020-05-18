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
        public int value { get; }
        public string display { get; }
        
        //assigning rank and suit to Card constructor
        public Card (String rank, String suit)
        {
            _rank = rank;
            _suit = suit;







        }
    }
}
