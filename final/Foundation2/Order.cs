public class Order 
{ 
    private Customer _customer =new Customer();
    private List<Product> _products =new List<Product>();
    
    public Order(Customer customer)
    {
        _customer= customer;
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public  double GetTotal()
    {
        double total=0;
        foreach (Product product in _products)
        {
            total += product.GetCost();// call method on products class for each one
        }
        total += GetShippingCost();
        return total;
    }
    public  void GetShippingLabel(int number)
    {
        Console.WriteLine($"-------   ORDER N° {number}   -------");
        Console.WriteLine($"Send To: {_customer.GetName()}");
        Console.WriteLine(_customer.GetAddress());
        Console.WriteLine("  -");
    }
    public void  GetPackingLabel()
    {
        Console.WriteLine("Order Details:");
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetProduct());
        }
        Console.Write($"----- Quantity: {_products.Count()} Products --");
        Console.WriteLine($"Total cost: ${GetTotal()} -----\n");
    }
    public double GetShippingCost()
    {
        double shipping = 35;//by default if it is to outside of the country
        if(_customer.GetShippingToUsa())
        {
            shipping = 5; // if it is inside of USA
        }
        return  shipping;
    }
    
   



}