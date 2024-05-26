using System;

class Program
{
    static void Main(string[] args)
    {
                
        GoalManager goalManager=new GoalManager();
        string option= "";
        while (option != "6")
        {
            //Console.Clear();
            goalManager.Start();
            option= Console.ReadLine();

            if (option =="1")
            {
                string typeOption;
               
                Console.WriteLine("\nThe type of Goals are:");
                Console.WriteLine("   1. Simple Goal");
                Console.WriteLine("   2. Eternal Goal");
                Console.WriteLine("   3. Checklist Goal");
                Console.Write("Which type of Goal would  you like to create?");
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
            }
            if (option =="4")
            {
                Console.Write("\n Type your goals file: ");
                string filename = Console.ReadLine();
                
                goalManager.LoadGoals(filename);

          
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