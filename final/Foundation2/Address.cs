public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

     public Address()
    {
    }
    public Address(string street, string city, string state, string country)
    {
        _street= street;
        _city = city;
        _state = state;
        _country = country;
    }  
    public bool IsFromUsa()
    {
        bool isFromUsa=false;
        if (_country == "USA" || _country == "Usa" || _country == "usa")
        {
            isFromUsa = true;
        }
        return isFromUsa;
    }
    public string GetFullAddress()
    { 
        return $"{_street}, {_city}\n{_state}\n{_country}";
    }
}