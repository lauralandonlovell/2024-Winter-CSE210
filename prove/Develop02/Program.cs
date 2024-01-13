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
        
        //Console.ForegroundColor = ConsoleColor.Yellow;
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
        Console.ReadKey();
        Console.WriteLine();

        //Journal journal1 = new Journal();

        Prompts prompt1 = new Prompts();

        Entry entry1 = new Entry();
        //entry1._entryDate = DateTime.Now;
        entry1._promptText = prompt1.GetPrompt();
        entry1._entryText = "test";

        // journal1.AddEntry(entry1);

        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Good-bye, write again tomorrow!");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.Write("Press any key to exit: ");
        Console.ReadKey();
    }
}