public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zipCode;


    public Address(string street, string city, string state, int zipCode)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }


    public string GetWholeAddress()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}