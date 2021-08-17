using System;

namespace BlackJack
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
        internal override Card CardPick()
        {
            string cardChoice;
            int i = 0;
            Card card = null;
            while (card == null)
            {
                Console.Clear();
                Console.WriteLine("Your Cards: ");
                for (i = 0; i < hand.Cards.Count; i++)
                {
                    Console.WriteLine(i + ") " + hand.Cards[i].Name);
                }
                //ask which first card they wanna pick from the list
                Console.WriteLine("Pick which card you would like to play: ");
                cardChoice = Console.ReadLine();
                if (int.TryParse(cardChoice, out int choice))
                {
                    if (choice >= 0 && choice <= hand.Cards.Count - 1)
                    {
                        card = hand.Cards[choice];
                        hand.Cards.RemoveAt(choice);
                    }
                }
            }
            return card;

        }
    }
}
