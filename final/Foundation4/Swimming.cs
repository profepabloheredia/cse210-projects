
using System.Diagnostics;

public class Swimming: Activity
{
    private int _laps;
   
    public Swimming(string date, double length,int laps):base(date, length)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000; // it return distance in km/h
        return distance;
    }
    public override double GetSpeed()
    {
        double speed = GetDistance() / (base.GetLength() / 60);
        return speed; // return the speed in km/h
    }
    public override double GetPace()
    {
        return base.GetLength() / GetDistance(); // retur the pace in min/ km
    }
    // public override string GetSummary()
    // {
    //     string date= base.GetDate();
    //     string length = Convert.ToString(base.GetLength());
    //     string distance = Convert.ToString(GetDistance());
    //     string speed = Convert.ToString(GetSpeed());
    //     string pace = Convert.ToString(GetPace());

    //     string summary = $" - {date} SWIMMING ({length} min): Distance {GetDistance()} Km, Speed: {speed} kph, Pace: {pace} min per km ";
    //     return summary;
    

    // }
}