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
        private List<Card> _deck = new List<Card>();
        private List<Card> shuffledDeck = new List<Card>();

        public Deck()
        {
            shuffledDeck = Shuffle(AssembleDeck());
        }

        private List<Card> AssembleDeck()
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

            return _deck;

        }

        public List<Card> Shuffle(List<Card> deck)
        {

            List<Card> _deck = deck;
            int _cardCount = _deck.Count;

            for (var i1 = _cardCount - 1; _cardCount >= 1; _cardCount--)
            {

                Random rnd = new Random();
                var i2 = rnd.Next(i1);
                var firstValue = _deck[i1];
                var secondValue = _deck[i2];
                _deck[i1] = secondValue;
                _deck[i2] = firstValue;
            }

            return _deck;

        }

        public Card DealCard()
        {
            Card _card = shuffledDeck.First<Card>();
            _deck.Remove(_card);

            return _card;

        }


    }
}
