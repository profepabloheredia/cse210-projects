using System.Collections.Generic;
public class PromptGenerator
{
    List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        _prompts.Add ("Who was the most interesting person I interacted with today?");
        _prompts.Add ("What was the best part of my day?");
        _prompts.Add ("How did I see the hand of the Lord in my life today?");
        _prompts.Add ("What was the strongest emotion I felt today?");
        _prompts.Add ("If I had one thing I could do over today, what would it be?");
        _prompts.Add ("What I forgot to do?");
        _prompts.Add ("If I had one thing to do again, what would it be?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);  
        //Console.WriteLine(_prompts.Count);  
        string prompt = _prompts[number];
       
        return prompt;
    }
}