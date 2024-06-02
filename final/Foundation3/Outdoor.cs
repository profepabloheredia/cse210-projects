public class Outdoor:Event
{
    private string _weather;

    public Outdoor()
    {

    }
    public Outdoor(string title, string description,string date, string time, Address address,  string weather):base(title,description, date, time, address)
    {
        _weather=weather;
    }
    public void GetStandard()
    {
        Console.WriteLine("--- OUTDOOR EVENT ---");
            Console.WriteLine(GetStandardDetail());
        Console.WriteLine(" \n");
    }
    public void GetFull()
    {
        Console.WriteLine("--- NEW OUTDOOR EVENT ---");
            Console.WriteLine(GetStandardDetail());
            Console.WriteLine($"Weather: {_weather} ");
        Console.WriteLine(" \n");
    }
    public void GetShort()
    {
        Console.WriteLine("--- NEW OUTDOOR ---");
            Console.WriteLine(GetShortDescription());
        Console.WriteLine(" \n");
    }
}