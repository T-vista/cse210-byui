using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, enter 0 when finished");
        int number = 1;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string number_string = Console.ReadLine();
            number = int.Parse(number_string);
            
            if (number != 0)
            {
                numbers.Add(number);
            }
            else 
            {
                break;
            }
        }

        int sum = 0;
        int greatest = 0;
        foreach (int num in numbers)
        {
            sum = num + sum;
            if (num > greatest)
            {
                greatest = num;
            }
        }
        int average = sum / numbers.Count;
    

        Console.WriteLine($"\nThe sum is: {sum}\nThe average is: {average}\nThe largest number is: {greatest}");
    }
}