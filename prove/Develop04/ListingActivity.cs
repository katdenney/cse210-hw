using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _responses = new List<string>();
    private SentencesData _listingQuestions = new SentencesData("ListingQuestions.txt");

    public ListingActivity(string name, string desc, int duration, int sleepTime, int count,int seconds)
    : base(name, desc, duration, sleepTime, seconds)
    {
        _count = count;
    }

    public ListingActivity()
    : base()
    {
        Console.WriteLine("used constructor with no arguments");
    }

    public void Run() 
    {
        int duration = GetDuration();
        bool finished = false;
        string prompt = _listingQuestions.GetSentences();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(prompt); 
        Console.WriteLine("Press Enter to continue...");
        string pressEnter = Console.ReadLine();
        
        
        DateTime finishedTime = GetStartTime().AddSeconds(duration);
        Console.WriteLine("GO...");
        while(!finished)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            _responses.Add(response);
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
            Console.WriteLine($"{_responses.Count}");
        }
        Console.WriteLine($"You typed {_responses.Count} responses");
    }

}