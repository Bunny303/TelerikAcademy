using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class PokerHandsCheckerTest
    {
        private static IPokerHandsChecker handChecker = new PokerHandsChecker();

        [TestMethod]
        public void TestIsValid1()
        {
            ICard[] cards = new ICard[5]
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Diamonds)
            };

            IHand hand = new Hand(cards);

            bool validHand = handChecker.IsValidHand(hand);

            Assert.AreEqual(false, validHand, "Hand validation does not work correctly (accepts identical cards).");
        }

        [TestMethod]
        public void TestIsValid2()
        {
            bool validHand = handChecker.IsValidHand(null);

            Assert.AreEqual(false, validHand, "Hand validation does not work correctly.");
        }

        [TestMethod]
        public void TestIsValid3()
        {
            ICard[] cards = new ICard[3]
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs)
            };

            IHand hand = new Hand(cards);

            bool validHand = handChecker.IsValidHand(hand);

            Assert.AreEqual(false, validHand, "Hand validation does not work correctly.");
        }

        [TestMethod]
        public void TestIsValid4()
        {
            ICard[] cards = new ICard[5]
            {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds)
            };

            IHand hand = new Hand(cards);

            bool validHand = handChecker.IsValidHand(hand);

            Assert.AreEqual(true, validHand, "Hand validation does not work correctly (accepts identical cards).");
        }

        [TestMethod]
        public void TestIsFlush1()
        {
            IHand hand = new Hand("Qs 10s 7s 6s 4d");

            bool flush = handChecker.IsFlush(hand);

            Assert.AreEqual(false, flush, "Flush is not identified correctly.");
        }

        [TestMethod]
        public void TestIsFlush2()
        {
            IHand hand = new Hand("Qd 9d 7d 4d 3d");

            bool flush = handChecker.IsFlush(hand);

            Assert.AreEqual(true, flush, "Flush is not identified correctly.");
        }

        [TestMethod]
        public void TestIsFlush3()
        {
            IHand hand = new Hand("Kh Qh 9h 5h 4h");

            bool flush = handChecker.IsFlush(hand);

            Assert.AreEqual(true, flush, "Flush is not identified correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKind1()
        {
            IHand hand = new Hand("9c 9s 9d 9h Jh");

            bool fourOfAKind = handChecker.IsFourOfAKind(hand);

            Assert.AreEqual(true, fourOfAKind, "Four of a kind is not identified correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKind2()
        {
            IHand hand = new Hand("Jc 9s Js Jd Jh");

            bool fourOfAKind = handChecker.IsFourOfAKind(hand);

            Assert.AreEqual(true, fourOfAKind, "Four of a kind is not identified correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKind3()
        {
            IHand hand = new Hand("Qc Jc Js Jd Jh");

            bool fourOfAKind = handChecker.IsFourOfAKind(hand);

            Assert.AreEqual(true, fourOfAKind, "Four of a kind is not identified correctly.");
        }

        [TestMethod]
        public void TestIsFourOfAKind4()
        {
            IHand hand = new Hand("Qc Jc Js Kd Jh");

            bool fourOfAKind = handChecker.IsFourOfAKind(hand);

            Assert.AreEqual(false, fourOfAKind, "Four of a kind is not identified correctly.");
        }
    }
}
