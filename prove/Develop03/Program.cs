using System;

class Program
{
    static void Main(string[] args)
    {
        Reference nephi = new Reference("1 Nephi", 3, 7);
        Scripture firstNephi3 = new Scripture();
        bool _end = firstNephi3.IsCompletelyHidden();

        while (_end == false)
        {
            Console.WriteLine(firstNephi3.GetDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            Console.ReadLine();
            Console.Clear();
            firstNephi3.HideRandomWords();
            _end = firstNephi3.IsCompletelyHidden();
        }
    }
}