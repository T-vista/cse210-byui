using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public void displayShippingLabel()
    {
        Console.WriteLine($"{_name}");
        _address.DisplayAddress();
    }

    public bool inUSA()
    {
        return _address.InUSA();
    }

}