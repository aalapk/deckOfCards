using System;
using System.Collections.Generic;

namespace DeckOfCardsDemo
{
    public enum Suit { Spades, Hearts, Diamonds, Clubs };
    public enum Facevalue { Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };

    /// <summary>
    /// Class representing a deck of cards. Uses a List of Card type objetcs.
    /// Provides methods to shuffle a deck, draw a card and put drawn cards back
    /// </summary>
    public class DeckOfCards
    {
        private List<Card> deck;
        private Random random;
        private int noOfDecks;

        /// <summary>
        /// Constructor. Initializes the deck. Receives 'number of decks as a parameter, allowing multi-deck scenarios.
        /// </summary>
        public DeckOfCards(int noOfDecks)
        {
            this.noOfDecks = noOfDecks;

            deck = new List<Card>();

            for (int i = 0; i < noOfDecks; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    foreach (Facevalue facevalue in Enum.GetValues(typeof(Facevalue)))
                    {
                        Card card = new Card(suit, facevalue);
                        deck.Add(card);
                    }
                }
            }

            random = new Random();                      
        }

        /// <summary>
        /// Constructor. If no argument is passed (no. of decks desired), then defaults to 1 deck, calling the earlier constructor with 1 as parameter.
        /// </summary>
        public DeckOfCards() : this(1){}

        /// <summary>
        /// Picks and returns a card at a random index. Returns Null if the deck is empty.
        /// </summary>
        public Card drawACard()
        {
            if (deck.Count == 0)
            {
                return null;
            }
            else
            {
                int rInt = random.Next(0, deck.Count);
                Card drawnCard = deck[rInt];
                deck.RemoveAt(rInt);
                return drawnCard;
            }
        }

        /// <summary>
        /// Shuffles the deck using the following logic:
        /// Starting from the top of the deck(index 0), for each card, pick a card at a random index which is between index of the original card and the deck count, and swap them
        /// After this shuffle, no card will be in its original position        
        /// The complexity of this algorithm is O(n)
        /// </summary>
        public void shuffle()
        {
            if (deck.Count > 0)
            {
                for (int i = 0; i < (deck.Count-1); i++)
                {
                    int j = random.Next(i+1, deck.Count);
                    swapCards(i, j);
                }
            }
        }
        
        /// <summary>
        /// Puts a card back in the deck, at a random index
        /// </summary>
        public void putACardBack(Card card)
        {
            if (deck.Count == 52 * noOfDecks)
                throw new IndexOutOfRangeException ("Deck is already full");
            else
            {
                int rInt = random.Next(0, deck.Count);
                deck.Insert(rInt, card);
            }
        }

        /// <summary>
        /// Simple card swapping function for the deck
        /// </summary>
        public void swapCards(int sourceIndex, int targetIndex)
        {
            if (sourceIndex < 0 || targetIndex < 0 || sourceIndex > (52 * noOfDecks) -1 || targetIndex > (52 * noOfDecks) - 1)
                throw new ArgumentOutOfRangeException("Indices out of acceptable range: 0 - " + (52 * noOfDecks - 1));
            else
            {
                Card temp = deck[sourceIndex];
                deck[sourceIndex] = deck[targetIndex];
                deck[targetIndex] = temp;
            }
        }

        /// <summary>
        /// Getter for the deck
        /// </summary>
        public List<Card> getDeck()
        {
            return deck;
        }
    }
}
