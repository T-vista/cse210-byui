using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breath = new BreathingActivity("Breathing Activity","This Activity will help you relax by focusing on your breathing, follow along with the pompts...", 0);
        ListingActivity list = new ListingActivity("Listing Activity", "In this activity you will create a list of all the things you can think of that satisfy the prompt", 10);
        ReflectingActivity reflect = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on your acomplishments and focus on your successes", 30);

        string selection = "0";
        while (selection!= "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options\n1. Start Breathing Activity\n2. Start Listing Activity\n3. Start Reflecting Activity\n4. View This Sessions Statistics\n5. Quit\nSelect a choice from the menu: ");
            selection = Console.ReadLine();
            if (selection == "1")
            {
                Console.Clear();
                breath.Run();
                breath.ShowSpinner(3);
            }
            else if (selection == "2")
            {
                Console.Clear();
                list.Run();
                list.ShowSpinner(3);
            }
            else if (selection == "3")
            {
                Console.Clear();
                reflect.Run();
                reflect.ShowSpinner(3);
            }
            else if (selection == "4")
            {
                Console.Clear();
                Console.WriteLine($"Your session stats:\n\nBreathing Activity: {breath.GetTotalDuration()} Seconds Completed\nListing Activity: {list.GetTotalDuration()} Seconds Completed\nReflecting Activity: {reflect.GetTotalDuration()} Seconds Completed\n\nPress enter when done");
                Console.ReadLine();
                reflect.ShowSpinner(1);
                
            }
            else
            {
            }
        }
    }
}