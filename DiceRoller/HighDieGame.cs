using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static DY73DiceRoller.ConsoleMessages;

namespace DY73DiceRoller
{
    public class HighDieGame
    {
        public static void RunHighDieGame()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("L-let's play High Die!");
            Thread.Sleep(1000);
            WriteLine("Roll the dice. Then it's m-my turn.");
            WriteLine("Whoever rolls the highest number wins!");
            WriteLine("\n(Press enter to roll the dice...)");
            ReadKey();
            Beep();

            Random numberGen = new Random();

            int playerRoll;
            int cpuRoll;

            playerRoll = numberGen.Next(1, 7);

            Thread.Sleep(500);
            WriteLine("\nYou rolled a " + playerRoll + ".");
            Thread.Sleep(1000);
            WriteLine("\nNow it's m-my turn...");

            cpuRoll = numberGen.Next(1, 7);
            WriteLine("\nDY-73 rolled a " + cpuRoll + ".");

            if (playerRoll == cpuRoll)
            {
                Thread.Sleep(1500);
                WriteLine("\nThat's a draw!");
                WriteLine("\n(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerRoll < cpuRoll)
            {
                Thread.Sleep(1500);
                WriteLine("\nDY-73 wins!");
                WriteLine("\n(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerRoll > cpuRoll) 
            {
                Thread.Sleep(1500);
                WriteLine("\nYou win!");
                WriteLine("\n(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
        }
    }
}
