using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int gradePercentage = int.Parse(percentage);
        
        string letter = "";  

        // if (gradePercentage >= 90)
        // {
        //     Console.WriteLine("A"); 
        // }
        // else if (gradePercentage >= 80)
        // {
        //     Console.WriteLine("B");
        // }
        // else if (gradePercentage >= 70)
        // {
        //     Console.WriteLine("C");
        // }
        // else if (gradePercentage >= 60)
        // {
        //     Console.WriteLine("D");
        // }
        // else 
        // {
        //     Console.WriteLine("F");
        // }
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass, please try again next semester.");
        }   
    }
}