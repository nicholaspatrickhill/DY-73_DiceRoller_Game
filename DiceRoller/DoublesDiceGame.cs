using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static DY73DiceRoller.IntroScreens;

namespace DY73DiceRoller
{
    public class DoublesDiceGame
    {
        public static void PlayerDoublesDiceGame()
        {
            WriteLine("W-Welcome to Doubles!");
            WriteLine("Roll the dice until you get doubles. Then I'll do the same.");
            WriteLine("Whoever reaches doubles in the fewest number of rolls wins!");
            WriteLine("\nPress any key to roll the dice...");

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
                    Thread.Sleep(1500);
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
                                    WriteLine("\nDraw! Would you like to play again?");
                                    ExitMethod();
                                    Clear();
                                }
                                else if (playerAttempts < cpuAttempts)
                                {
                                    WriteLine("\nYou win! Would you like to play again?");
                                    ExitMethod();
                                    Clear();
                                }
                                else if (playerAttempts > cpuAttempts)
                                {
                                    WriteLine("\nI win! Would you like to play again?");
                                    ExitMethod();
                                    Clear();
                                }
                            }
                            if (cpuRoll1 == 1 && cpuRoll2 == 1)
                            {
                                WriteLine("\nSnake Eyes! That's an automatic win!");
                                ExitMethod();
                            }
                        }
                    }
                    if (playerRoll1 == 1 && playerRoll2 == 1)
                    {
                        WriteLine("\nSnake Eyes! That's an automatic win!");
                        ExitMethod();
                    }
                }
            }
        }      
    }
}
