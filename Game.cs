using System;
using System.Collections.Generic;

namespace BlackJackCSharp
{
    public class Game
    {

        Deck deck = new Deck();
        User user = new User();
        CPU cpu = new CPU();
        Menu menu = new Menu();

        bool playerDrawn = false;
        public void SetUp()
        {
            Console.Clear();
            user.ClearHand();
            cpu.ClearHand();
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
            menu.Title();
            user.AddCard(dealtCard);
            user.CardShow();
            dealtCard = deck.Deal();
            cpu.AddCard(dealtCard);
            cpu.HiddenCardShow();
            Console.ReadLine();
        }
        public void Play()
        {

            Dealing();
            bool standing = false;
            int userCardVal = user.CardValue();
            while (!standing)
            {
                userCardVal = user.CardValue();
                if (userCardVal > 21)
                {
                    Console.WriteLine("Player Busts");
                    Console.ReadLine();
                    SetUp();
                }
                int choice = menu.PlayingMenu();
                switch (choice)
                {
                    case 1:
                        Stand();
                        standing = true;
                        playerDrawn = true;
                        break;
                    case 2:
                        Hit();
                        if (userCardVal > 21)
                        {
                            standing = true;
                        }
                        break;
                    case 3:
                        if (!playerDrawn)
                        {
                            Double();
                            standing = true;
                        }
                        break;
                }
            }

            if (userCardVal <= 21)
            {
                Console.ReadLine();
                DealerTurn();
            }
            else
            {
                userCardVal = user.CardValue();
                if(userCardVal > 21)
                {
                    Console.WriteLine("Play Busts");
                    Console.ReadLine();
                    SetUp();
                }
            }
        }
            /// DEALER CHECKS TO DRAW
            /// 
            ///COMPARING
            //user recieves card, presented as the ascii visual of the card that the player ##done





            //cpu recieves card, this one is hidden to the player, presnted as the ascii art visual for a face down card##done
            //user recieves second card##done
            //also need like a value being presented by both players##done
            //give cpu second card, this one face up##done
            //ask user if they want to, hit, stand or double#done
            //if the 2 cards the player has, offer a split, if split provide user with 2 hands, this will be implemented much later after groundwork#nop
            //if player's card value is over 21 they lose#done
            //once player stands, reveal cpu hidden card and output value#done
            //if cpu card value is under user's and is under 17, hit#done
            //if cpu busts, player wins#done
            //if either player or cpu gets BlackJack they instantly win btw
            //when both players stand, compare values, highest value that doesnt go over 21 wins,#done
            //if value is equal its a push, aka draw

        
        public void Hit()
        {
            Console.Clear();
            var dealtCard = deck.Deal();
            user.AddCard(dealtCard);
            user.CardShow();
            cpu.HiddenCardShow();
            Console.ReadLine();

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
        public void DealerTurn()
        {
            int cpuCardVal = cpu.CardValue();
            int userCardVal = user.CardValue();
            while(cpuCardVal < userCardVal && cpuCardVal < 17)
            {
                //draw
                Console.Clear();
                var dealtCard = deck.Deal();
                cpu.AddCard(dealtCard);
                user.CardShow();
                cpu.CardShow();
                Console.ReadLine();
                
                cpuCardVal = cpu.CardValue();
            }
            
            if (cpuCardVal > 21)
            {
                //dealer bust
                Console.WriteLine("Dealer Bust");
                Console.ReadLine();
                SetUp();
            }
            else if (cpuCardVal > userCardVal)
            {
                //dealer wins
                Console.WriteLine("Dealer Wins");
                Console.ReadLine();
                SetUp();
            }
            else if (cpuCardVal < userCardVal && cpuCardVal >= 17)
            {
                //player wins
                Console.WriteLine("Player Wins");
                Console.ReadLine();
                SetUp();
                //exit loop
            }
            else if (cpuCardVal == userCardVal)
            {
                //draw
                Console.WriteLine("Draw");
                Console.ReadLine();
                SetUp();
            }
        }

    }
}
