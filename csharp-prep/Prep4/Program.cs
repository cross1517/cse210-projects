using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int newNumber = 1;
        int total = 0;
        int greatestNumber = 0;
        int listLength = numbers.Count;

        while (newNumber != 0)
        {
            Console.WriteLine("Enter a number:");
            string numberUser = Console.ReadLine();
            newNumber = int.Parse(numberUser);
            numbers.Add(newNumber);
            listLength = numbers.Count;
            total += newNumber;
            //Console.WriteLine($"The total is {total}.");
            //Console.WriteLine($"The length is {listLength}.");
            foreach (int number in numbers)
            {
            if (number > greatestNumber)
            {
                greatestNumber = number;
            }
            }
            //Console.WriteLine($"The greatest number is {greatestNumber}.");
        }

        

        

        double average = total / listLength;

        Console.WriteLine($"The total is {total}.");
        Console.WriteLine($"The average is {average:F4}.");
        Console.WriteLine($"The greatest number is {greatestNumber}.");
    }
}