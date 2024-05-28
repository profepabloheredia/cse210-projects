using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalManager goalManager=new GoalManager();
        string option= "";
        while (option != "6")
        {
            
            goalManager.Start();
            option= Console.ReadLine();

            if (option =="1")
            {
                string typeOption;
               
                goalManager.DisplayPlayerInfo();
                typeOption= Console.ReadLine();

                if (typeOption =="1") //simple goal statments
                {
                    goalManager.CreateGoal("simple");         
                }
                 if (typeOption =="2")
                {
                    goalManager.CreateGoal("eternal"); 
                }
                 if (typeOption =="3")
                {
                    goalManager.CreateGoal("checklist");
                }
            }
            if (option =="2")
            {
                Console.WriteLine("\nThe Goals are:");
                goalManager.ListGoalDetails();
            }
            if (option =="3")
            {
                Console.Write("\n Type your goals file: ");
                string filename = Console.ReadLine();
                goalManager.SaveGoals(filename);
                Console.Clear();
            }
            if (option =="4")
            {
                Console.Write("\n Type your goals file: ");
                string filename = Console.ReadLine();
                
                goalManager.LoadGoals(filename);
                Console.Clear();          
            }    
            if (option =="5")
            {
                goalManager.ListGoalNames();
                goalManager.RecordEvent();
            }
            if (option =="6")
            {
                Console.WriteLine("Thanks!!!");
                break;
            }
        }    
    }
}