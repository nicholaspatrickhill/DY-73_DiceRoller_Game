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
            WriteLine("\n\n\n\n\n\t\t\t\tL-let's play High Die!");
            Thread.Sleep(1000);
            WriteLine("\t\t\t\tRoll the dice. Then it's m-my turn.");
            WriteLine("\t\t\t\tWhoever rolls the highest number wins!");
            WriteLine("\n\t\t\t\t(Press enter to roll the dice...)");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)           
            Beep();

            Random numberGen = new Random();

            int playerRoll;
            int cpuRoll;

            playerRoll = numberGen.Next(1, 7);

            Thread.Sleep(500);
            WriteLine("\n\t\t\t\tYou rolled a " + playerRoll);
            Thread.Sleep(1000);
            WriteLine("\n\t\t\t\tNow it's m-my turn...");

            cpuRoll = numberGen.Next(1, 7);
            WriteLine("\n\t\t\t\tDY-73 rolled a " + cpuRoll);

            if (playerRoll == cpuRoll)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tThat's a draw!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerRoll < cpuRoll)
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tDY-73 wins!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
            else if (playerRoll > cpuRoll) 
            {
                Thread.Sleep(1500);
                WriteLine("\n\t\t\t\tYou win!");
                WriteLine("\n\t\t\t\t(Press any key to continue...)");
                ReadKey();
                ExitTheProgram();
            }
        }
    }
}
