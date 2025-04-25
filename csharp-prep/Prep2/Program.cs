using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string grade_percent_text = Console.ReadLine();
        int grade_percent = int.Parse(grade_percent_text);

        // if else commands
        string pass;
        string grade;

        if (grade_percent >= 90)
        {
            pass = "pass";
            grade = "A";
        }
        else if (grade_percent >= 80)
        {
            pass = "pass";
            grade = "B";
        }
        else if (grade_percent >= 70)
        {
            pass = "pass";
            grade = "C";
        }
        else if (grade_percent >= 60)
        {
            pass = "fail";
            grade = "D";
        }
        else
        {
            pass = "fail";
            grade = "F";
        }
        Console.WriteLine($"Your grade is: {grade}, which means you {pass}");
    }
}