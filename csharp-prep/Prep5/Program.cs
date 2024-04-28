using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    } 
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name::");
        string  user_name= Console.ReadLine();
        return user_name;
    } 
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        
        string num_input=Console.ReadLine();
        int number =int.Parse(num_input);
        return number;
    } 
    static int SquareNumber (int number)
    {
        int square = number * number;
        return square;
    } 
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    } 
       
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name =  PromptUserName();
        int user_number =   PromptUserNumber();
        int squared = SquareNumber(user_number);

        DisplayResult(user_name, squared);
      
    }
}