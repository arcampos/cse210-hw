using System;
using System.Runtime.CompilerServices;

public class Entry
{
    public static Random random = new Random();

    public static string[] prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the estrongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public Entry()
    {
        Prompt = GetRandomPrompt();
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    public override string ToString()
    {
        return $"{Prompt} {Response} {Date}";
    }
}