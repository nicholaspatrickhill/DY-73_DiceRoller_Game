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
    public class DoublesDiceGame
    {
        public static void RunDoublesDiceGame()
        {
            ForegroundColor= ConsoleColor.Green;
            WriteLine("L-let's play Doubles!");
            Thread.Sleep(1000);
            WriteLine("Roll the dice until you get d-doubles. Then it's m-my turn.");
            WriteLine("Whoever g-gets doubles in the fewest number of rolls wins!");
            WriteLine("\n(Press enter to roll the dice...)");

            Random numberGen = new Random();

            int playerRoll1 = 0;
            int playerRoll2 = 1;
            int playerAttempts = 0;

            while (playerRoll1 != playerRoll2)
            {
                ReadKey();
                Beep();

                playerRoll1 = numberGen.Next(1, 7);
                playerRoll2 = numberGen.Next(1, 7);

                Thread.Sleep(500);
                WriteLine("You rolled a " + playerRoll1 + " and a " + playerRoll2);

                playerAttempts++;

                if (playerRoll1 == playerRoll2)
                {
                    WriteLine("\nIt took you " + playerAttempts + " attempts to roll a matching pair!");
                    Thread.Sleep(1000);
                    WriteLine("\nNow it's m-my turn...");
                    {
                        Random cpuNumberGen = new Random();

                        int cpuRoll1 = 0;
                        int cpuRoll2 = 1;
                        int cpuAttempts = 0;

                        while (cpuRoll1 != cpuRoll2)
                        {
                            cpuRoll1 = cpuNumberGen.Next(1, 7);
                            cpuRoll2 = cpuNumberGen.Next(1, 7);

                            Thread.Sleep(500);
                            WriteLine("DY-73 rolled a " + cpuRoll1 + " and a " + cpuRoll2);

                            cpuAttempts++;

                            if (cpuRoll1 == cpuRoll2)
                            {
                                WriteLine("\nIt took DY-73 " + cpuAttempts + " attempts to roll a matching pair!");
                                if (playerAttempts == cpuAttempts)
                                {
                                    Thread.Sleep(1500);
                                    WriteLine("\nThat's a draw!");
                                    WriteLine("\n(Press any key to continue...)");
                                    ReadKey();
                                    ExitTheProgram();
                                }
                                else if (playerAttempts < cpuAttempts)
                                {
                                    Thread.Sleep(1500);
                                    WriteLine("\nYou win!");
                                    WriteLine("\n(Press any key to continue...)");
                                    ReadKey();
                                    ExitTheProgram();

                                }
                                else if (playerAttempts > cpuAttempts)
                                {
                                    Thread.Sleep(1500);
                                    WriteLine("\nDY-73 wins!");
                                    WriteLine("\n(Press any key to continue...)");
                                    ReadKey();
                                    ExitTheProgram();
                                }
                            }
                        }
                    }
                }
            }
        }      
    }
}
