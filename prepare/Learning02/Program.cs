using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Job job1 = new Job();
       job1._jobTitle = "Boulangère";
       job1._company = "Coimbras";
       job1._startYear = "1997";
       job1._endYear = "2024";

       job1.Display();           
    }    
}