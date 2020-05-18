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

        // deck constructor to allow methods to run
        public Deck()
        {
            AssembleDeck();
            Shuffle();

        }

        // method to assemble the deck
        // private because only needed in the Deck Class
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

        // shuffle method to allow for code reusability
        // public so that the method can be used outside of Deck Class
        // this allows the deck to be shuffled again if the game restarts
        public void Shuffle()
        {
            //AssembleDeck();
            //shuffel logic
            var n = 52;
            for (var firstIndex = n - 1; firstIndex >= 1; firstIndex--)
            {

                Random rnd = new Random();
                var secondIndex = rnd.Next(firstIndex);
                var firstValue = deck[firstIndex];
                var secondValue = deck[secondIndex];
                deck[firstIndex] = secondValue;
                deck[secondIndex] = firstValue;
            }

            // method that deals card from the deck and it returns a card
            public Card DealCard()
            {
                Card _card = _deck.First<Card>();
                _deck.Remove(_card);

                return _card;

            }


        }

    }
