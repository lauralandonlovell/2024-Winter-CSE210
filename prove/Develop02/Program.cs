using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        
        Journal journal1 = new Journal();
        journal1.DisplayMessage();

        List<string> choices = new List<string>();
        choices.Add("Write");
        choices.Add("Display");
        choices.Add("Load");
        choices.Add("Save");
        choices.Add("Quit");
        
        
        //below expression inspired by https://stackoverflow.com/questions/62335522/printing-the-index-of-an-item-in-the-item to achieve number with Menu choice.

        choices.ForEach(item => Console.WriteLine($"{choices.IndexOf(item)}. {item}"));

    }
}