using System;
/*  FOR Exceeding Requirements
    * I added the function of Saving to a file  each time we select an activity to do.
    The saved values are: Date, Name of Activity and Seconds spent.
    For that I created a "SaveToAFile(String file)" method inside Activity Class because it is used by each activity.
    I added a method inside Program class as an option to show all entries of "ActivityLog.txt" File, because it will be used once.

*/
class Program
{
    static void Main(string[] args)
    {

        string fileName ="ActivityLog.txt";
        string option= "";

        while (option != "5")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Show activity records");
            Console.WriteLine("   5. Quit");
            Console.WriteLine("What is your choice?\b");
            option= Console.ReadLine();

            if (option =="1")
            {
                Console.Clear();
                string name= "Breathing Activity.";
                string description="\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathing = new BreathingActivity(name, description);
                breathing.Run();
                breathing.SaveToAFile(fileName);
            }
            if (option =="2")
            {
                Console.Clear();
                string name= "Reflecting Activity.";
                string description="\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectingActivity reflecting = new ReflectingActivity(name, description);
                reflecting.Run();
                reflecting.SaveToAFile(fileName);
            }
            if (option =="3")
            {
                Console.Clear();
                string name= "Listing Activity.";
                string description="\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
              
                ListingActivity listing = new ListingActivity(name, description);
                listing.Run();
                listing.SaveToAFile(fileName);
                
            }
            if (option =="4")
            {
                Console.WriteLine("\n --- Activities you Done --- ");

                int seconds = 0;
                string[] lines = System.IO.File.ReadAllLines(fileName);
        
                foreach (string line in lines)
                {
                string[] parts = line.Split(",");
                string date = parts[0];
                string name = parts[1];
                int time = Convert.ToInt32(parts[2]);
                seconds += time;

                Console.WriteLine($"{date} - {name}- \tTime spent: {time} seconds.");
                }
                Console.WriteLine($" --- Total Time: {seconds} seconds. ---");
                Console.WriteLine("\npress enter to continue.");
                Console.ReadLine();
            }    
            if (option =="5")
            {
                Console.WriteLine("Thanks!!!");
                break;
            }
        }
    }
}