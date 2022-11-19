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
            int attempts = 0;

            WriteLine("Press any key to roll the die...");

            while (roll != 6)
            {
                ReadKey();

                roll = numberGen.Next(1, 7);
                WriteLine("You rolled: " + roll);
                attempts++;
            }

            WriteLine("It took you " + attempts + " attempts to roll a six.");




            ReadKey();
        }
        
    }
}