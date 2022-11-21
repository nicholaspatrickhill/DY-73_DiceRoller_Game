using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DiceRoller;
using static System.Console;
using static DY73DiceRoller.DoublesDiceGame;
using static DY73DiceRoller.HighDieGame;

namespace DY73DiceRoller
{
    public class ConsoleMessages
    {
        public static void RunIntroScreen()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n\n\n\n\n\t\t\t\t...");
            Thread.Sleep(1000);
            WriteLine("\t\t\t\t.....");
            Thread.Sleep(1500);
            WriteLine("\n\t\t\t\tH-Hello. M-my name is DY-73.");
            Thread.Sleep(1500);
            WriteLine("\n\t\t\t\tI must've been asleep for some time.");
            Thread.Sleep(1500);
            WriteLine("\n\t\t\t\t(Press any key to continue...)");
            ReadKey();
            Clear();
            RunPlayerNameScreen();
        }

        private static void RunPlayerNameScreen()
        {
            WriteLine("\n\n\n\n\n\t\t\t\tI am an AI f-from KEPLER 186F.");
            Thread.Sleep(1500);
            WriteLine("\t\t\t\tI am not sure how I got here.");
            Thread.Sleep(1500);
            WriteLine("\n\t\t\t\tWhat is your name? (Type your name and press enter...)");
            Write("\t\t\t\t");
            string? PlayerName = ReadLine();
            Thread.Sleep(1500);
            WriteLine("\t\t\t\t...");
            Thread.Sleep(1500);
            WriteLine("\n\t\t\t\tH-How nice to meet you, " + PlayerName + "!");
            WriteLine("\t\t\t\tLet's play a game!");
            Thread.Sleep(1500);
            WriteLine("\n\t\t\t\t(Press any key to continue...)");
            ReadKey();
            SelectGame();
        }

        private static void SelectGame()
        {
            {
                string prompt = "\n\n\n\n\n\t\t\t\tWhich game would you like to play?\n\t\t\t\t(Select a game and press enter...)";
                string[] options = { "\n\t\t\t\tHigh Die", "\t\t\t\tDoubles" };

                Menu exitMenu = new Menu(prompt, options);
                int selectedIndex = exitMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Thread.Sleep(1000);
                        Clear();
                        RunHighDieGame();
                        break;
                    case 1:
                        Thread.Sleep(1000);
                        Clear();
                        RunDoublesDiceGame();
                        break;
                }
            }
        }

        public static void ExitTheProgram()
        {
            {
                string prompt = "\n\n\n\n\n\t\t\t\tWould you like to play another g-game?\n\t\t\t\t(Select yes or no and press enter...)";
                string[] options = { "\n\t\t\t\tyes", "\t\t\t\tno" };

                Menu exitMenu = new Menu(prompt, options);
                int selectedIndex = exitMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Thread.Sleep(1000);
                        Clear();
                        SelectGame();
                        break; 
                    case 1:
                        Thread.Sleep(1000);
                        ForegroundColor = ConsoleColor.Green;
                        WriteLine("\n\t\t\t\tGoodbye\n\n\n\n\n");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
