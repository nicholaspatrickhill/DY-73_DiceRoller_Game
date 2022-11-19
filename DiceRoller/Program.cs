using System.Net.Security;
using static System.Console;

namespace DiceRoller

{
    internal class Program
    {
        // get the program to roll two dice until getting two of a kind
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            WriteLine("Hello and welcome to Dice Roll. What is your name?");
            string? PlayerName = ReadLine();

            WriteLine("\nWelcome to Dice Roll, " + PlayerName + ". " + "Press any key to roll the dice...");

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

            ReadKey();
        }
        
    }
}