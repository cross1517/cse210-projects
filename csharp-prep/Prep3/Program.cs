using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string continueGame = "y";
        while (continueGame == "y")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            Console.WriteLine("What is your guess?");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);

            int guesses = 0;
            do
            {
                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                    Console.WriteLine("What is your guess?");
                    guess = Console.ReadLine();
                    guessNumber = int.Parse(guess);
                }
                else
                {
                    Console.WriteLine("Too high. Try again.");
                    Console.WriteLine("What is your guess?");
                    guess = Console.ReadLine();
                    guessNumber = int.Parse(guess);
                }
                guesses++;
            } while (guessNumber != magicNumber);

            string textGuesses = guesses.ToString();
            Console.WriteLine($"You guessed the magic number in {textGuesses} tries, congratulations!");

            Console.WriteLine("Would you like to play again? (y/n)");
            continueGame = Console.ReadLine();
        }
    }
}