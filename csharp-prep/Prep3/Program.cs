using System;

class Program
{
    static void Main(string[] args)
    {
        // get magic number
        Random random = new Random();
        int magic_number = random.Next(1, 101);

        // declare guess
        string guess_number_string;   
        int guess_number;

        do 
        {
            Console.Write("What is your guess?: ");
            guess_number_string = Console.ReadLine();   
            guess_number = int.Parse(guess_number_string);
            if (guess_number < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess_number > magic_number) 
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }
        while (guess_number != magic_number);


    }
}