using System;

class Program
{
    static void Main(string[] args)
    {
        
        Journal myJournal = new Journal();
        Entry anEntry =new Entry();
        string option= "";

        while (option != "4")
        {
            Console.WriteLine("");
            Console.WriteLine("Please Select an option.");
            Console.WriteLine("1-Write");
            Console.WriteLine("2-Display");
            Console.WriteLine("3-Save");
            Console.WriteLine("4-Quit");
            option= Console.ReadLine();

            if (option =="1")
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                PromptGenerator pGenerator = new PromptGenerator();
                string prompt = pGenerator.GetRandomPrompt();
                
                anEntry._date =dateText;
                anEntry._prompText= prompt;
                Console.WriteLine(prompt);
                Console.WriteLine("Your answer:");
                anEntry._entryText = Console.ReadLine();
                myJournal.AddEntry(anEntry);
            }
        
            if (option =="2")
            {
                myJournal.DisplayAll();
            }
            if (option =="3")
            {

            }
            if (option =="4")
            {
            }
        }
                Console.WriteLine("");
        //
        





        
        

        
        




        
    }
}