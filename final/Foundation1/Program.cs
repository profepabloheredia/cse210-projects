using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Video Video1= new Video();
        Video1._author= "Peter Hollens";
        Video1._title= "Pirate of caribean";
        Video1._length= 185;

        Comment comment1 = new Comment();
        comment1._personName ="John m.";
        comment1._commentText ="I loved this video!!";
        Video1._comments.Add(comment1);
        
        Comment comment2 = new Comment();
        comment2._personName ="Mariah Carey.";
        comment2._commentText ="You have future!!";
        Video1._comments.Add(comment2);

        Comment comment3 = new Comment();
        comment3._personName ="Taylor brown";
        comment3._commentText ="Nice video!!";
        Video1._comments.Add(comment3);
        
        Video1.DisplayVideo();
       
        Video Video2= new Video();
        Video2._author= "Brian Adams";
        Video2._title= "Pirate of caribean";
        Video2._length= 150;

        Comment comment4 = new Comment();
        comment4._personName ="John m.";
        comment4._commentText ="I loved this video!!";
        Video2._comments.Add(comment4);
        
        Comment comment5 = new Comment();
        comment5._personName ="Jim Carey.";
        comment5._commentText ="keep doing that!!";
        Video2._comments.Add(comment5);

        Comment comment6 = new Comment();
        comment6._personName ="James brown";
        comment6._commentText ="Nice!!";
        Video2._comments.Add(comment6);
        
        Video2.DisplayVideo();

        Video Video3= new Video();
        Video3._author= "Debi Nova";
        Video3._title= "My soul";
        Video3._length= 210;

        Comment comment7 = new Comment();
        comment7._personName ="John m.";
        comment7._commentText ="I loved this video!!";
        Video3._comments.Add(comment7);
        
        Comment comment8 = new Comment();
        comment8._personName ="Bolotín M.";
        comment8._commentText ="Good Music!!";
        Video3._comments.Add(comment8);

        Comment comment9 = new Comment();
        comment9._personName ="jonny";
        comment9._commentText ="I like it..";
        Video3._comments.Add(comment9);
        
        Video3.DisplayVideo();
       



    }
}