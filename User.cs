using System;

namespace BlackJackCSharp
{
    public class User : Player
    {
        int cardVal;
        internal override void AddCard(Card card)
        {
            hand.Cards.Add(card);
        }
        internal override void AddCards(Card[] cards)
        {
            hand.Cards.AddRange(cards);
        }



        internal override void CardShow()
        {
            cardVal = 0;

            Console.WriteLine("Your Cards: ");
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                Console.WriteLine(i + ") " + hand.Cards[i].Name);
            }
            for(int j = 0; j<hand.Cards.Count; j++)
            {
                cardVal = cardVal + hand.Cards[j].PlayingValue;
            }
            Console.WriteLine("Card Value: " + CardValue());
        }
        internal override int CardValue()
        {
            int aceValue = 11;
            cardVal = 0;

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

        internal override void ClearHand()
        {
            hand.Cards.Clear();
        }
    }
}
