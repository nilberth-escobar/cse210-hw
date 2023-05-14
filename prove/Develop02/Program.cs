using System;

namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            while (true)//creating the menu
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();//reading user's option
                Console.WriteLine();

                switch (choice)//options
                {
                    case "1":
                        Prompt prompt = PromptGenerator.GetRandomPrompt();
                        Console.WriteLine(prompt._question);
                        string response = Console.ReadLine();
                        Entry entry = new Entry { Prompt = prompt, _response = response };
                        journal.AddEntry(entry);
                        break;


                    case "2":
                        journal.DisplayEntries();
                        break;

                    case "3":
                        Console.WriteLine("Please enter a filename to save to:");
                        string saveFilename = Console.ReadLine();
                        journal.SaveToFile(saveFilename);
                        break;

                    case "4":
                        Console.WriteLine("Please enter a filename to load from:");
                        string loadFilename = Console.ReadLine();
                        journal.LoadFromFile(loadFilename);
                        break;

                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }

                Console.WriteLine();
            }   
        }
    }
}