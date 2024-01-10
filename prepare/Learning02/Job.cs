public class Job
{
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;

    public void Display()
    {
        Console.WriteLine($"\n Job Title: {_jobTitle}\n Company: {_company}\n Start Year: {_startYear}\n End Year: {_endYear}\n");
    }

}

