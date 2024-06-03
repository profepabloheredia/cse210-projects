
using System.Diagnostics;

public class Running: Activity
{
    private double _distance;

  
    public Running (string date, double length, double distance):base(date, length)
    {
        _distance = distance;
    }
     public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        double speed = _distance / (base.GetLength() / 60);
        
        return speed; // it returns speed in km/h
    }
    public override double GetPace()
    {
        double pace = 60/ GetSpeed();
        return pace;
    }
    // public override string GetSummary()
    // {
    //     string date= base.GetDate();
    //     string length = Convert.ToString(base.GetLength());
    //     string distance = Convert.ToString(_distance);
    //     string speed = Convert.ToString(GetSpeed());
    //     string pace = Convert.ToString(GetPace());

    //     string summary = $" - {date} RUNNING ({length} min): Distance {GetDistance()} Km, Speed: {speed} kph, Pace: {pace} min per km ";
    //     return summary;
    // }
}