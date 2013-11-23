using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestHandConstructor1_ThrowsException()
        {
            ICard[] cards = null;
            IHand hand = new Hand(cards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHandConstructor2_ThrowsException()
        {
            string cardNames = null;
            IHand hand = new Hand(cardNames);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHandConstructor3_ThrowsException()
        {
            string cardNames = string.Empty;
            IHand hand = new Hand(cardNames);
        }
                
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestHandConstructor4_ThrowsException()
        {
            string cardNames = "   ";
            IHand hand = new Hand(cardNames);
        }

        [TestMethod]
        public void TestHandConstructor5()
        {
            string cardNames = "Ah 9s Kd Kc 2h";
            IHand hand = new Hand(cardNames);
        }

        [TestMethod]
        public void TestHandToString1()
        {
            ICard[] cards = new ICard[0];
            IHand hand = new Hand(cards);

            Assert.AreEqual(string.Empty, hand.ToString(), "Hand constructor does not work correctly.");
        }

        [TestMethod]
        public void TestHandToString2()
        {
            ICard[] cards = new ICard[5]
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Diamonds)
            };

            Hand hand = new Hand(cards);

            Assert.AreEqual("9s 2h Jc Ad 5d", hand.ToString(), "Hand conversion to string does not work correctly.");
        }

        [TestMethod]
        public void TestHandToString3()
        {
            ICard[] cards = new ICard[1]
            {
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);

            Assert.AreEqual("Jc", hand.ToString(), "Hand conversion to string does not work correctly.");
        }
    }
}
