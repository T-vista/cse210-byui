using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // public bool InUSA()
    // {
    //     bool usa;
    //     if (_country == "USA")
    //     {
    //         usa = true;
    //     }
    //     else
    //     {
    //         usa = false;
    //     }
    //     return usa;
    // }

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}\n{_city}, {_state} {_country}");
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
}