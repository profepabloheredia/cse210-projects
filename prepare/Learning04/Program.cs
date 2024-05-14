using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("HOME WORKS");
        
        // Create a base "Assignment" object
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine (assignment.GetSummary());

        MathAssignment math = new MathAssignment("Peter Ali", "Derivate", "8.7", "15-17");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment writing = new WritingAssignment("John Brown", "European History", "Musolini the Dictator");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    
    }
}