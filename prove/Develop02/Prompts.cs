using System.Collections.Generic;
public class Prompts
{
    List<string> _prompts = new List<string>();
    public string GetPrompt()
    {
        _prompts.Add("What was the funnest part of your day? ");
        _prompts.Add("Who did you talk to today? ");
        _prompts.Add("How far did you walk today? ");
        _prompts.Add("What made you think that God exists today? ");
        _prompts.Add("What do you want to start doing tomorrow? ");
        _prompts.Add("Did you see any dogs today? ");
        
        _prompts.ForEach((item) => Console.WriteLine($"{_prompts.IndexOf(item)}. {item}"));
        return "";
        
    }
    
    
    // public static void RandomPrompt<T>(List<T> _prompts)  
    // {  
    //     Random random = new Random();  
    //     int n = _prompts.Count;  

    //     for(int i= _prompts.Count - 1; i > 1; i--)
    //     {
    //         int rnd = random.Next(i + 1);  

    //         T value = _prompts[rnd];  
    //         _prompts[rnd] = _prompts[i];  
    //         _prompts[i] = value;
        //}
    //}
}