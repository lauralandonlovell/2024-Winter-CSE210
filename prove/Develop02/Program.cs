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
        Prompt prompt1 = new Prompt();
        prompt1._word = "Surprisingly...";

        Prompt prompt2 = new Prompt();
        prompt2._word = "Today...";

        Prompt prompt3 = new Prompt();
        prompt3._word = "Tomorrow...";

        Prompt prompt4 = new Prompt();
        prompt4._word = "Why...";

        Prompt prompt5 = new Prompt();
        prompt5._word = "When...";

        Entry entry1 = new Entry();
        entry1._promptList.Add(prompt1);
        entry1._promptList.Add(prompt2);
        entry1._promptList.Add(prompt3);
        entry1._promptList.Add(prompt4);
        entry1._promptList.Add(prompt5);

        entry1.Display();

        journal1.DisplayEndMessage();

        


           
    }
}