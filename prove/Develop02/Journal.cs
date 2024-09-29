using System;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();
    public string _journal = "journal.txt";
    

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);

    }

    public void SaveJournal()
    {
        using (StreamWriter writer = new StreamWriter(_journal))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._dateText}|{entry._moodText}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadJournal()
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines("journal.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string date = parts[0];
            string mood = parts[1];
            string prompt = parts[2];
            string entry = parts[3];
            Entry newEntry = new Entry(prompt, entry, mood);
            newEntry._dateText = date;
            _entries.Add(newEntry);
        }
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

}