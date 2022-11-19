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

            WriteLine("Press any key to roll the dice...");

            while (roll != roll2)
            {
                
                ReadKey();

                roll = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);

                WriteLine("You rolled a " + roll + " and a " + roll2);

                attempts++;

                if (roll == roll2)
                {                      
                    WriteLine("It took you " + attempts + " attempts to roll matching pair.");
                }
                
            }

            ReadKey();
        }
        
    }
}