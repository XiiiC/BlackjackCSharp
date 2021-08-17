using System;
using System.Diagnostics.CodeAnalysis;

namespace BlackJack
{
    public abstract class Player : IComparable<Player>
    {
        protected Hand hand = new Hand();

        public int score;

        private int cardScore { get; set; }
        internal abstract Card CardPick();
        internal abstract void AddCard(Card card);
        internal abstract void AddCards(Card[] cards);

        public int CompareTo([AllowNull] Player other)
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
