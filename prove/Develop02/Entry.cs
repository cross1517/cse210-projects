using System;


public class Entry
{
    public string _dateText;
    public string _entryText;
    public string _promptText;
    public string _moodText;


 public Entry(string promptText, string entryText, string moodText)
 {
    DateTime theCurrentTime = DateTime.Now;
    _dateText = theCurrentTime.ToString("MM/dd/yyyy");
    _promptText = promptText;
    _entryText = entryText;
    _moodText = moodText;

 }

 public void DisplayEntry()
 {
    Console.WriteLine($"Date: {_dateText}");
    Console.WriteLine($"Mood: {_moodText}");
    Console.WriteLine($"Prompt: {_promptText}");
    Console.WriteLine($"Entry: {_entryText}");
 }

}