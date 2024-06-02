public class Lectures:Event
{
    private string _speaker;
    private int _capacity;

    public Lectures()
    {

    }
    public Lectures(string title, string description,string date, string time, Address address, int capacity, string speaker):base(title,description, date, time, address)
    {
        _speaker=speaker;
        _capacity=capacity;
    }
    public void GetStandard()
    {
        Console.WriteLine("--- LECTURE EVENT ---");
            Console.WriteLine(GetStandardDetail());
        Console.WriteLine(" \n");
    }
    public void GetFull()
    {
        Console.WriteLine("--- NEW LECTURE EVENT ---");
            Console.WriteLine(GetStandardDetail());
            Console.WriteLine($"Speaker: {_speaker} - Capacity: {_capacity} Persons.");
        Console.WriteLine(" \n");
    }
    public void GetShort()
    {
        Console.WriteLine("--- NEW EVENT ---");
            Console.WriteLine(GetShortDescription());
        Console.WriteLine(" \n");
    }


}