using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static DY73DiceRoller.ConsoleMessages;

namespace DY73DiceRoller
{
    public class BestOfFiveGame
    {
        public static void RunBestOfFiveGame()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n\n\n\n\n\t\t\t\tL-let's play Best of Five!");
            Thread.Sleep(1000);
            WriteLine("\t\t\t\tRoll the dice. Then it's m-my turn.");
            WriteLine("\t\t\t\tWhoever rolls the highest number wins that round!");
            WriteLine("\t\t\t\tWe g-go five rounds. Best of f-five wins the game.");
            WriteLine("\n\t\t\t\t(Press enter to roll the dice...)");
            
            int playerScore = 0;
            int cpuScore = 0;

            for (int i = 0; i < 5; i++)
            {
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;    

                Random numberGen = new Random();

                int playerRoll;
                int playerRoll2;
                playerRoll = numberGen.Next(1, 7);
                playerRoll2 = numberGen.Next(1, 7);

                Thread.Sleep(500);
                Beep();
                WriteLine("\n\t\t\t\tYou rolled a " + playerRoll + " and a " + playerRoll2);

                int cpuRoll;
                int cpuRoll2;
                cpuRoll = numberGen.Next(1, 7);
                cpuRoll2 = numberGen.Next(1, 7);

                Thread.Sleep(1000);
                WriteLine("\t\t\t\tDY-73 rolled a " + cpuRoll + " and a " + cpuRoll2);

                int playerTotal = playerRoll+ playerRoll2;
                int cpuTotal = cpuRoll+ cpuRoll2;

                if (playerTotal > cpuTotal) 
                {
                    playerScore++;
                    Thread.Sleep(1500);
                    WriteLine("\n\t\t\t\tYou win this round!");
                }
                else if (playerTotal < cpuTotal)
                {
                    cpuScore++;
                    Thread.Sleep(1500);
                    WriteLine("\n\t\t\t\tDY-73 wins this round!");
                }
                else if (playerTotal == cpuTotal)
                {
                    Thread.Sleep(1500);
                    WriteLine("\n\t\t\t\tThat's a draw!");
                }
                WriteLine("\n\t\t\t\tThe score is you: " + playerScore + " | DY-73: " + cpuScore);
                WriteLine("\t\t\t\t(Press enter to continue...)");
            }

            if (playerScore > cpuScore)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tYou win Best of Five!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerScore < cpuScore) 
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tDY-73 wins Best of Five!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerScore == cpuScore)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tThe game ended in a draw!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
        }
    }
}
