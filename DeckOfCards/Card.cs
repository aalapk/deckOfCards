namespace DeckOfCardsDemo
{
    /// <summary>
    /// Class representing a card. Has a suit and a facevalue.
    /// </summary>
    public class Card
    {
        private Suit suite;
        private Facevalue value;

        /// <summary>
        /// Constructor. Initializes a card, using suit and facevalue received
        /// </summary>
        public Card(Suit suite, Facevalue value)
        {
            this.suite = suite;
            this.value = value;
        }

        /// <summary>
        /// Returns a display-friendly string of the card (i.e. Ace of Spades)
        /// </summary>
        public string getDisplayString()
        {
            return this.value + " of " + this.suite;
        }

        /// <summary>
        /// Checks if two cards are same (used in testing)
        /// </summary>
        public bool isSameCard(Card card)
        {
            if (this.suite == card.suite && this.value == card.value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
