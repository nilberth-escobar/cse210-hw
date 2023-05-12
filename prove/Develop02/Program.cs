using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Prompt
    {
        public string Question { get; set; }
        public DateTime Date { get; set; }
    }

    class Entry
    {
        public Prompt Prompt { get; set; }
        public string Response { get; set; }
    }

    class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"{entry.Prompt.Question} ({entry.Prompt.Date.ToShortDateString()}): {entry.Response}");
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Prompt.Question},{entry.Prompt.Date.ToShortDateString()},{entry.Response}");
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Prompt prompt = new Prompt { Question = parts[0], Date = DateTime.Parse(parts[1]) };
                    Entry entry = new Entry { Prompt = prompt, Response = parts[2] };
                    entries.Add(entry);
                }
            }
        }

        public Prompt GetRandomPrompt()
        {
            List<Prompt> prompts = new List<Prompt>
            {
                new Prompt { Question = "Who was the most interesting person I interacted with today?", Date = DateTime.Now },
                new Prompt { Question = "What was the best part of my day?", Date = DateTime.Now },
                new Prompt { Question = "How did I see the hand of the Lord in my life today?", Date = DateTime.Now },
                new Prompt { Question = "What was the strongest emotion I felt today?", Date = DateTime.Now },
                new Prompt { Question = "If I had one thing I could do over today, what would it be?", Date = DateTime.Now }
            };

            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();

            while (true)
            {
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Prompt prompt = journal.GetRandomPrompt();
                        Console.WriteLine(prompt.Question);
                        string response = Console.ReadLine();
                        Entry entry = new Entry { Prompt = prompt, Response = response };
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