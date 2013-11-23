using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            ICard[] cards = new ICard[]
                {
                    new Card(CardFace.Queen, CardSuit.Hearts),
                    new Card(CardFace.Queen, CardSuit.Spades),
                    new Card(CardFace.Ten, CardSuit.Hearts),
                    new Card(CardFace.Queen, CardSuit.Diamonds),
                    new Card(CardFace.Queen, CardSuit.Clubs)
                };

            IHand hand = new Hand(cards);

            
            IPokerHandsChecker checker = new PokerHandsChecker();
            Console.WriteLine(checker.IsValidHand(hand));
            Console.WriteLine(checker.IsOnePair(hand));
            Console.WriteLine(checker.IsTwoPair(hand));
        }
    }
}
