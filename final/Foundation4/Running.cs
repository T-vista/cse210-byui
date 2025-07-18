using System;

public class Running : Exercise
{
    private double _distance;
    public Running(int _time, DateOnly _date, double distance) : base(_time, _date)
    {
        _distance = distance;
    }
    public override double setDistance()
    {
        return _distance;
    }
    public override double setPace()
    {
        return time / _distance;
    }
    public override double setSpeed()
    {
        return _distance/time * 60;
    }
    public override void showSummary()
    {
        Console.WriteLine($"{date} Running ({time} min)- Distance {_distance} miles, Speed {setSpeed()} mph, Pace: {setPace} min per mile\n");
    }
}