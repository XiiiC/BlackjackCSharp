using System;

namespace BlackJackCSharp
{
    public class CPU : Player
    {
        internal override void CardShow()
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
        }
        internal override int CardValue()
        {
            int cardVal = 0;
            int aceValue = 11;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                cardVal = cardVal + hand.Cards[i].PlayingValue;
            }
            if (cardVal > 21)
            {
                //Hand is over 21
                //check every card in hand
                for (int j = 0; j < hand.Cards.Count; j++)
                {
                    //if a card value is equvilant to that of ace value
                    if (aceValue == hand.Cards[j].PlayingValue)
                    {
                        //Reduce the hand value by 10 
                        //coverting the value of the ace to a 1 from an 11 when over 21
                        cardVal = cardVal - 10;
                    }
                    //if not, move to next one
                }
                //after for loop, return the remaining value
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



        internal override void ClearHand()
        {
            hand.Cards.Clear();
        }
    }
}
