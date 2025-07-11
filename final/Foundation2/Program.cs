using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("720 Cornelison Ave", "Rexburg", "ID", "USA");
        Customer me = new Customer("Tyler Vistaunet", myAddress);
        Address miDirection = new Address("720 Cornelison Ave", "Cidudad Mexico", "Ja", "Mexico");
        Customer yo = new Customer("Tyler Vistaunet", miDirection);
        // me.displayShippingLabel();
        Product skis = new Product("Bent Chetler 100", 1, 400, 1);
        Product skiBoots = new Product("Atomic Hawx Prime 120", 2, 800, 1);
        Product goggles = new Product("Ski Googles", 3, 70, 5);
        Product poles = new Product("Ski Poles", 4, 50, 2);

        Order number1 = new Order(me);
        number1.AppendtoList(skis);
        number1.AppendtoList(goggles);
        number1.AppendtoList(skiBoots);

        Order number2 = new Order(yo);
        number2.AppendtoList(poles);
        number2.AppendtoList(goggles);
        number2.AppendtoList(skis);
        number2.AppendtoList(skis);

        Console.WriteLine($"\nPacking Label:\n");
        number1.returnPackingLabel();
        Console.WriteLine($"\nShipping Label:\n");
        number1.returnShipingLabel();
        Console.WriteLine($"\nTotal Cost: ${number1.totalcost()}\n");

        Console.WriteLine($"\nPacking Label:\n");
        number2.returnPackingLabel();
        Console.WriteLine($"\nShipping Label:\n");
        number2.returnShipingLabel();
        Console.WriteLine($"\nTotal Cost: ${number2.totalcost()}\n");
        


    }
}