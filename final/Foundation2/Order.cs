using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public int totalcost()
    {
        int total = 0;
        foreach (Product p in _products)
        {
            int pPrice = p.ComputePrice();
            total += pPrice;
        }
        if (_customer.inUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public void returnShipingLabel()
    {
        _customer.displayShippingLabel();
    }
    public void returnPackingLabel()
    {
        Console.WriteLine("ID:   Product name:");
        foreach (Product p in _products)
        {
            p.PackingLabel();
        }
    }

    public Order(Customer customer)
    {
        _customer = customer;

    }
    public void AppendtoList(Product prod)
    {
        _products.Add(prod);
    }
}