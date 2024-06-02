public class Receptions:Event
{
    private string _email;

    public Receptions(string title, string description,string date, string time, Address address,  string email):base(title,description, date, time, address)
    {
        _email=email;
    }
    public void GetStandard()
    {
        Console.WriteLine("--- RECEPTION EVENT ---");
            Console.WriteLine(GetStandardDetail());
        Console.WriteLine(" \n");
    }
    public void GetFull()
    {
        Console.WriteLine("--- NEW RECEPTION EVENT ---");
            Console.WriteLine(GetStandardDetail());
            Console.WriteLine($"Confirmation E-mail: {_email} ");
        Console.WriteLine(" \n");
    }
    public void GetShort()
    {
        Console.WriteLine("--- NEW RECEPTION ---");
            Console.WriteLine(GetShortDescription());
        Console.WriteLine(" \n");
    }
}