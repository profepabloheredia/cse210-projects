using System.Net.Http.Headers;

public class Entry
{
    public String _date;
    public String _prompText;
    public String _entryText;

    public void Display()
    {
        Console.WriteLine($"Date {_date}, {_prompText}, {_entryText}");
    }

}