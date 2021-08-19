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
        public void Dealing()
        {
            var dealtCard = deck.Deal();
            user.AddCard(dealtCard);
            user.CardShow();
            dealtCard = deck.Deal();
            cpu.AddCard(dealtCard);
            cpu.HiddenCardShow();
            Console.ReadLine();
            Console.Clear();
            dealtCard = deck.Deal();
            user.AddCard(dealtCard);
            user.CardShow();
            dealtCard = deck.Deal();
            cpu.AddCard(dealtCard);
            cpu.HiddenCardShow();
            Console.ReadLine();
        }
        public void Hit()
        {
            if (user.CardShow())
            {
                Console.Clear();
                user.CardShow();
                cpu.HiddenCardShow();
                Console.WriteLine("\n Player Has Bust\n");
            }
            else
            {
                Console.Clear();
                var dealtCard = deck.Deal();
                user.AddCard(dealtCard);
                user.CardShow();
                cpu.HiddenCardShow();
                Console.ReadLine();
            }

        }
        public void Stand()
        {
            Console.Clear();
            user.CardShow();
            cpu.CardShow();
        }
        public void Double()
        {
            //Until "chips" introduced its basically a hit u can only do once
            Console.Clear();
            var dealtCard = deck.Deal();
            user.AddCard(dealtCard);
            user.CardShow();
            cpu.HiddenCardShow();
            Console.ReadLine();
            user.CardShow();
            cpu.CardShow();

        }
        public int Play()
        {


            Dealing();
            bool standing = false;
            bool drawn = false;
            while (!standing)
            {
                int choice = menu.PlayingMenu();
                switch (choice)
                {
                    case 1:
                        Stand();
                        standing = true;
                        drawn = true;
                        break;
                    case 2:
                        Hit();
                        break;
                    case 3:
                        if (!drawn)
                        {
                            Double();
                            standing = true;
                        }
                        break;
                }
            }

            /// DEALER CHECKS TO DRAW
            ///COMPARING
            //user recieves card, presented as the ascii visual of the card that the player ##done





            //cpu recieves card, this one is hidden to the player, presnted as the ascii art visual for a face down card##done
            //user recieves second card##done
            //also need like a value being presented by both players##done
            //give cpu second card, this one face up##done
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
