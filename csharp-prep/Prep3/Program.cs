using System;

class Program
{
    static void Main(string[] args)
    {
                     
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);          
        int chosen;
        Console.WriteLine("");
        do
        {
           Console.WriteLine("What is your guess? ");
            string number_input=Console.ReadLine();
            chosen =int.Parse(number_input);

            if (chosen < number)
            {
                Console.WriteLine("Higher");
            }
            else if (chosen > number)
            {
                
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            } 
            Console.WriteLine("");
        } while(number != chosen);
        
    }    
    
}