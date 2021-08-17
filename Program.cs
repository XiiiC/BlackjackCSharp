using System;
using System.Collections.Generic;

namespace BlackJackCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();

            game.SetUp();

            /*bool dealt = false;

            Console.WriteLine("Deck is empty.");
            Console.WriteLine("Populating Deck.");
            //Excecuting the populate method of the deck
            deck.Populate();
            Console.WriteLine("Shuffling deck.");
            //Excecuting the shuffle method of the deck
            deck.Shuffle();

            //The menu loop
            //Can be exited by choosing in the menu, or when there are no more cards in the deck and the user chooses not to repopulate the deck
            while (true)
            {
                Console.WriteLine("Deal a card?");
                if (!dealt) Console.WriteLine("1 - Deal");
                Console.WriteLine("2 - Shuffle");
                if (dealt) Console.WriteLine("3 - Play");
                Console.WriteLine("4 - Exit");


                string input = Console.ReadLine();
                int number;
                //Validating the input of the user, tryparsing to ensure that an intiger is entered
                //As well as that the intiger entered is within the set boundries
                if (!Int32.TryParse(input, out number) || number < 1 || number > 4)
                {
                    Console.Clear();
                    Console.WriteLine("You have not enetered one of the outlined values to use the menu, please try again.");
                }

                if (number == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Dealing cards.");
                    Console.WriteLine();
                    int cardCount = 0;

                    try
                    {
                        cardCount = 10;
                        var dealtCards = deck.Deal(cardCount);
                        user.AddCards(dealtCards);
                        dealtCards = deck.Deal(cardCount);
                        cpu.AddCards(dealtCards);

                    }
                    catch (TooManyCardsDealtException)
                    {
                        Console.WriteLine("Too many cards were dealt to the players");
                        continue;
                    }
                    catch (NotEnoughCardsDealtExcpetion)
                    {
                        Console.WriteLine("Not enough cards were dealt to players");
                    }
                    catch (NotEnoughCardsException)
                    {
                        Console.WriteLine("There are not enough cards in the deck to continue play");
                    }
                    dealt = true;
                    //Checking if the deck is empty after every card dealt
                    if (deck.IsEmpty())
                    {
                        Console.WriteLine("The deck has run out of cards.");
                        Console.WriteLine("Would you like to repopulate the deck?");
                        Console.WriteLine("1 - Yes");
                        Console.WriteLine("2 - No");
                        input = Console.ReadLine();
                        //Validating the input of the user, tryparsing to ensure that an intiger is entered
                        //As well as that the intiger entered is within the set boundries
                    }
                    if (!Int32.TryParse(input, out number) || number < 1 || number > 2)
                    {
                        Console.Clear();
                        Console.WriteLine("You have not enetered one of the outlined values to use the menu, please try again.");
                    }
                    if (number == 1)
                    {
                        deck.Populate();
                        deck.Shuffle();
                        Console.WriteLine("The deck has been repopulated and reshuffled");
                        Console.WriteLine();
                    }
                    else if (number == 2)
                    {
                        Console.WriteLine("Bye.");
                        break;
                    }
                }


                else if (number == 2)
                {
                    Console.Clear();
                    try
                    {
                        deck.Shuffle();
                    }
                    catch (CardsNotShuffledException)
                    {
                        Console.WriteLine("The deck was not shuffled.");
                        Console.WriteLine("Shuffle the deck again to ensure it is shuffled");
                        continue;
                    }
                    Console.WriteLine("The deck has been shuffled.");
                    Console.WriteLine();
                }
                else if (number == 3)
                {
                    int reward = 1;
                    int round = 0;
                    user.score = 0;
                    cpu.score = 0;
                    bool playerWonLast = false;
                    Card userCard1;
                    Card userCard2;
                    Card cpuCard1;
                    Card cpuCard2;

                    while (round < 5)
                    {
                        if (playerWonLast)
                        {
                            userCard1 = user.CardPick();
                            userCard2 = user.CardPick();
                            fileLog.LogLine("Player has chosen their cards.");
                            cpuCard1 = cpu.CardPick();
                            cpuCard2 = cpu.CardPick();
                            fileLog.LogLine("Computer has chosen their cards.");
                        }
                        else
                        {
                            cpuCard1 = cpu.CardPick();
                            cpuCard2 = cpu.CardPick();
                            fileLog.LogLine("Computer has chosen their cards.");
                            userCard1 = user.CardPick();
                            userCard2 = user.CardPick();
                            fileLog.LogLine("Player has chosen their cards.");
                        }

                        int decision = game.Play(userCard1, userCard2, cpuCard1, cpuCard2);
                        fileLog.LogLine($"\n\n Player Cards: the {userCard1.Name} and the {userCard2.Name} ({userCard1.Value + userCard2.Value})");
                        fileLog.LogLine($"\n\n Computer Cards: the {cpuCard1.Name} and the {cpuCard2.Name}({cpuCard1.Value + cpuCard2.Value})");
                        if (decision == 1)
                        {
                            user.score = user.score + reward;
                            fileLog.LogLine("Player gains point!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            reward = 1;
                            round++;
                        }
                        else if (decision == -1)
                        {
                            cpu.score = cpu.score + reward;
                            fileLog.LogLine("Computer gains point!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            reward = 1;
                            round++;
                        }
                        else if (decision == 0)
                        {
                            //draw
                            fileLog.LogLine("Draw, move onto the next hand!");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            reward++;
                            round++;
                        }

                    }
                    if (game.Winner(user, cpu, fileLog) == 0)
                    {
                        int x = 0;
                        while (x == 0)
                        {

                            userCard1 = deck.Deal();
                            cpuCard1 = deck.Deal();
                            x = game.Stalemate(userCard1, cpuCard1, fileLog);
                        }
                    }
                    dealt = false;
                    fileLog.SaveLog();
                    Console.WriteLine("Thank you for playing!\nIf you would like to play again, deal some cards and enjoy the game again!");

                }
                else if (number == 4)
                {
                    Console.WriteLine("Bye.");
                    break;
                }

            }
            Console.ReadLine();*/
                    }
                }
            }
        
    
