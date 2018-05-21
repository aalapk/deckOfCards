using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DeckOfCardsDemo
{
    /// <summary>
    /// Class that provides UI to test DeckOfCards functionality
    /// Most methods are button click action handlers, that eventually call DeckOfCards methods
    /// </summary>
    public partial class MainMenu : Form
    {
        DeckOfCards deckOfCards;
        List<Card> drawnCards;

        /// <summary>
        /// Constructor. Initializes the deck and shuffles it. Also initializes collection of drawn cards, and refreshes display lists
        /// Dependency Injection pattern used - DeckOfCards object 'injected' through the constructor
        /// </summary>
        public MainMenu(DeckOfCards deckOfCards)
        {
            InitializeComponent();
            this.deckOfCards = deckOfCards;
            deckOfCards.shuffle();
            drawnCards = new List<Card>();
            refreshDeckDisplay();
            refreshDrawnCardsDisplay();
        }

        /// <summary>
        /// Button click handler method. Shuffles the deck.
        /// </summary>
        private void shuffle_Click(object sender, EventArgs e)
        {
            if (deckOfCards.getDeck().Count == 0)
            {
                MessageBox.Show("Deck is empty");
            }
            else
            {
                deckOfCards.shuffle();
                refreshDeckDisplay();
            }
        }

        /// <summary>
        /// Button click handler method. Draws a card.
        /// </summary>
        private void drawACard_Click(object sender, EventArgs e)
        {
            if (deckOfCards.getDeck().Count == 0)
            {
                MessageBox.Show("No cards left in the deck");
            }
            else
            {
                Card card = deckOfCards.drawACard();
                drawnCards.Add(card);
                refreshDeckDisplay();
                refreshDrawnCardsDisplay();
            }
        }

        /// <summary>
        /// Button click handler method. Returns all drawn cards back to the deck, one card at a time.
        /// </summary>
        private void returnCardsToDeck_Click(object sender, EventArgs e)
        {
            if (drawnCards.Count == 0)
            {
                MessageBox.Show("No cards drawn");
            }

            else
            {
                foreach (Card card in drawnCards)
                {
                    deckOfCards.putACardBack(card);
                }

                drawnCards.Clear();
                refreshDeckDisplay();
                refreshDrawnCardsDisplay();
            }
        }

        /// <summary>
        /// Refreshes display of the deck box
        /// </summary>
        private void refreshDeckDisplay()
        {
            deck.Items.Clear();
            if (deckOfCards.getDeck().Count > 0)
            {                
                foreach(Card card in deckOfCards.getDeck())
                {
                    deck.Items.Add(card.getDisplayString());
                }
            }
            deckCount.Text = deckOfCards.getDeck().Count.ToString();
        }

        /// <summary>
        /// Refreshes display of the drawn cards box
        /// </summary>
        private void refreshDrawnCardsDisplay()
        {
            cardsDrawn.Items.Clear();
            if (drawnCards.Count > 0)
            {                
                foreach (Card card in drawnCards)
                {
                    cardsDrawn.Items.Add(card.getDisplayString());
                }
            }
        }        
    }
}
