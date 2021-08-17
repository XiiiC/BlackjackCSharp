using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Game
    {
        public int humanCardVal;
        public int computerCardVal;
        int winner;

        public int Play(Card hCard1, Card hCard2, Card cCard1, Card cCard2)
        {

            humanCardVal = hCard1.Value + hCard2.Value;
            computerCardVal = cCard1.Value + cCard2.Value;

            if (humanCardVal > computerCardVal)
            {
                winner = 1;
            }
            else if (humanCardVal < computerCardVal)
            {
                winner = -1;
            }
            else if (humanCardVal == computerCardVal)
            {
                winner = 0;
            }
            return winner;
        }
        public int Winner(Player human, Player computer, FileLog fileLog)
        {
            if (human.CompareTo(computer) == 1)
            {
                //player wins
                fileLog.LogLine($"Player Wins!\n\nHuman Score: {human.score}\nComputer Score: {computer.score}");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
                return 1;

            }
            else if (human.CompareTo(computer) == -1)
            {
                //computer wins
                fileLog.LogLine($"Computer Wins!\n\nComputer Score: {computer.score}\nHuman Score: {human.score}");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
                return -1;
            }
            else if (human.CompareTo(computer) == 0)
            {
                //draw
                fileLog.LogLine("Draw! Neither player wins!");
                fileLog.LogLine("Each player will draw one card, highest card wins!");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
                //each player draws one card, largest wins
                return 0;
            }
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
