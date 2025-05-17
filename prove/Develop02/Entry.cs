using System;
using System.Security.Cryptography.X509Certificates;
public class Entry
{
    public string _date;

    public string _promptText;

    public string _enteredText;
    //Constructor
    public Entry(string date, string promptText, string enteredText)
    {
        _date = date;
        _promptText = promptText;
        _enteredText = enteredText;

    }

    public void Display()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_enteredText}\n");
    }

    static List<string> _prompts = new List<string>{"Who did you meet today?", "What made you the most happy today?",
    "What was the worst part of today?", "What did you learn today?",
    "What did you get done today that made you the most proud?", "What do you wish you had done better at today?"};

    public static string GetRandomPrompt()
    {
        var random = new Random();
        int _index = random.Next(_prompts.Count);
        string _prompt = _prompts[_index];

        return _prompt;
    }

    // convert to string
    public override string ToString()
    {
        return $"{_date},{_promptText},{_enteredText}";
    }

}  
