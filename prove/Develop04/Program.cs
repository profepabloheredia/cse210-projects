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
                string name= "Breathing Activity.";
                string description="\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathing = new BreathingActivity(name, description);
                breathing.Run();
                
            }
        
            if (option =="2")
            {
                Console.Clear();
                string name= "Reflecting Activity.";
                string description="\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflecting = new ReflectingActivity(name, description);
                reflecting.Run();
            }
            if (option =="3")
            {
                Console.Clear();
                string name= "Listing Activity.";
                string description="\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
              
                ListingActivity listing = new ListingActivity(name, description);
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