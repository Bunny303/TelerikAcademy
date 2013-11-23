using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void TestCardToString1()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Diamonds);
            Assert.AreEqual("7d", card.ToString(), "Card conversion to string is incorrect.");
        }

        [TestMethod]
        public void TestCardToString2()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            Assert.AreEqual("Ah", card.ToString(), "Card conversion to string is incorrect.");
        }

        [TestMethod]
        public void TestCardToString3()
        {
            Card card = new Card(CardFace.Two, CardSuit.Clubs);
            Assert.AreEqual("2c", card.ToString(), "Card conversion to string is incorrect.");
        }

        [TestMethod]
        public void TestCardToString4()
        {
            Card card = new Card(CardFace.Queen, CardSuit.Spades);
            Assert.AreEqual("Qs", card.ToString(), "Card conversion to string is incorrect.");
        }
    }
}
