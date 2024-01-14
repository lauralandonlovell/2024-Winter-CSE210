using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{ 
    //member variables
    private int _hautNum;
    private int _basNum;
    
    //Constructors
    public Fraction()
    {
       _hautNum = 1;
       _basNum = 1;

       Console.WriteLine($"{_hautNum}/{_basNum}");   
    }
    public Fraction(int wholeNumber)
    {
        _hautNum = wholeNumber;
        _basNum = 1;

        Console.WriteLine($"{_hautNum}/{_basNum}");
    }
    public Fraction(int top, int bottom)
    {
        _hautNum = top;
        _basNum = bottom;

        Console.WriteLine($"{_hautNum}/{_basNum}");
    }

    //getter/setters
    public int GetTop()
    {
        return _hautNum;
    }
    public void SetTop(int top)
    {
        _hautNum = top;
    }
    public int GetBase()
    {
        return _basNum;
    }
    public void SetBase(int bas)
    {
        _basNum = bas;
    }
    //methods
    public string GetFractionString()
    {
        string top = _hautNum.ToString();
        string bas = _basNum.ToString();
        return top+"/"+bas;
    }
    public double GetDecimalValue()
    {
        return _hautNum / _basNum;
    }

    
}