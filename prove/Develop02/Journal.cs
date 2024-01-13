using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
    public List<Entry> _entries;
     
    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayContents()
    {
        _entries.ForEach(item => Console.WriteLine($"{_entries.IndexOf(item)}.{item}"));
        
    }
    public void SaveToFile(string file)
    {
        //testing code to see if this is in the right space
        // using (StreamWriter outputFile = new StreamWriter(filename));
        // {
            
        //     outputFile.WriteLine();
        //     string[] entryArray = _entries;
        //     for (int i=0;i >= _entries.Count; i++)
        //     outputFile.WriteLine($"{i}");
        // }
    }
    public void LoadFromFile(string file)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];
            string lastName = parts[1];
        }
    }       
}    


