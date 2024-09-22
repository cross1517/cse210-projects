using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string gradeLetter = "";

        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
    
    
        if (gradeLetter == "F")
        {
            Console.WriteLine("You failed.");
        }
        else
        {
            Console.WriteLine("You passed. Congratulations!");
        }
        Console.WriteLine($"The grade is {gradeLetter}.");
    }
}