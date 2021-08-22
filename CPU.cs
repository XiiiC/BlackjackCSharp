using System;

namespace BlackJackCSharp
{
    public class CPU : Player
    {
        internal override bool CardShow()
        {
            int cardVal = 0;

            Console.WriteLine("Your Cards: ");
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                Console.WriteLine(i + ") " + hand.Cards[i].Name);
            }
            for (int j = 0; j < hand.Cards.Count; j++)
            {
                cardVal = cardVal + hand.Cards[j].PlayingValue;
            }
            Console.WriteLine("Card Value: " + cardVal);
            if(cardVal > 21)
            {
                return true;
            }
            else
            return false;
        }
        internal override int CardValue()
        {
            int cardVal = 0;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                cardVal = cardVal + hand.Cards[i].PlayingValue;
            }
            return cardVal;
        }
        public void HiddenCardShow()
        {
            int cardVal = 0;
            Console.WriteLine("Dealer's Cards: ");
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (i == 0)
                {

                    Console.WriteLine(i + ")" + " ########");
                }
                else
                {
                    Console.WriteLine(i + ") " + hand.Cards[i].Name);
                }
            }
            for (int j = 0; j < hand.Cards.Count; j++)
            {
                if (j == 0)
                {

                    continue;
                }
                else
                {
                    cardVal = cardVal + hand.Cards[j].PlayingValue;
                }

            }
            Console.WriteLine("Card Value: " + cardVal);
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
