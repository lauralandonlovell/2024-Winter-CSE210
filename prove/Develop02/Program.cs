using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        journal1.DisplayMessage();
        journal1.DisplayMenu();
        Console.Write("\nPlease enter the number of your choice: ");
        Console.ReadLine();
        journal1.DisplayEndMessage();

           
    }
}