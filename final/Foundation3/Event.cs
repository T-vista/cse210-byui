using System;

public class Event
{
    protected string _title;
    private string _description;
    protected DateTime _date;
    private Address _address;

    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }

    public void StandardDetail()
    {
        string time = _date.ToString("h:mm tt");
        Console.WriteLine($"{_title}\n{_description}\n{_date.Date} at {time}\n{_address.DisplayAddress}");
    }

}