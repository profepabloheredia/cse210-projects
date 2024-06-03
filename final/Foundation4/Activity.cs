public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    public string GetDate()
    {
        return _date;
    }
    public double GetLength()
    {
        return _length;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public virtual void GetSummary(String activity)
    {
        string date= _date;
        string length = Convert.ToString(_length);
        string distance = Convert.ToString(GetDistance());
        string speed = Convert.ToString(GetSpeed());
        string pace = Convert.ToString(GetPace());
        string summary = $" - {date} {activity} ({length} min): Distance {GetDistance()} Km, Speed: {speed} kph, Pace: {pace} min per km ";
        Console.WriteLine(summary);
    }
    //public abstract string GetSummary();
}
