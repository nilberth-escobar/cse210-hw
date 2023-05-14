using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Entry
    {
        public Prompt Prompt { get; set; }
        public string _response { get; set; }
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
                Console.WriteLine($"{entry.Prompt.Question} ({entry.Prompt.Date.ToShortDateString()}): {entry._response}");
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Prompt.Question},{entry.Prompt.Date.ToShortDateString()},{entry._response}");
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
                    Entry entry = new Entry { Prompt = prompt, _response = parts[2] };
                    entries.Add(entry);
                }
            }
        }
    }
}
