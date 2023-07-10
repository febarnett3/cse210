public class Product
{
    // Attributes
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    // Behaviors
    public double GetPrice()
    {
        return _price*_quantity;
    }
}
