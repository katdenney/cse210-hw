using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

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
        
        

    }

    public void GetRandomPrompt()
    {

    }

    public string GetListFromUser()
    {

        return "";
    }

}