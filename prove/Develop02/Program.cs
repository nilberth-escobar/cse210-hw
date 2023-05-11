/*using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 45;
        Console.WriteLine("Hello Sandbox World!");
        Console.WriteLine(x);
    }
} */

using System;
using System.IO;
using System.Collections.Generic;

class JournalEntry
{
    public string Text { get; set; }
    public DateTime DateTime { get; set; }

    public JournalEntry(string text)
    {
        Text = text;
        DateTime = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{DateTime}: {Text}";
    }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private string fileName;

    public Journal(string fileName)
    {
        this.fileName = fileName;
        if (File.Exists(fileName))
        {
            LoadEntries();
        }
    }

    public void AddEntry(string text)
    {
        entries.Add(new JournalEntry(text));
    }

    public void DisplayEntries()
    {
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveEntries()
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in entries)
            {
                writer.WriteLine($"{entry.DateTime},{entry.Text}");
            }
        }
    }

    private void LoadEntries()
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new char[] { ',' }, 2);
                if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime dateTime))
                {
                    entries.Add(new JournalEntry(parts[1]) { DateTime = dateTime });
                }
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal("journal.txt");

        while (true)
        {
            Console.WriteLine("1. write");
            Console.WriteLine("2. display");
            Console.WriteLine("3. save");
            Console.WriteLine("4. load");
            Console.WriteLine("5. quit");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter your journal entry:");
                    string text = Console.ReadLine();
                    journal.AddEntry(text);
                    Console.WriteLine("Entry added.");
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveEntries();
                    Console.WriteLine("Entries saved.");
                    break;
                case "4":
                    journal = new Journal("journal.txt");
                    Console.WriteLine("Entries loaded.");
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
        }
    }
}