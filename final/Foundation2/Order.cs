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

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            double price = product.GetPrice();
            Console.WriteLine($"{product.GetQuantity()} {product.GetProductID()} {product.GetName()} ${price.ToString("0.00")}");
        }
    }
    public void GetShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}: \n{_customer.GetAddress()}");
    }
    public void DisplayShippingCost()
    {
        Console.WriteLine($"Shipping: ${GetShippingCost().ToString("0.00")}");
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}