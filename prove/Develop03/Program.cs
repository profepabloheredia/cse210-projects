/* For exceeding requirements, I Added a file with most common scriptures to memorize. 
This programm Read from this file and shows randomly
a line with a scripture(Book, chapter, initial vers, end verse , text). 
The file is a text file with separated values by "~" 
I also considered not necessary to Add a new class for this behavior, because it only need to read from file.

*/


using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string file = "AllScriptures.txt";
        
        int lineCount = System.IO.File.ReadLines(file).Count(); //count all lines inside file
        
        Random rnd = new Random();
        int randomLine  = rnd.Next(0, lineCount);
        
        string[] lines = System.IO.File.ReadAllLines(file);
        
        string[] parts = lines[randomLine].Split("~"); //The file lines has the format: "jonh~3~16~16~For God so loved the world that...."

        string book = parts[0];
        int chapter = Convert.ToInt32(parts[1]);
        int verse = Convert.ToInt32(parts[2]);
        int endVerse = Convert.ToInt32(parts[3]);
        string text = parts[4];



        Reference reference =new Reference(book, chapter, verse, endVerse);
        Scripture scripture=new Scripture(reference, text);
        
        Console.Clear();
        bool  quit = false;
        while (quit==false)
        {   
            Console.Clear();
            Console.WriteLine(" *** Scripture Memorizer *** \n");
            Console.WriteLine(scripture.GetDisplayText());
                         
            Console.WriteLine("\nPress ENTER to continue,  or type 'quit' to finish ");  
            if (Console.ReadLine() == "quit")
            {
                quit=true;
                
            }else
            {   
               if (scripture.IsCompletelyHidden()==false)
               {
                    Random random = new Random();
                    int randomQuantity  = random.Next(1, 4);
                    scripture.HideRandomWords(randomQuantity);
               } else
               {
                    quit=true;
               }                
            }
        }
    }
}