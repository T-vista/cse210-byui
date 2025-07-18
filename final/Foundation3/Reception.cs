using System;

public class Reception : Event
{
    private string _RSVPemail;

    public Reception(string _title, string _description, DateTime _date, Address _address, string email) : base(_title, _description, _date, _address)
    {
        _RSVPemail = email;
    }

     public void FullDescription()
    {
        StandardDetail();
        Console.WriteLine($"RSVP at: {_RSVPemail}");
    }
    public void ShortDescription()
    {
        Console.WriteLine($"Reception\n{_title}\n{_date.Date}");
    }
}

