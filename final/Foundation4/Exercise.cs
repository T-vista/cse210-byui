using System;

public abstract class Exercise
{
    private DateOnly _date;
    private double _time;
    public double time => _time;
    public DateOnly date => _date;
    public Exercise(double time, DateOnly date)
    {
        _time = time;
        _date = date;
    }
    public abstract void showSummary();
    public abstract double setSpeed();

    public abstract double setDistance();
    public abstract double setPace();
}