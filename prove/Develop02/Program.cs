using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        
        List<string> choices = new List<string>();
        choices.Add("Write");
        choices.Add("Display");
        choices.Add("Load");
        choices.Add("Save");
        choices.Add("Quit");
        //below expression inspired by https://stackoverflow.com/questions/62335522/printing-the-index-of-an-item-in-the-item to achieve number with Menu choice.
        choices.ForEach(item => Console.WriteLine($"{choices.IndexOf(item)}.{item}"));
        Console.WriteLine();
        Console.WriteLine("\nPlease enter the number of your choice: ");
        string userChoice = Console.ReadLine();

        Prompts prompt1 = new Prompts();

        Entry entry1 = new Entry();
        entry1._entryDate = "";
        entry1._promptText = prompt1.GetPrompt();
        entry1._entryText = ">>>";
        entry1.Display();

        Journal journal1 = new Journal();
        journal1._entries = new List<Entry>();
        journal1.DisplayContents();
        // if (userChoice == "0")
        // {
        //     entry1.Display();
        //     journal1.AddEntry(entry1);
        // } 
        // else if (userChoice == "1")
        // {
        //     entry1.Display();
        // }
        // else if (userChoice == "2")
        // {
        //     journal1.DisplayContents();
        // }
        // else if (userChoice == "3")
        // {
        //     Console.WriteLine("Please specify a filepath: ");
        //     string file = Console.ReadLine();
        //     journal1.SaveToFile(file);
        // }
        // else if (userChoice =="4")
        
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Good-bye, write again tomorrow!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("Press any key to exit: ");
        Console.ReadKey();  
    
              
    }
}