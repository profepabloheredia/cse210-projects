public class BreathingActivity
{

    public BreathingActivity()
    {
        
    } 
    public void Run()
    {
        string name= "Breathing Activity.";
        string description="\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Activity activity=new Activity(name, description);
        
        activity.DisplayStartingMessage();
        int seconds= Convert.ToInt32(Console.ReadLine());
        activity.SetDuration(seconds);       
        Console.Clear();
        Console.WriteLine("\nGet ready..");
        activity.ShowSpinner(5);

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
       
        while (currentTime < endTime)
        {
            Console.Write("\nBreath in..");
            activity.ShowCountDown(3);
            Console.Write("\nBreath Out..");
            activity.ShowCountDown(4);
            Console.WriteLine("");
            currentTime= DateTime.Now;
        }

        activity.ShowSpinner(5);
        activity.DisplayEndingMessage();
        activity.ShowSpinner(5);

    }
}