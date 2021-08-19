using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackCSharp
{
    public class Menu
    {
        public int MainMenu(bool dealt)
        {
            Title();
            while (true)
            { 
                Console.WriteLine("1 - Shuffle");
                Console.WriteLine("2 - Play");
                Console.WriteLine("3 - Exit");

                string input = Console.ReadLine();
                int number;
                //Validating the input of the user, tryparsing to ensure that an intiger is entered
                //As well as that the intiger entered is within the set boundries
                if (!Int32.TryParse(input, out number) || number < 1 || number > 3)
                {
                    Console.Clear();
                    Title();
                    Console.WriteLine("You have not enetered one of the outlined values to use the menu, please try again.");
                }
                if (number == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Shuffling Deck.");
                    Console.WriteLine();
                    return number;
                }
                if(number == 2)
                {
                    //Play the game
                    Console.Clear();
                    Title();
                    return number;
                }
                if (number == 3)
                {
                    //Close Program
                    System.Environment.Exit(1);
                }

            }

        }
        public int ShuffleMenu()
        {
            Console.WriteLine("The deck has run out of cards.");
            Console.WriteLine("Would you like to repopulate the deck?");
            Console.WriteLine("1 - Yes");
            Console.WriteLine("2 - No");
            string input = Console.ReadLine();
            //Validating the input of the user, tryparsing to ensure that an intiger is entered
            //As well as that the intiger entered is within the set boundries
            if (!Int32.TryParse(input, out int number) || number < 1 || number > 2)
            {
                Console.Clear();
                Title();
                Console.WriteLine("You have not enetered one of the outlined values to use the menu, please try again.");
            }
            if (number == 1)
            {
                Console.WriteLine("The deck has been repopulated and reshuffled");
                Console.WriteLine();
                return number;
                //Perform when called:
                ///deck.Populate();
                ///deck.Shuffle();
            }
            else if (number == 2)
            {
                Console.WriteLine("Bye.");
                ///Close Program
                return number;
            }
            return number;

        }
        public void Title()
        {
            Console.WriteLine(".------..------..------..------..------..------..------..------..------.");
            Console.WriteLine("|B.--. ||L.--. ||A.--. ||C.--. ||K.--. ||J.--. ||A.--. ||C.--. ||K.--. |");
            Console.WriteLine("| :(): || :/\\: || (\\/) || :/\\: || :/\\: || :(): || (\\/) || :/\\: || :/\\: |");
            Console.WriteLine("| ()() || (__) || :\\/: || :\\/: || :\\/: || ()() || :\\/: || :\\/: || :\\/: |");
            Console.WriteLine("| '--'B|| '--'L|| '--'A|| '--'C|| '--'K|| '--'J|| '--'A|| '--'C|| '--'K|");
            Console.WriteLine("`------'`------'`------'`------'`------'`------'`------'`------'`------'");
            Console.WriteLine();
        }
        public int PlayingMenu ()
        {
            bool drawn = false;
            Console.WriteLine("1 - Stand");
            Console.WriteLine("2 - Hit");
            if(!drawn)
            Console.WriteLine("3 - Double");

            string input = Console.ReadLine();
            int number;
            //Validating the input of the user, tryparsing to ensure that an intiger is entered
            //As well as that the intiger entered is within the set boundries
            if (!Int32.TryParse(input, out number) || number < 1 || number > 3)
            {
                Console.Clear();
                Title();
                Console.WriteLine("You have not enetered one of the outlined values to use the menu, please try again.");
            }
            return number;
        }
    }
}

