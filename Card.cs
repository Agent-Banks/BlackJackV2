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
        // properties for rank and suit value and display
        private string _rank;
        private string _suit;

        public int Value { get; }
        public string Display { get; }

        // method to get display and card value
        public Card(String rank, String suit)
        {
            _rank = rank;
            _suit = suit;

            switch (rank)
            {
                case "10":

                case "Jack":
                case "Queen":
                case "King":
                    Display = rank + " of " + suit;
                    Value = 10;
                    break;
                case "Ace":
                    Display = rank + " of " + suit;
                    Value = 11;
                    break;
                default:
                    Display = rank + " of " + suit;
                    Value = int.Parse(rank);
                    break;
            }

        }
    }

}
