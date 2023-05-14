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

        public void DisplayEntries()//displaying the entries
        {
            foreach (Entry entry in entries)//iterating the file to show the entries
            {
                Console.WriteLine($"{entry.Prompt._question} ({entry.Prompt.Date.ToShortDateString()}): {entry._response}");
            }
        }

        public void SaveToFile(string filename)//saving the entries into a file
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Prompt._question},{entry.Prompt.Date.ToShortDateString()},{entry._response}");
                    
                }
            }
        }

        public void LoadFromFile(string _filename)
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(_filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Prompt prompt = new Prompt { _question = parts[0], Date = DateTime.Parse(parts[1]) };
                    Entry entry = new Entry { Prompt = prompt, _response = parts[2] };
                    entries.Add(entry);
                }
            }
        }
    }
}