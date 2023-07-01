public class Customer 
{
    // Attributes
    private string _name;
    private Address _address;
    
    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddressString();
    }
    // Behaviors
    public bool InUSA()
    {
        if (_address.GetCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}