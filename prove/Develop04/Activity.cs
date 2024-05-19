public class Activity
{

    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description=description;       
    } 
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the " + _name);
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
                
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"\nYou have completet another {_duration} seconds of the {_name}!!");
    }
    
    public void SetDuration(int seconds)
    {
        _duration= seconds;
    }
    public void ShowSpinner(int seconds)
    {
                          
        List<string> character =new List<string>();
        character.Add("|");
        character.Add("/");
        character.Add("-");
        character.Add("\\");
      
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
       
        foreach (string c in character)
        {
            Console.Write(c);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            if (currentTime >= endTime)
            {
                break;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i= seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}