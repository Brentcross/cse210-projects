using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int magicNumber = rnd.Next(1, 101);
        
        int userGuess = 0;
        
        Console.WriteLine("Guess the magic number anywhere between 1 and 100! ");

        while (userGuess != magicNumber)
        {
            Console.Write("  What is your guess? ");
            bool isNumber = int.TryParse(Console.ReadLine(), out userGuess);

            if (!isNumber)
            {
                Console.WriteLine("  Please enter a valid number.");
                continue;
            }

            if (userGuess < 1 || userGuess > 100)
            {
                Console.WriteLine("  Please enter a number between 1 and 100.");
                continue;
            }

            if (userGuess < magicNumber)
            {
                Console.WriteLine("  Higher");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("  Lower");
            }
        }

        Console.WriteLine("  You guessed it!");
    }
}
