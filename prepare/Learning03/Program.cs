using System;

class Program
{
    static void Main(string[] args)
    {
        /* Fraction def = new Fraction();
        def.SetTop(5);
        def.SetBottom(3);
        Console.WriteLine(def.GetTop());
        Console.WriteLine(def.GetBottom()); */

        Fraction fOne = new Fraction();
        Console.WriteLine(fOne.GetFractionString());
        Console.WriteLine(fOne.GetDecimalValue());
    
        Fraction fTwo = new Fraction(5);
        Console.WriteLine(fTwo.GetFractionString());
        Console.WriteLine(fTwo.GetDecimalValue());

        Fraction fThree = new Fraction(3, 4);
        Console.WriteLine(fThree.GetFractionString());
        Console.WriteLine(fThree.GetDecimalValue());

        Fraction fFour = new Fraction(1, 3);
        Console.WriteLine(fFour.GetFractionString());
        Console.WriteLine(fFour.GetDecimalValue());

    }
}