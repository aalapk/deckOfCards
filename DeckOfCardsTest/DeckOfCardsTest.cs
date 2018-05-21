using NUnit.Framework;
using DeckOfCardsDemo;
using System.Collections.Generic;

namespace DeckOfCardsTest
{
    /// <summary>
    /// Test class for class DeckOfCards
    /// Test method format: MethodName_Condition_ExpectedResult
    /// </summary>
    public class DeckOfCardsTest
    {
        DeckOfCards d;

        [SetUp]
        public void setupBeforeEachTest()
        {
            d = new DeckOfCards();
        }

        [Test]
        public void initializeADeck_SingleDeck_CorrectCardCount()
        {
            Assert.That(d.getDeck().Count, Is.EqualTo(52));
        }

        [Test]
        public void initializeADeck_MultipleDecks_CorrectCardCount()
        {
            bool invalidCardsCount = false;

            for (int noOfDecks = 1; noOfDecks <= 5; noOfDecks++)
            {
                DeckOfCards deck = new DeckOfCards(noOfDecks);
                if (deck.getDeck().Count != noOfDecks * 52)
                    invalidCardsCount = true;
            }

            Assert.That(invalidCardsCount, Is.False);
        }

        [Test]
        public void drawACard_CardDrawn_CorrectObjectReturned()
        {
            var c = d.drawACard();
            Assert.IsInstanceOf(typeof(Card), c);
        }

        [Test]
        public void drawACard_CardDrawn_CorrectCardCount()
        {
            Card c = d.drawACard();
            Assert.That(d.getDeck().Count, Is.EqualTo(51));
        }

        [Test]
        public void drawACard_EmptyDeck_NullObjectReceived()
        {
            for (int i = 0; i < 52; i++)
                d.drawACard();

            Card c = d.drawACard();
            Assert.That(c, Is.Null);
        }

        [Test]
        public void shuffle_SingleDeckShuffledOnce_CorrectCardCount()
        {
            d.shuffle();
            Assert.That(d.getDeck().Count, Is.EqualTo(52));
        }

        [Test]
        public void shuffle_SingleDeckShuffledOnce_NoCardIsInTheEarlierPosition()
        {
            List<Card> originalDeck = new List<Card>();

            foreach (Card card in d.getDeck())
                originalDeck.Add(card);

            d.shuffle();
            bool shuffleNotValid = false;

            for (int i = 0; i < 52; i++)
            {
                if (d.getDeck()[i].isSameCard(originalDeck[i]))
                    shuffleNotValid = true;
            }
            Assert.That(shuffleNotValid, Is.False);
        }

        [Test]
        public void shuffle_DrawCardsThenShuffle_CorrectCardCount()
        {
            for (int i = 0; i < 20; i++)
            {
                d.drawACard();
            }

            int c = d.getDeck().Count;             
            d.shuffle();
            Assert.That(d.getDeck().Count, Is.EqualTo(c));
        }

        [Test]
        public void putACardBack_DrawCardsThenPutBack_CorrectCardCount()
        {
            //20 cards drawn
            List<Card> cardsDrawn = new List<Card>();
            for (int i = 0; i < 20; i++)
            {
                cardsDrawn.Add(d.drawACard());
            }

            //2 cards put back
            d.putACardBack(cardsDrawn[0]);
            d.putACardBack(cardsDrawn[1]);
            
            Assert.That(d.getDeck().Count, Is.EqualTo(34));
        }

        [Test]
        public void putACardBack_DeckIsFull_ExceptionThrown()
        {
            Card c = d.getDeck()[0];
            Assert.Throws<System.IndexOutOfRangeException>(() => d.putACardBack(c));
        }

        [Test]
        public void swapCards_SwapTwoCards_SuccessfulSwap()
        {
            Card c1 = d.getDeck()[0];
            Card c2 = d.getDeck()[1];

            d.swapCards(0, 1);

            Assert.True(d.getDeck()[0].isSameCard(c2) && d.getDeck()[1].isSameCard(c1));
        }

        [Test]
        public void swapCards_IndicesOutOfRange_ThrowsException()
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => d.swapCards(0, 60));
        }
    }    
}
