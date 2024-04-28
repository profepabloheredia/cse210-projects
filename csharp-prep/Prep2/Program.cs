using System;

class Program
{
    static void Main(string[] args)
    {
        
        int grade;
        string letter;
        string sign_letter;

        Console.WriteLine("");

        Console.WriteLine("Hello!, Please enter your grade percentage: ");
        string grade_input=Console.ReadLine();
        grade =int.Parse(grade_input);

        if (grade >= 90)
        {
            letter="A";
        }
        else if (grade >= 80)
        {
            letter="B";
        }
        else if (grade >= 70)
        {
            letter="C";
        }
        else if (grade >= 60)
        {
            letter="D";
        }
        else 
        {
            letter="F";
        }
        int grade_sign = grade % 10;
        
        if (grade_sign>=7)
        {
            sign_letter="+";
        }
        else if(grade_sign<=3)
        {
            sign_letter="-";
        }
        else
        {
            sign_letter="";
        }
        

        Console.WriteLine($"your calification is: {letter}{sign_letter}");

        if (grade>=70)
        {
            Console.WriteLine("CONGRATULATION! You pass the course!");
        }
        else
        {
            Console.WriteLine("SORRY! You NOT pass the course!");
        }
        Console.WriteLine("");
    }
}
    

    
