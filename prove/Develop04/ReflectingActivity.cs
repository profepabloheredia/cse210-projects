using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity: Activity
{

    private List<String> _prompts= new List<string>();
    private List<String> _questions= new List<string>();

    public ReflectingActivity(string name, string description): base(name, description)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add(" Why was this experience meaningful to you?");
        _questions.Add(" Have you ever done anything like this before?");
        _questions.Add(" How did you get started?");
        _questions.Add(" How did you feel when it was complete?");
        _questions.Add(" What made this time different than other times when you were not as successful?");
        _questions.Add(" What is your favorite thing about this experience?");
        _questions.Add(" What could you learn from this experience that applies to other situations?");
        _questions.Add(" What did you learn about yourself through this experience?");
        _questions.Add(" How can you keep this experience in mind in the future?");
                      
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
        DisplayPrompt();
        Console.ReadLine();
        Console .WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console .Write("\nYou may begin in : ");
        ShowCountDown(5);
        Console.Clear();

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        
        while (currentTime < endTime)
        {
            DisplayQuestions();
            ShowSpinner(5);
            currentTime= DateTime.Now;

        }
        DisplayEndingMessage();
        ShowSpinner(5);
    
    }
    public string GetRandomPrompt()
    {
        Random randomPrompt =new Random();
        
        return _prompts[randomPrompt.Next(_prompts.Count)];
    }
    public string GetRandomquestion()
    {
        Random randomQ =new Random();
        return _questions[randomQ.Next(_questions.Count)];
    }
     public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following Prompt: \n");
        Console.WriteLine("--- " + GetRandomPrompt() + " ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }
    public void DisplayQuestions()
    {
        Console.WriteLine("> " + GetRandomquestion() );
    }

}