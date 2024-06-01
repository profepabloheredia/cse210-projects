
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address address;

    public abstract string GetShortDescription();
    public abstract string GetDetailString();

}