using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static DY73DiceRoller.DoublesDiceGame;

namespace DY73DiceRoller
{
    public class IntroScreens
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
            WriteLine("What is your name? (Type your name and press enter...)");
            string? PlayerName = ReadLine();
            Thread.Sleep(1500);
            WriteLine("...");
            Thread.Sleep(1500);
            WriteLine("H-How nice to meet you, " + PlayerName + "!");
            WriteLine("Would you like to play a game?");
            Thread.Sleep(1500);
            WriteLine("\n(Press any key to continue...)");
            ReadKey();
            Clear();
            PlayerDoublesDiceGame();   
        }

        public static void ExitMethod()
        {
            WriteLine("\nType y and hit enter. Or Type n and hit enter to quit.");

            string? input = ReadLine();

            switch (input)
            {
                case "y":
                    Clear();
                    PlayerDoublesDiceGame();
                    break;
                case "n":
                    WriteLine("Goodbye!\n\n\n\n\n");
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("Invalid Input. Please Try Again.");
                    ExitMethod();
                    break;
            }
        }
    }
}
