using System;
using System.Collections.Generic;

public class Order
{
    // Attributes
    private List<Product>_products;
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Behaviors
     public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    private int GetShippingCost()
    {
        if (_customer.InUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            double price = product.GetPrice();
            Console.WriteLine($"{product.GetQuantity()} {product.GetProductID()} {product.GetName()} ${price.ToString("0.00")}");
        }
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}: \n{_customer.GetAddress()}");
    }
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach(Product product in _products)
        {
            totalPrice+=product.GetPrice();
        }
        totalPrice += GetShippingCost();
        return totalPrice;
    }
    public void DisplayShippingCost()
    {
        Console.WriteLine($"Shipping: ${GetShippingCost().ToString("0.00")}");
    }
}