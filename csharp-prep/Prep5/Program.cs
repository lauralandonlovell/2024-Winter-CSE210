using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = DisplayName();
        int userNumber = UserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
    
    //functions
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string DisplayName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int UserNumber()
    {
        Console.Write("What is your favorite number? ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return (favoriteNumber);
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }
    static void DisplayResult(string userName, int squareNumber)
    {
       Console.WriteLine($"{userName}, your favorite number squared is {squareNumber}"); 
    }
}