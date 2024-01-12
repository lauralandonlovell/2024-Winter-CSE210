using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
       Person person1 = new Person();
       person1._givenName = "Allie";
       person1._familyName = "Lovell";

       Job job1 = new Job();
       job1._jobTitle = "Boulangère";
       job1._company = "Coimbras";
       job1._startYear = "1997";
       job1._endYear = "2024";

       //job1.Display();
       
       Job job2 = new Job();
       job2._jobTitle = "Horse Trainer";
       job2._company = "Happy Horse Farms";
       job2._startYear = "2000";
       job2._endYear = "2024";

       //job2.Display();

       Resume resume1 = new Resume();
       resume1._name = "Allie Lovell";

       resume1._jobs.Add(job1);
       resume1._jobs.Add(job2);
       
       person1.ShowEasternName();
       person1.ShowWesternName();

       job1.Display();
       job2.Display();

       resume1.Display();
    }    
}
