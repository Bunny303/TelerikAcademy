using System;
using System.Collections.Generic;


namespace Poker
{
    public class Hand : IHand
    {
        private static Dictionary<string, CardFace> cardFaces = new Dictionary<string, CardFace>()
        {
            { "2", CardFace.Two },
            { "3", CardFace.Three },
            { "4", CardFace.Four },
            { "5", CardFace.Five },
            { "6", CardFace.Six },
            { "7", CardFace.Seven },
            { "8", CardFace.Eight },
            { "9", CardFace.Nine },
            { "10", CardFace.Ten },
            { "J", CardFace.Jack },
            { "Q", CardFace.Queen },
            { "K", CardFace.King },
            { "A", CardFace.Ace }
        };

        private static Dictionary<char, CardSuit> cardSuits = new Dictionary<char, CardSuit>()
        {
            { 'c', CardSuit.Clubs },
            { 'd', CardSuit.Diamonds },
            { 'h', CardSuit.Hearts },
            { 's', CardSuit.Spades }
        };

        public ICard[] Cards { get; private set; }

        public Hand(ICard[] cards)
        {
            if (cards == null)
            {
                throw new ArgumentNullException("cards", "cards cannot be null.");
            }

            this.Cards = cards;
        }

        public Hand(string cardNames)
        {
            if (string.IsNullOrWhiteSpace(cardNames))
            {
                throw new ArgumentException("Card name cannot be null or empty.", "cardNames");
            }

            string[] names = cardNames.Trim().Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            this.Cards = new ICard[names.Length];

            for (int i = 0; i < this.Cards.Length; i++)
            {
                int nameLength = names[i].Length;
                CardFace rank = cardFaces[names[i].Substring(0, nameLength - 1)];
                CardSuit suit = cardSuits[names[i][nameLength - 1]];
                this.Cards[i] = new Card(rank, suit);
            }
        }
        
        public override string ToString()
        {
           return string.Join<ICard>(" ", this.Cards);
        }
    }
}
