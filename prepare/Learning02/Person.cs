public class Person
{
    //class variables
    public string _givenName = "";
    public string _familyName = "";

    //class constructor
    public Person()
    {
    }

    //Class methods
    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }
    
}