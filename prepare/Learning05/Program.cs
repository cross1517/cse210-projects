using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment student1 = new MathAssignment("John", "World Domination", "Five", "1-10");
        Console.WriteLine($"{student1.GetSummary()}");
        Console.WriteLine($"{student1.GetHomeworkList()}");

        WritingAssignment student2 = new WritingAssignment("Jane", "World Domination", "The Art of World Domination");
        Console.WriteLine($"{student2.GetSummary()}");
        Console.WriteLine($"{student2.GetWritingInformation()}");
        
    }
}