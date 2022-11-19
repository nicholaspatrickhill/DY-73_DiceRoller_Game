using System.Net.Security;
using static System.Console;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("What is your name?");
            string? PlayerName = ReadLine();

            WriteLine("\nWelcome to Dice Roll, " + PlayerName + ". " + "Press any key to roll the dice...");

            RollDice(PlayerName);
        }

        private static void ExitMethod(string? PlayerName)
        {
            WriteLine("\nWould you like to try again? Type y and hit enter. Or Type n and hit enter to quit.");

            string? input = ReadLine();

            switch (input)
            {
                case "y":
                    WriteLine("\nPress any key to roll the dice again...");
                    RollDice(PlayerName);
                    break;
                case "n":
                    WriteLine("Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    WriteLine("Invalid Input. Please Try Again.");
                    ExitMethod(PlayerName);
                    break;
            }
        }

        private static void RollDice(string? PlayerName)
        {
            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            while (roll != roll2)
            {
                ReadKey();

                roll = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);

                WriteLine(PlayerName + " rolled a " + roll + " and a " + roll2);

                attempts++;

                if (roll == roll2)
                {
                    WriteLine("It took " + PlayerName + " " + attempts + " attempts to roll matching pair.");
                }
            }

            ExitMethod(PlayerName);
        }
    }
}