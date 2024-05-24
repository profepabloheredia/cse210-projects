using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n *** Learning 5 Test ***\n");

        Square sq =new Square("White", 4);
       // ShowResults(sq);
        // Console.WriteLine(sq.GetColor());
        // Console.WriteLine(sq.GetArea());
        // Console.WriteLine("");

        Rectangle rec =new Rectangle("Black", 6, 4);
       // ShowResults(rec);
        // Console.WriteLine(rec.GetColor());
        // Console.WriteLine(rec.GetArea());
        // Console.WriteLine("");

        Circle circle =new Circle("Blue", 4);
        //ShowResults(circle);
        // Console.WriteLine(circle.GetColor());
        // Console.WriteLine(circle.GetArea());
        // Console.WriteLine("");

        List<Shape> list =new List<Shape>();
        list.Add(sq);
        list.Add(rec);
        list.Add(circle);
        foreach (Shape shape in list)
        {
             ShowResults(shape);
            // Console.WriteLine(shape.GetColor());
            // Console.WriteLine(shape.GetArea());
        }
    }
    public static void ShowResults(Shape shape)
    {
        
        Console.WriteLine("");
        Console.WriteLine(shape.GetColor());
        Console.WriteLine(shape.GetArea());

    }
}