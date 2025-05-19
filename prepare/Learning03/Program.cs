using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction five = new Fraction(5);
        Fraction threequarters = new Fraction(3, 4);
        Fraction oneThird = new Fraction(1, 3);

        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(five.GetFractionString());
        Console.WriteLine(five.GetDecimalValue());
        Console.WriteLine(threequarters.GetFractionString());
        Console.WriteLine(threequarters.GetDecimalValue());
        Console.WriteLine(oneThird.GetFractionString());
        Console.WriteLine(oneThird.GetDecimalValue());
    }
}