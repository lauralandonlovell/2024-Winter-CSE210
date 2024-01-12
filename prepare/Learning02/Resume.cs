using System;
using System.Collections.Generic;

public class Resume
{
   public string _name;
   public List<Job> _jobs = new List<Job>();

   public Resume()
   {
   }

   public void Display()
   {
    Console.WriteLine($"\nName:\n Jobs:\n"); 
   }
   public void DisplayJob()
   {
      foreach (Job job in _jobs)
      {
         Console.WriteLine(job.Count)
      }
   }
}