using System;

//This program use KM/Hours unit
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ******** Foundation4 *********\n");
       
        String date ="04 Oct 2023";
        double length =85;
        double speed = 70;
        Cycling cycling = new Cycling(date, length, speed);
        cycling.GetSummary("CYCLING");

        date ="10 Nov 2023";
        length =25;
        int laps = 30;
        Swimming swimming = new Swimming(date, length, laps);
        swimming.GetSummary("SWIMMING");

        date ="07 Dec 2023";
        length =30;
        double distance = 10;
        Running running = new Running(date, length, distance);
        running.GetSummary("RUNNING");

        Console.WriteLine("\n***End***\n");

        







    }
}