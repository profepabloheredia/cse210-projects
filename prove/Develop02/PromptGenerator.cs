using System.Collections.Generic;
public class PromptGenerator
{
    // Create a list -- https://www.c-sharpcorner.com/UploadFile/mahesh/add-items-to-a-C-Sharp-list/
    List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {
        _prompts.Add ("Who was the most interesting person I interacted with today?");
        _prompts.Add ("What was the best part of my day?");
        _prompts.Add ("How did I see the hand of the Lord in my life today?");
        _prompts.Add ("What was the strongest emotion I felt today?");
        _prompts.Add ("If I had one thing I could do over today, what would it be?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);    

        string prompt = _prompts[number];

        
        return prompt;

    }
}