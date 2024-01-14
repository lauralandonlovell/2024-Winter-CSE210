using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        //verifying Fraction class constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);

        //verifying getter/setter
        Fraction fractionoid = new Fraction();
        fractionoid.SetTop(6);
        Console.WriteLine(fractionoid.GetTop());

        Fraction fractionoid1 = new Fraction();
        fractionoid1.SetBase(5);
        Console.WriteLine(fractionoid1.GetBase());

        fraction1.GetFractionString();
        fraction1.GetDecimalValue();






        
        


    }
}