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

        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
        _prompts.ForEach((item) => Console.WriteLine($"{_prompts.IndexOf(item)}.{item}"));
        return "";
    }

}