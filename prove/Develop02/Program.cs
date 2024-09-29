using System;


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            DisplayMenu();
            int userChoice = int.Parse(Console.ReadLine());
            
            
            ExecuteChoice(userChoice);
        }
        
        void DisplayMenu()
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Exit");
            Console.WriteLine("");
            Console.WriteLine("Please select an option:");
        }

        void ExecuteChoice(int userChoice)
        {
            if (userChoice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine("Please rate your mood on a scale of 1-5 (1 being the worst and 5 being the best):");
                string moodText = Console.ReadLine();
                Console.WriteLine($"{prompt}");
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(prompt, entryText, moodText);
                journal.AddEntry(newEntry);
            }

            else if (userChoice == 2)
            {
                
                journal.DisplayJournal();
            }
            else if (userChoice == 3)
            {
                journal.SaveJournal();
            }
            else if (userChoice == 4)
            {
                journal.LoadJournal();
            }
            else if (userChoice == 5)
            {
                Console.WriteLine("Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}