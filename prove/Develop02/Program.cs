using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        string filename = "myJournalFile.txt";

        string option= "";

        while (option != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("--Journal Options--");
            Console.WriteLine("   1-Write new entry");
            Console.WriteLine("   2-Display all");
            Console.WriteLine("   3-Save to file");
            Console.WriteLine("   4-load from file");
            Console.WriteLine("   5-Quit");
            Console.WriteLine("What is your choice?\b");
            option= Console.ReadLine();

            if (option =="1")
            {
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                PromptGenerator pGenerator = new PromptGenerator();
                string prompt = pGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);

                Console.WriteLine("Your answer:");
                string answer = Console.ReadLine();

                Entry anEntry =new Entry();
                anEntry._date =dateText;
                anEntry._prompText= prompt;
                anEntry._entryText = answer;

                myJournal.AddEntry(anEntry);
            }
        
            if (option =="2")
            {
                myJournal.DisplayAll();
            }
            if (option =="3")
            {
                
                myJournal.SaveToFile(filename);
            }
            if (option =="4")
            {
                myJournal.LoadFromFile(filename);
            }
            if (option =="5")
            {
                Console.WriteLine("Thanks!!!");
            }
        }
    }
}