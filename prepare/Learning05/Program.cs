using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Rectangle rectangle = new Rectangle("Yellow", 3, 6);
        Circle circle = new Circle("green", 5);

        Console.WriteLine(square.GetArea());
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(circle.GetArea());
    }
}