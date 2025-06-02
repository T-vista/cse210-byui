using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Tyler Vistaunet", "Fractions", "Section 7.3", "Problems 8-9");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Tyler Vistaunet", "European History", "The causes of WW2 by Mary Waters");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}