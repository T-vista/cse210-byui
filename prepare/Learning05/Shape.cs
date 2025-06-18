using System;

public abstract class Shape
{
    private string _color { get; set; }

    public abstract double GetArea();

    public Shape(string _color)
    {
        
    }
}

public class Square : Shape
{
    private double _side { get; set; }

    public Square(string _color, double side) : base(_color)
    {
        _side = side;
    }


    public override double GetArea()
    {
        return _side * _side;
    }
}

public class Rectangle : Shape
{
    private double _height { get; set; }
    private double _width { get; set; }

    public Rectangle(string _color, double width, double height) : base(_color)
    {
        _width = width;
        _height = height;
    }


    public override double GetArea()
    {
        return _width * _height;
    }
}

public class Circle : Shape
{
    private double _radius { get; set; }

    public Circle(string _color, double radius) : base(_color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}