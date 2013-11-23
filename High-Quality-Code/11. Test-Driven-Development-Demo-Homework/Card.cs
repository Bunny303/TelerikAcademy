using System;
using System.Linq;
using System.Collections.Generic;

namespace Poker
{
    public class Card : ICard
    {
        private static readonly string[] Faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        private static readonly char[] Suits = { 'c', 'd', 'h', 's' };

        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return Faces[(int)this.Face - 2] + Suits[(int)this.Suit-1];
        }
    }
}
