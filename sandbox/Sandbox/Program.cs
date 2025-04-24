using System;

class Program
{
    static void Main(string[] args)
    {
        // get area of a circle
        Console.Write("Please enter the radius: ");
        string radius_input = Console.ReadLine();
        double radius = double.Parse(radius_input);

        // compute area of circle
        double area = Math.PI * radius * radius;

        Console.WriteLine($"the area of the circle with a radius of {radius} is: {area}");

        string words = "super cool";

        Console.WriteLine($"Hello {words} Sandbox World!");
    }
}