using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string _title, string _description, DateTime _date, Address _address, string speaker, int capacity) : base(_title, _description, _date, _address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDescription()
    {
        StandardDetail();
        Console.WriteLine($"Speaker Name: {_speaker}\nCapacity: {_capacity}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"Lecture\n{_title}\n{_date.Date}");
    }
}