public class Address
{
    private string _street;
    private string _city;
    private string _stateOrEquivilent;
    private string _country;


    public Address(string street, string city, string stateOrEquivilent, string country)
    {
        _street = street;
        _city = city;
        _stateOrEquivilent = stateOrEquivilent;
        _country = country;
    }


    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }

        else
        {
            return false;
        }
    }


    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_stateOrEquivilent} {_country}";
    }
}