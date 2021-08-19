namespace BlackJackCSharp
{
    public class Card
    {
        public enum Suits { Hearts = 0, Diamonds, Clubs, Spades }

        public Suits Suit { get; set; }
        public int Value { get; set; }
        public int PlayingValue { get; set; }

        public string NamedValues
        {
            get
            {
                //Reassigning the larger values of the cards to their names
                string name = string.Empty;
                switch (Value)
                {
                    case (14):
                        name = "Ace";
                        PlayingValue = 11;
                        break;
                    case (13):
                        name = "King";
                        PlayingValue = 10;                       
                        break;
                    case (12):
                        name = "Queen";
                        PlayingValue = 10;
                        break;
                    case (11):
                        name = "Jack";
                        PlayingValue = 10;
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }

                return name;
            }
        }
        public string Name
        {
            get
            {
                return NamedValues + " of " + Suit.ToString();
            }
        }
        public Card(int Value, int PlayingValue, Suits Suite)
        {
            this.Value = Value;
            this.Suit = Suite;
            this.PlayingValue = PlayingValue;

        }

    }
}
