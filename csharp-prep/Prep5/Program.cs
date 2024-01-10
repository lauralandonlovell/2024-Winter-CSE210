using System;

class Program
{
    static void Main(string[] args)
    {
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string DisplayName(string userName)
    {
        Console.Write("What is your name? ");
        userName = Console.ReadLine();
        return (userName);
    }
    static int UserNumber(int favoriteNumber)
    {
        Console.Write("What is your favorite number? ");
        favoriteNumber = int.Parse(Console.ReadLine());
        return (favoriteNumber);
    }
    static int SquareNumber(int favoriteNumber)
    {
        int squaredNumber = favoriteNumber * favoriteNumber;
        return squaredNumber;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine(userName, squaredNumber);
    }
}