using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        
        

        Console.Write("Please type the number of your choice: ");

        string menuSelection = Console.ReadLine();
        if ( menuSelection == "0")
        {
            ;
        }
        else if (menuSelection == "1")
        {
            ;
        }
        else if (menuSelection == "2")
        {
             = "Load";
        }
        else if (menuSelection == "3")
        {
             = "Save";
        }
        else if (menuSelection == "4")
        {
             = "Quit";
        }
        else
        {
            Console.WriteLine("I didn't understand your choice.Please enter a number.");
        }
    }
    
    {
        

        //below expression inspired by https://stackoverflow.com/questions/62335522/printing-the-index-of-an-item-in-the-item to achieve number with Menu choice.
        choices.ForEach(item => Console.WriteLine($"{choices.IndexOf(item)}. {item}"));    
    }
    
    

}