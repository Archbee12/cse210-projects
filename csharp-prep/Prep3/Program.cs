using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string keep_playing = "yes";

        while (keep_playing == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guessCount = 0;

            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                guessCount = guessCount + 1;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            Console.WriteLine($"It took you {guessCount} guesses");
            Console.Write("Would you like to play again {yes/no}? ");
            keep_playing = Console.ReadLine();
            if (keep_playing == "no")
            {
                Console.WriteLine("Thank you for playing. Goodbye.");
            }
        }
    }
}