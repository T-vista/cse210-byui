using System;

class Program
{
    static void Main(string[] args)
    {
        DateOnly date = new DateOnly(2024, 2, 1);
        Running run = new Running(61, date, 5);
        Swimming swim = new Swimming(37, date, 21);
        Cycling cycle = new Cycling(124, date, 18);

        run.showSummary();
        swim.showSummary();
        cycle.showSummary();

    }
}