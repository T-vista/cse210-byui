using System;

public class OutdoorGathering : Event
{
    private string _Weather;

    public OutdoorGathering(string _title, string _description, DateTime _date, Address _address, string weather) : base(_title, _description, _date, _address)
    {
        _Weather = weather;
    }

     public void FullDescription()
    {
        StandardDetail();
        Console.WriteLine($"Plan for {_Weather} weather!");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"Reception\n{_title}\n{_date.Date}");
    }
}