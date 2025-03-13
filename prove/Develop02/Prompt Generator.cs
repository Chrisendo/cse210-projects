using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    //public List<string> _prompts = new List<string>();
    // public Random random;



    // public RandomPromptGenerator()
    // {
    //     _prompts = new List<string>()
    //     {
            // "Who was the most interesting person I interacted with today?",
            // "What was the best part of my day?",
            // "How did I see the hand of the Lord in my life today?",
            // "What was the strongest emotion I felt today?",
            // "If I had one thing I could do over today, what would it be?",
            // "If I could change one thing about college, what would I change?",
            // "What is the most memorable video game, book or movie I've played, read or watched?",
            // "What type of music do I like?",
            // "What's my favorite music artist and why?",
            // "What was my first memory of life that I can remember?",
            // "What do I imagine myself doing in the next 2 years?",
            // "What do I imagine myself doing in 5 years?",
            // "What do I imagine myself doing in 10 years?",
            // "If unmarried still, what am I looking for in my partner? If married, how is my relationship with my partner?",
            // "What's my favorite fruit and/or fruit type and why?"
    //     };

    //     random = new Random();
    // }

    // public void PromptStuffGenerator()
    // {
    //     string[] prompts = 
    //     {
            // "Who was the most interesting person I interacted with today?",
            // "What was the best part of my day?",
            // "How did I see the hand of the Lord in my life today?",
            // "What was the strongest emotion I felt today?",
            // "If I had one thing I could do over today, what would it be?",
            // "If I could change one thing about college, what would I change?",
            // "What is the most memorable video game, book or movie I've played, read or watched?",
            // "What type of music do I like?",
            // "What's my favorite music artist and why?",
            // "What was my first memory of life that I can remember?",
            // "What do I imagine myself doing in the next 2 years?",
            // "What do I imagine myself doing in 5 years?",
            // "What do I imagine myself doing in 10 years?",
            // "If unmarried still, what am I looking for in my partner? If married, how is my relationship with my partner?",
            // "What's my favorite fruit and/or fruit type and why?"
    //     };

    //     Random random = new Random();

    //     public string GetRandomPrompt()
    //     {
    //     int randomIndex = random.Next(0, prompts.Length);
    //     }

    //     string randomPrompt = prompts[randomIndex];

    //     Console.WriteLine(randomPrompt);
    // }

    // // public void DisplayPrompt()
    // // {
    // //     PromptStuffGenerator();
    // // }

    // public string DisplayPrompt()
    // {
    //     string prompt = GetRandomPrompt();
    //     Console.WriteLine(prompt);
    //     return prompt;
    // }



    private string[] _prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If I could change one thing about college, what would I change?",
            "What is the most memorable video game, book or movie I've played, read or watched?",
            "What type of music do I like?",
            "What's my favorite music artist and why?",
            "What was my first memory of life that I can remember?",
            "What do I imagine myself doing in the next 2 years?",
            "What do I imagine myself doing in 5 years?",
            "What do I imagine myself doing in 10 years?",
            "If unmarried still, what am I looking for in my partner? If married, how is my relationship with my partner?",
            "What's my favorite fruit and/or fruit type and why?"
    };
    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(0, _prompts.Length);
        return _prompts[randomIndex];
    }

    public string DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        return prompt;
    }



    // public static List<Entry> ReadFromFile()
    // {
    //     List<Entry> journalStuff = new List<Entry>();
    //     string filename = "PromptList.txt";
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //     string[] parts = line.Split("-|-");

    //     Entry entryStuff = new Entry();

    //     entryStuff._author = parts[0];
    //     entryStuff._date = parts[1];
    //     entryStuff._promptQuestion = parts[2];
    //     entryStuff._response = parts[3];
    //     }

    //     return journalStuff;
    // }
}

// Who was the most interesting person I interacted with today?
// What was the best part of my day?
// How did I see the hand of the Lord in my life today?
// What was the strongest emotion I felt today?
// If I had one thing I could do over today, what would it be?
// If I could change one thing about college, what would I change?
// What is the most memorable video game, book or movie I've played, read or watched?
// What type of music do I like?
// What's my favorite music artist and why?
// What was my first memory of life that I can remember?
// What do I imagine myself doing in the next 2 years?
// What do I imagine myself doing in 5 years?
// What do I imagine myself doing in 10 years?
// If unmarried still, what am I looking for in my partner? If married, how is my relationship with my partner?
// What's my favorite fruit and/or fruit type and why?