using System;
//base class
public abstract class Goal
{
    protected string _shortname { get; set; }
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortname = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string detail = $"[ ] {_shortname} ({_description})";
        return detail;
    }
    public virtual string GetStringRepresentation()
    {
        return $"Goal: {_shortname}|{_description}|{_points}";
    }
    public string GetShortName()
    {
        return _shortname;
    }


}