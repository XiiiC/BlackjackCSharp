using System;
using System.Collections.Generic;

namespace BlackJackCSharp
{
    public class Game
    {

        Deck deck = new Deck();
        User user = new User();
        CPU cpu = new CPU();
        FileLog fileLog = new FileLog();
        Menu menu = new Menu();
        


        
        public int humanCardVal;
        public int computerCardVal;

        public void SetUp()
        {
            bool dealt = false;
            Console.WriteLine("Deck is empty.");
            Console.WriteLine("Populating Deck.");
            //Excecuting the populate method of the deck
            deck.Populate();
            Console.WriteLine("Shuffling deck.");
            //Excecuting the shuffle method of the deck
            deck.Shuffle();
            //Executing the main menu, returning the chjoice value
            while (true)
            {
                int menuChoice = menu.MainMenu(dealt);

                if (menuChoice == 1)
                {
                        deck.Shuffle();
                }
                if (menuChoice == 2)
                {
                        Play();
                        break;
                }
            }
            
        }

        public int Play()
        {
            //user recieves card, presented as the ascii visual of the card that the player has
            var dealtCard = deck.Deal();
            user.AddCard(dealtCard);




            //cpu recieves card, this one is hidden to the player, presnted as the ascii art visual for a face down card
            //user recieves second card
            //also need like a value being presented by both players
            //give cpu second card, this one face up
            //ask user if they want to, hit, stand or double
            //if the 2 cards the player has, offer a split, if split provide user with 2 hands, this will be implemented much later after groundwork
            //if player's card value is over 21 they lose
            //once player stands, reveal cpu hidden card and output value
            //if cpu card value is under user's and is under 17, hit
            //if cpu busts, player wins
            //if either player or cpu gets BlackJack they instantly win btw
            //when both players stand, compare values, highest value that doesnt go over 21 wins,
            //if value is equal its a push, aka draw






            return 0;
        }
        public int Stalemate(Card hCard, Card cCard, FileLog fileLog)
        {
            fileLog.LogLine($"The player drew {hCard.Name} ({hCard.Value})\nThe computer drew {cCard.Name} ({cCard.Value})");
            if (hCard.Value > cCard.Value)
            {
                fileLog.LogLine("Player Wins!");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
                //player wins

                return 1;
            }
            else if (hCard.Value < cCard.Value)
            {
                fileLog.LogLine("Computer Wins!");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
                //computer wins
                return -1;
            }
            else
            {
                fileLog.LogLine("Draw!");
                fileLog.LogLine("Each player will draw one card, highest card wins!");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
                //draw again
                return 0;
            }
        }

    }
}
