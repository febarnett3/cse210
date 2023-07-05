public class Address
{
    // Attributes
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Behaviors
    public string GetCountry()
    {
        return _country;
    }
    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }
}
