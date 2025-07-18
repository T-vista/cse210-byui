using System;

public class Cycling : Exercise
{
    private int _speed;
    public Cycling(int _time, DateOnly _date, int speed) : base(_time, _date)
    {
        _speed = speed;
    }
    public override double setDistance()
    {
        return _speed * time;
    }
    public override double setPace()
    {
        return _speed*60;
    }
    public override double setSpeed()
    {
        return _speed;
    }
    public override void showSummary()
    {
        Console.WriteLine($"{date} Cycling ({time} min)- Distance {setDistance} miles, Speed {setSpeed} mph, Pace: {setPace} min per mile\n");
    }
}