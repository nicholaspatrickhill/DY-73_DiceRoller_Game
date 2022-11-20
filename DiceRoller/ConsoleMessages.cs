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
            WriteLine("...");
            Thread.Sleep(1000);
            WriteLine(".....");
            Thread.Sleep(1500);
            WriteLine("H-Hello. M-my name is DY-73.");
            Thread.Sleep(1500);
            WriteLine("\nI must've been asleep for some time.");
            Thread.Sleep(1500);
            WriteLine("\n(Press any key to continue...)");
            ReadKey();
            Clear();
            RunPlayerNameScreen();
        }

        public static void RunPlayerNameScreen()
        {
            WriteLine("I am an AI f-from KEPLER 186F.");
            Thread.Sleep(1500);
            WriteLine("I am not sure how I got here.");
            Thread.Sleep(1500);
            WriteLine("\nWhat is your name? (Type your name and press enter...)");
            string? PlayerName = ReadLine();
            Thread.Sleep(1500);
            WriteLine("...");
            Thread.Sleep(1500);
            WriteLine("H-How nice to meet you, " + PlayerName + "!");
            WriteLine("Would you like to play a game?");
            Thread.Sleep(1500);
            WriteLine("\n(Press any key to continue...)");
            ReadKey();
            SelectGame();
        }

        public static void SelectGame()
        {
            {
                string prompt = "Which game would you like to play?\n(Select a game and press enter...)";
                string[] options = { "\nHigh Die", "Doubles" };

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
                string prompt = "Would you like to play another g-game?\n(Select yes or no and press enter...)";
                string[] options = { "\nyes", "no" };

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
                        Thread.Sleep(300);
                        WriteLine("Goodbye!\n\n\n\n\n");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
