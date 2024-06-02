
using System.ComponentModel;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event()
    {

    }
    public Event(string title, string description,string date, string time, Address address)
    {
        _title= title;
        _description=description;
        _date=date;
        _time=time;
        _address=address;
    }

    public string GetShortDescription()
    {
        return $"Title: {_title} ({_description})\nDate:{_date}";
    }
    public string GetStandardDetail()
    {
        return $"Title: {_title} ({_description})\nDate:{_date} - {_time}\nLocate: {_address.GetAddress()}";
    }

}