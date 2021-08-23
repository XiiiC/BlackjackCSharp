using System;
using System.Diagnostics.CodeAnalysis;

namespace BlackJackCSharp
{
    public abstract class Player : IComparable<Player>
    {
        protected Hand hand = new Hand();

        public int score;

        internal abstract void CardShow();
        internal abstract void AddCard(Card card);
        internal abstract void AddCards(Card[] cards);
        internal abstract int CardValue();
        internal abstract void ClearHand();
        
        public int CompareTo(Player other)
        {
            if (score > other.score)
            {
                return 1;
            }
            else if (score < other.score)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
