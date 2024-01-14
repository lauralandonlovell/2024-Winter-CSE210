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

        Fraction f1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1,3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());


        







        
        


    }
}