
using System.Diagnostics;

public class Cycling: Activity
{
    private double _speed;

  
    public Cycling(string date, double length,double speed):base(date, length)
    {
        _speed = speed;
    }
     public override double GetDistance()
    {
        double distance = _speed * (base.GetLength()/60);
        return distance;

    }
    public override double GetSpeed()
    {
        return _speed;

    }
    public override double GetPace()
    {
        double pace = 60/ _speed;
        return pace;
    }
    // public override string GetSummary()
    // {
    //     string date= base.GetDate();
    //     string length = Convert.ToString(base.GetLength());
    //     string distance = Convert.ToString(GetDistance());
    //     string speed = Convert.ToString(_speed);
    //     string pace = Convert.ToString(GetPace());

    //     string summary = $" - {date} CYCLING ({length} min): Distance {GetDistance()} Km, Speed: {speed} kph, Pace: {pace} min per km ";
    //     return summary;

    //     //o	03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
    // }

}