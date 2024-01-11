using System.Reflection.Metadata.Ecma335;

public class Resume
{
   public string _name;
   public List<Job> _jobs = new List<Job>();

   public void Display()
   {
    Console.WriteLine($"\nName: ");
    Console.Write($"\nJobs: ");

    foreach (Job job in _jobs)
    {
        job.Display();
    }
   }


}