using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        int sum =0;
        float average;
        int largest;
        int smallest;
        List<int> numbers = new List<int>();

        do{
            Console.WriteLine("Enter number:"); 
            string num_input=Console.ReadLine();
            number =int.Parse(num_input);
            if (number != 0)
            {
                numbers.Add(number);
            }    
        }while (number!=0);

        largest = numbers[0];
        smallest = numbers[0];
        
        foreach (int num in numbers)
        {
            sum += num;
            if (num>largest)
            {
                largest= num;
            }
            if (num<smallest)
            {
                smallest= num;
            }
        }

        average= ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest number is: {smallest}");

        numbers.Sort();
        Console.WriteLine("Sorted list:");
        foreach (int item in numbers)
        {
            Console.WriteLine(item);
        }
      

    }      
        
}