using System;
using System.Numerics;

/*
I added a compare function as "option 6"
it let us to compare 2 files showing it's scores and leaving a motivating message. 
*/

class Program
{
    static void Main(string[] args)
    {
        string fileName1="Goals.txt";
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
                Console.Write($"\n Type your goals file(default:{fileName1}): ");
                string filename = Console.ReadLine();
                if (filename == ""){filename = fileName1;}
                goalManager.SaveGoals(filename);
                Console.Clear();
            }
            if (option =="4")
            {
                Console.Write($"\n Type your goals file(default:{fileName1}): ");
                string filename = Console.ReadLine();
                if (filename == ""){filename = fileName1;}
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
                Console.Clear();  

                Console.Write($"\n Type your First file of goals (default:{fileName1}): ");
                string filename = Console.ReadLine();
                if (filename != ""){fileName1 = filename ;}
                                
                Console.Write($"\n Type your Secong file of goals: ");
                String fileName2 = Console.ReadLine();
                
                goalManager.LoadGoals(fileName1);                        
                Console.WriteLine($"\n************** FIRST FILE: '{fileName1}'****************");
                Console.WriteLine("The Goals are:");
                goalManager.ListGoalDetails();
                int score1 = goalManager.GetScore();
                Console.WriteLine($"\t You Got {score1} Points");
                GoalManager goalManager2=new GoalManager();
                goalManager2.LoadGoals(fileName2);
                Console.WriteLine($"\n************** SECOND FILE: '{fileName2}'****************");
                Console.WriteLine("The Goals are:");
                goalManager2.ListGoalDetails();
                int score2 = goalManager2.GetScore();
                Console.WriteLine($"\t You Got {score2} Points");
                Console.WriteLine($"\n********************************************************\n");

                Console.WriteLine($"Comparing first File({fileName1}) to the last one({fileName2})");
                if (score2 > score1)
                {
                    Console.WriteLine($"YOU DARE DOING A GREAT JOB AND INCREASES {score2 - score1} POINTS!!!");
                }
                if (score2 == score1)
                {
                    Console.WriteLine($"You can improve yourself!!!");
                }
                if (score2 < score1 * 1.1) //if diference between  first score and the second is greater than 10%
                {
                    Console.WriteLine($"YOU MUST TO CHECK YOUR GOALS\n");
                }

            }
            if (option =="7")
            {
                Console.WriteLine("Thanks!!!");
                break;
            }
        }    
    }
}