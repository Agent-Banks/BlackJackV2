using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        private List<Card> _deck = new List<Card>;
        private List<Card> _shuffeldDeck = new List<Card>;

        public Deck()
        {
            AssembleDeck();
            Shuffle();

        }
 
        private void AssembleDeck()
        {
            string[] _suits = { "Hearts", "Clubs", "Diamonds", "Spades" };
            String rank;

            foreach (string suite in _suits)
            {
                for (int i = 2; i < 15; i++)
                {
                    switch (i)
                    {
                        case 14:
                            rank = "Ace";
                            break;
                        case 13:
                            rank = "King";
                            break;
                        case 12:
                            rank = "Queen";
                            break;
                        case 11:
                            rank = "Jack";
                            break;
                        default:
                            rank = i.ToString();
                            break;

                    }
                    _deck.Add(new Card(rank, suite));
                }

            }

        }

        public void Shuffle()
        {
            //AssembleDeck();
            //shuffel logic
        }

        public Card DealCard() 
        {
            Card _card = _deck.First<Card>();
            _deck.Remove(_card);

            return _card;
        
        }


    }

}
