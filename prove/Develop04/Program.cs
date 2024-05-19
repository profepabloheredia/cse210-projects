using System;

class Program
{
    static void Main(string[] args)
    {


        string option= "";

        while (option != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.WriteLine("What is your choice?\b");
            option= Console.ReadLine();

            if (option =="1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                
            }
        
            if (option =="2")
            {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            if (option =="3")
            {
                Console.Clear();
                ListingActivity listing = new ListingActivity();
                listing.Run();
                
            }
            if (option =="4")
            {
                Console.WriteLine("Thanks!!!");

                break;

            }
    
        }
    }
}