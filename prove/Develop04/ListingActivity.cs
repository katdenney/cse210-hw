using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string desc, int duration, int count)
    : base(name, desc, duration)
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