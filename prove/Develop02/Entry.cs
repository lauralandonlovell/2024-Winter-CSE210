using System.Collections.Generic;
using System.Globalization;
public class Entry
{
  public DateTime _entryDate = DateTime.Now; 
  public string _promptText;
  public string _entryText;
  public void Display()
  {
    
  }
  public string GetDate()
  {
      DateTime entryStamp = new DateTime();
      entryStamp = DateTime.Now;
      string _entryDate = entryStamp.ToShortDateString();
      return _entryDate; 

  }   
} 

