using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.getFraction());
        Console.WriteLine(fraction1.getValues());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.getFraction());
        Console.WriteLine(fraction2.getValues());

        Fraction fraction3 = new Fraction(5,2);
        Console.WriteLine(fraction3.getFraction());
        Console.WriteLine(fraction3.getValues());

        Fraction fraction4 = new Fraction(3,4);
        Console.WriteLine(fraction4.getFraction());
        Console.WriteLine(fraction4.getValues());

        Fraction fraction5 = new Fraction(1/3);
        Console.WriteLine(fraction5.getFraction());
        Console.WriteLine(fraction5.getValues());

    }
}