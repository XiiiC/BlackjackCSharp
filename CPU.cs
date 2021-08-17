using System;

namespace CardsOOP
{
    public class Computer : Player
    {
        internal override Card CardPick()
        {
            Random r = new Random();
            Card card = null;
            int choice = 0;
            choice = r.Next(0, hand.Cards.Count);

            card = hand.Cards[choice];
            hand.Cards.RemoveAt(choice);

            return card;
        }
        internal override void AddCards(Card[] cards)
        {
            hand.Cards.AddRange(cards);
        }
        internal override void AddCard(Card card)
        {
            hand.Cards.Add(card);
        }

    }
}
