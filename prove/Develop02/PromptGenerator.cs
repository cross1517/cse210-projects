using System;

public class PromptGenerator
{
    Random randomGenerator = new Random();
    
    List<string> _prompts = new List<string>()
    {
        "Who did you see today that sticks out in your mind?",
        "What is something you learned today?",
        "What is something you are looking forward to?",
        "What is something you are grateful for?",
        "What is something you are proud of?",
        "What is something you are struggling with?",
        "What is something you are excited about?",
        "What blessings from the Lord have you noticed today?",
        "What miracles have you seen today?",
        "What is something you need to work on?",
    };
    
    public string GetRandomPrompt()
    {
        int randomPrompt = randomGenerator.Next(0, _prompts.Count);
        return _prompts[randomPrompt];
    }
    
}