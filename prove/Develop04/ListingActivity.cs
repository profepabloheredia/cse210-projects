using System.Security.Cryptography.X509Certificates;

public class ListingActivity:Activity
{
    
    private List<String> _prompts= new List<string>();

    public ListingActivity(string name, string description): base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    } 
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        int seconds= Convert.ToInt32(Console.ReadLine());
        SetDuration(seconds);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console .Write("\nYou may begin in : ");
        ShowCountDown(5);
        Console.WriteLine("");
        
        List<string> userList = new List<string>();
        
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
              
        while (currentTime < endTime)
        {
            Console.Write(">> ");
            string input= Console.ReadLine();
            userList.Add(input);
            currentTime= DateTime.Now;
        }
        
        Console.WriteLine("You listed " + userList.Count() + " items.");
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public void GetRandomPrompt()
    {
        Random randomPrompt =new Random();
        string prompt = _prompts[randomPrompt.Next(_prompts.Count)];
        Console.WriteLine("--- " + prompt + " ---\n");
    }
    public List<string> GetListFromUser()
    {
        
        return _prompts;
    }


}