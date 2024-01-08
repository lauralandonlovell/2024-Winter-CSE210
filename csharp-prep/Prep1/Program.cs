using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string name = Console.ReadLine();
        // Console.WriteLine(name);

        Console.WriteLine("What is your last name?");
        string lastName = Console.ReadLine();
        // Console.WriteLine(lastName);

        Console.WriteLine($"Your name is {lastName}, {name} {lastName}.");





    }
}