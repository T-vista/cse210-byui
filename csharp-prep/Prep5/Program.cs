using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUsername()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string userName, int number)
        {
            int square = SquareNumber(number);
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }

        DisplayWelcome();
        string user = PromptUsername();
        int num = PromptUserNumber();
        DisplayResult(user, num);
    }
}