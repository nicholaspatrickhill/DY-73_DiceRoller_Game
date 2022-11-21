using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static DY73DiceRoller.ConsoleMessages;

namespace DY73DiceRoller
{
    public class DoublesGame
    {
        public static void RunDoublesGame()
        {
            ForegroundColor= ConsoleColor.Green;
            WriteLine("\n\n\n\n\n\t\t\t\tL-let's play Doubles!");
            Thread.Sleep(1000);
            WriteLine("\t\t\t\tRoll the dice until you get d-doubles. Then it's m-my turn.");
            WriteLine("\t\t\t\tWhoever g-gets doubles in the fewest number of rolls wins!");
            WriteLine("\n\t\t\t\t(Press enter to roll the dice...)");

            Random numberGen = new Random();

            int playerRoll1 = 0;
            int playerRoll2 = 1;
            int playerAttempts = 0;

            while (playerRoll1 != playerRoll2)
            {
                while (Console.ReadKey(true).Key != ConsoleKey.Enter);

                // player rolls their dice:
                playerRoll1 = numberGen.Next(1, 7);
                playerRoll2 = numberGen.Next(1, 7);
                Thread.Sleep(500);
                Beep();
                WriteLine("\t\t\t\tYou rolled a " + playerRoll1 + " and a " + playerRoll2);

                // attempts to roll doubles are recorded:
                playerAttempts++;

                if (playerRoll1 == playerRoll2)
                {
                    WriteLine("\n\t\t\t\tIt took you " + playerAttempts + " attempts to roll a matching pair!");
                    RunCPUDoublesTurn(playerAttempts);
                }
            }
        }

        private static void RunCPUDoublesTurn(int playerAttempts)
        {
            Thread.Sleep(1000);
            WriteLine("\n\t\t\t\tNow it's m-my turn...");
            {
                Random cpuNumberGen = new Random();

                int cpuRoll1 = 0;
                int cpuRoll2 = 1;
                int cpuAttempts = 0;

                while (cpuRoll1 != cpuRoll2)
                {
                    // cpu rolls their dice:
                    cpuRoll1 = cpuNumberGen.Next(1, 7);
                    cpuRoll2 = cpuNumberGen.Next(1, 7);
                    Thread.Sleep(500);
                    WriteLine("\t\t\t\tDY-73 rolled a " + cpuRoll1 + " and a " + cpuRoll2);

                    // attempts to roll doubles are recorded:
                    cpuAttempts++;

                    if (cpuRoll1 == cpuRoll2)
                    {
                        WriteLine("\n\t\t\t\tIt took DY-73 " + cpuAttempts + " attempts to roll a matching pair!");
                        DetermineDoublesWinner(playerAttempts, cpuAttempts);
                    }
                }
            }
        }

        private static void DetermineDoublesWinner(int playerAttempts, int cpuAttempts)
        {
            // each player's attempts to roll doubles are compared to determine the winner of the game:
            if (playerAttempts == cpuAttempts)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tThat's a draw!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerAttempts < cpuAttempts)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tYou win!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();

            }
            else if (playerAttempts > cpuAttempts)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tDY-73 wins!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
        }
    }
}
