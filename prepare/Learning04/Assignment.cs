using System;
using System.Runtime.CompilerServices;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        string summary = $"{_studentName}-{_topic}";
        return summary;
    }
}