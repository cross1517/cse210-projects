using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = PromptUserName();
        int number = 0;
        number = PromptUserNumber(number);
        int square = SquareNumber(number);
        DisplayResults(userName, number, square);
    }
    
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}!");
        return userName;
    }

    static int PromptUserNumber(int number)
    {
        Console.WriteLine("What is your favorite number?");
        string userNumber = Console.ReadLine();
        number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResults(string userName, int number, int square)
    {
        Console.WriteLine($"Thank you, {userName}.");
        Console.WriteLine($"Your favorite number is {number}.");
        Console.WriteLine($"The square of {number} is {square}.");
    }
}
