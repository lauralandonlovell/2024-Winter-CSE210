using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

public class Entry
{
    public DateTime _entryDate = DateTime.Now;
    public List<Prompt> _promptList = new List<Prompt>();

    public string _writeEntry = "";
    //public string _prompt = "";
    //public DateOnly (int year, int month, int day, System.Globalization.Calendar calendar);
    
   public void Displaystamp()
   {
    Console.WriteLine(_entryDate);
   }
   public void Display()
   {
    foreach (Prompt prompt in _promptList)
    {
      prompt.Display();
    }
   }
     

    

}

