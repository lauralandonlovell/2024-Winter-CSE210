using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //instantiated list
        List<int>numbers = new List<int>();

        for (int i = 0; i <= 9; i++)
        {
            //numbers from user
            Console.WriteLine("Enter a number: ");
            int numero = int.Parse(Console.ReadLine());

            //filling list
            numbers.Add(numero);
        }

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        //computing sum
        int total = numbers.Sum();
        Console.WriteLine(total);

        decimal count = numbers.Count;
        Console.WriteLine(count);

        decimal average = total / count;

        float maximum = numbers.Max();

        Console.WriteLine($"The total is {total}.The average is {average}. The highest value is {maximum}.");
        
    }
}



