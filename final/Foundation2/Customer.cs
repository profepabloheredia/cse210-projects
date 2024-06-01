using System.Dynamic;

public class Customer
{
    private string _name;
    private Address _address; 
    
    public Customer()
    {
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address=address;
    }
    public bool GetShippingToUsa()
    {
        return _address.IsFromUsa();    
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetFullAddress();
    }
}
