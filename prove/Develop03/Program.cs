using System;

//I added a scripture library and implemented random choice of scripture to work on for my creativity aspect of the assignment.
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        library.LoadFromFile("scriptures.txt");

        
        string referenceText = library.RandomScripture();
        Scripture scripture = library.GetScripture(referenceText);

        bool quit = false;

        while (!quit && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"Is completely hidden: {scripture.IsCompletelyHidden()}");
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                quit = true;
            }

            else
            {
                Random randWords = new Random();
                int randNum = randWords.Next(1, 5);
                scripture.HideRandomWords(randNum);
            }
        }
        
    }
}