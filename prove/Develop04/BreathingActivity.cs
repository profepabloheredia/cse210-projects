public class BreathingActivity: Activity
{

    public BreathingActivity(string name, string description): base(name, description)
    {
        
    } 
    public void Run()
    {   
        DisplayStartingMessage();
        int seconds= Convert.ToInt32(Console.ReadLine());
        SetDuration(seconds);       
        Console.Clear();
        Console.WriteLine("\nGet ready..");
        ShowSpinner(5);
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
       
        while (currentTime < endTime)
        {
            Console.Write("\nBreath in..");
            ShowCountDown(3);
            Console.Write("\nBreath Out..");
            ShowCountDown(4);
            Console.WriteLine("");
            currentTime= DateTime.Now;
        }
        ShowSpinner(5);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}