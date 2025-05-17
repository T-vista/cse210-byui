using System;
using System.ComponentModel.DataAnnotations;

public class Journal 
{
    public static List<Entry> _entries = new List<Entry>();

    public static void AddEntry()
    {
        string _prompt = Entry.GetRandomPrompt();
        Console.WriteLine($"\n{_prompt}\n");
        Console.Write("Enter text here: ");
        string _enteredText = Console.ReadLine();
        string _date = DateTime.Now.ToString("M/d/yyyy");
        Entry entry = new Entry(_date,_prompt, _enteredText);
        _entries.Add(entry);
    }
    public static void DisplayAll()
    {
        foreach (var i in _entries)
        {
            i.Display();
        }
    }
    public static void SaveToFile()
    {
        Console.Write("Enter file name: ");
        string _fileName = Console.ReadLine();
        System.IO.StreamWriter file = new System.IO.StreamWriter($"c:\\{_fileName}");
        foreach (Entry i in _entries)
        {
            file.WriteLine(i.ToString());
        }

        file.Close();
    }
    public static void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file you want to load?");
        string _fileload = Console.ReadLine();
        List<string> _stringentries = File.ReadAllLines($"c:\\{_fileload}").ToList();
        foreach (string entry in _stringentries)
        {
            string[] parts = entry.Split(",");
            Entry newentry = new Entry(parts[0], parts[1], parts[2]);
            _entries.Add(newentry);
        }
    
    }
}