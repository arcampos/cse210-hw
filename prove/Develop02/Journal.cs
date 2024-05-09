using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date)
    {
        Entry newEntry = new Entry();
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.Date}: {entry.Prompt}; {entry.Response}");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Prompt}, {entry.Response},{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine())!= null)
                {
                    string[] parts = line.Split(',');
                    string prompt = parts[0];
                    string response = parts[1];
                    string date = parts[2];
                    Entry newEntry = new Entry();
                    entries.Add(newEntry);
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}