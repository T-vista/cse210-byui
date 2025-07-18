using System;
public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    private int _totalDuration;

    public void SetDuration(int dur)
    {
        _duration = dur;
    }
    public int GetTotalDuration()
    {
        return _totalDuration;
    }

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} \n\n{_description} \n\nHow long in seconds would you like to do this activity?");
        SetDuration(Convert.ToInt32(Console.ReadLine()));
        _totalDuration = _totalDuration + _duration;

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! you have completed {_duration} seconds of the {_name}!");
    }
    public void ShowSpinner(int _seconds)
    {
        for (int i = _seconds; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(333);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(334);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("\r" + i + " ");
            Thread.Sleep(1000);
        }
        // Console.WriteLine($"\rTimes up!");
        // Thread.Sleep(1000);
    }

}