using System;

public class Product
{
    private string _name;
    private int _id;
    private int _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, int pricePerUnit, int quantity)
    {
        _name = name;
        _id = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public int ComputePrice()
    {
        return _quantity * _pricePerUnit;
    }

    public void PackingLabel()
    {
        Console.WriteLine($"    {_id}               {_name}");
    }

}