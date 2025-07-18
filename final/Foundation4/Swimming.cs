using System;

public class Swimming : Exercise
{
    private double _nLaps;
    public Swimming(int _time, DateOnly _date, double nLaps) : base(_time, _date)
    {
        _nLaps = nLaps;
    }
    public override double setDistance()
    {
        return _nLaps * 50 / 1000 * 0.62;
    }
    public override double setPace()
    {
        return time/ setDistance();
    }
    public override double setSpeed()
    {
        return setDistance()/time *60;
    }
    public override void showSummary()
    {
        Console.WriteLine($"{date} Swimming ({time} min)- Distance {setDistance()} miles, Speed {setSpeed} mph, Pace: {setPace} min per mile\n");
    }
}