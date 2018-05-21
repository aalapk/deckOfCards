using NUnit.Framework;
using DeckOfCardsDemo;

namespace DeckOfCardsTest
{
    /// <summary>
    /// Test class for class Card
    /// Test method format: MethodName_Condition_ExpectedResult
    /// </summary>
    class CardTest
    {
        [Test]
        public void getDisplayString_GetADisplayString_AssertCorrectness()
        {
            Card card = new Card(Suit.Clubs, Facevalue.Four);
            Assert.That(card.getDisplayString, Is.EqualTo("Four of Clubs"));
        }

        [Test]
        public void isSameCard_TwoSameCardsCompared_ReturnTrue()
        {
            Card c1 = new Card(Suit.Clubs, Facevalue.Four);
            Card c2 = new Card(Suit.Clubs, Facevalue.Four);
            Assert.True(c1.isSameCard(c2));
        }

        [Test]
        public void isSameCard_TwoDifferentCardsCompared_ReturnFalse()
        {
            Card c1 = new Card(Suit.Clubs, Facevalue.Four);
            Card c2 = new Card(Suit.Hearts , Facevalue.Eight);
            Assert.False(c1.isSameCard(c2));
        }
    }
}
