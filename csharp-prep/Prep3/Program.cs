using System;
using System.Globalization;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int newRandom = random.Next(1,101);
        Console.WriteLine(newRandom);

        int guess = -1;
        while (guess != newRandom)
        {
            Console.Write("Guess a number: ");
            guess = int.Parse(Console.ReadLine());

            if (newRandom > guess)
            {
                Console.Write("Guess higher next time.");
            }
            else if (newRandom < guess)
            {
                Console.Write("Guess lower next time.");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number!"); 
            }    
        }
        Console.Write("Would you like to play again? ");
        
    }        
    
}