using System;

namespace BlackJackCSharp
{
    public class User : Player
    {
        internal override void AddCard(Card card)
        {
            hand.Cards.Add(card);
        }
        internal override void AddCards(Card[] cards)
        {
            hand.Cards.AddRange(cards);
        }
        internal override bool CardShow()
        {
            int cardVal = 0;

            Console.WriteLine("Your Cards: ");
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                Console.WriteLine(i + ") " + hand.Cards[i].Name);
            }
            for(int j = 0; j<hand.Cards.Count; j++)
            {
                cardVal = cardVal + hand.Cards[j].PlayingValue;
            }
            Console.WriteLine("Card Value: " + cardVal);
            if (cardVal > 21)
            {
                return true;
            }
            else
                return false;
        }

    }
}
