using System.Net.Security;
using static System.Console;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            RunIntroScreen();

            string? PlayerName = RunPlayerNameScreen();

            WriteLine("(Press any key to roll the dice...)");

            DoublesDiceGame(PlayerName);
        }

        private static void RunIntroScreen()
        {
            WriteLine("...");
            Thread.Sleep(1000);
            WriteLine(".....");
            Thread.Sleep(1500);
            WriteLine("H-Hello. M-my name is DY-73.");
            Thread.Sleep(1500);
            WriteLine("I must've been asleep for some time.");
            Thread.Sleep(1500);
            WriteLine("\n(Press any key to continue...)");
            ReadKey();
            Clear();
        }

        private static string? RunPlayerNameScreen()
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
            return PlayerName;
        }


        private static void DoublesDiceGame(string? PlayerName)
        {
            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            while (roll != roll2)
            {
                ReadKey();
                Beep();

                roll = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);

                Thread.Sleep(500);
                WriteLine(PlayerName + " rolled a " + roll + " and a " + roll2);

                attempts++;

                if (roll == roll2)
                {
                    WriteLine("\nIt took " + PlayerName + " " + attempts + " attempts to roll a matching pair!");
                }
            }

            ExitMethod(PlayerName);
        }


        private static void ExitMethod(string? PlayerName)
        {
            WriteLine("\nWould you like to try again? Type y and hit enter. Or Type n and hit enter to quit.");

            string? input = ReadLine();

            switch (input)
            {
                case "y":
                    WriteLine("\nPress any key to roll the dice again...");
                    DoublesDiceGame(PlayerName);
                    break;
                case "n":
                    WriteLine("\nGoodbye!\n\n\n\n\n");
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("Invalid Input. Please Try Again.");
                    ExitMethod(PlayerName);
                    break;
            }
        }
    }
}