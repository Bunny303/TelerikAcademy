using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        private const int NUMBER_OF_CARDS = 5;

        public bool IsValidHand(IHand hand)
        {
            if (hand == null)
            {
                return false;
            }

            ICard[] cards = hand.Cards;

            if (cards.Length != NUMBER_OF_CARDS)
            {
                return false;
            }

            for (int i = 0; i < cards.Length - 1; i++)
            {
                for (int j = i + 1; j < cards.Length; j++)
                {
                    if ((cards[i].Face==cards[j].Face)&&(cards[i].Suit==cards[j].Suit))
                    {
                        return false;
                    }
                }
            }

            return true; 
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            ICard[] cards = hand.Cards;
            int counter = 0;

            for (int i = 1; i < cards.Length; i++)
            {
                if (cards[i-1].Face == cards[i].Face)
                {
                    counter++;
                }
            }
            if (cards[0].Face == cards[cards.Length - 1].Face)
            {
                counter++;
            }
            if (counter >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            ICard[] cards = hand.Cards;

            for (int i = 1; i < cards.Length; i++)
            {
                if (cards[0].Suit != cards[i].Suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
