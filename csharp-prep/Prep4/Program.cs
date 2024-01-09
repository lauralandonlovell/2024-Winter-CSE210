using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
        int i = 0;
        while (i < 11)
        {
            Console.WriteLine("Enter a number: ");
            string response = Console.ReadLine();
            int number = int.Parse(response);
            Console.WriteLine(number);
            i++;
        }
    }
}