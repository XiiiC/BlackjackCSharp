using System;
using System.Diagnostics.CodeAnalysis;

namespace BlackJackCSharp
{
    public abstract class Player : IComparable<Player>
    {
        protected Hand hand = new Hand();

        public int score;

        private int cardScore { get; set; }
        internal abstract bool CardShow();
        internal abstract void AddCard(Card card);
        internal abstract void AddCards(Card[] cards);
        
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
