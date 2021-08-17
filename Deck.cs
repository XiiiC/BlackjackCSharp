using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsOOP
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();


        //Checking if a deck is empty based on if there are cards left within the array
        public bool IsEmpty()
        {
            //The deck is empty when there are 0 cards left
            if (Cards.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Populates the deck by creating 52 cards with its own value and suit
        public void Populate()
        {
            //Can use a single loop utilising the mod operator % and Math.Floor
            //Using divition based on 13 cards in a suited
            for (int i = 0; i < 52; i++)
            {
                Card.Suits suite = (Card.Suits)(Math.Floor((decimal)i / 13));
                //Add 2 to value as a cards start a 2
                int val = i % 13 + 2;
                Cards.Add(new Card(val, suite));

            }
        }
        //Shuffling this deck randomly
        public void Shuffle()
        {
            Cards = Cards.OrderBy(i => Guid.NewGuid()).ToList();
        }

        public Card Deal()
        {
            //Taking the last card of the list
            var card = Cards.Last();
            //Removing it from the list
            Cards.RemoveAt(Cards.Count - 1);

            //Returns the card to a variable
            return card;

        }
        public Card[] Deal(int count)
        {
            Card[] cards = new Card[count];

            for (int i = 0; i < count; i++)
            {
                //Taking the last card of the list
                var card = Cards.Last();
                //Removing it from the list
                Cards.RemoveAt(Cards.Count - 1);

                //Returns the card to a variable

                cards[i] = card;
            }
            return cards;
        }
    }
}
