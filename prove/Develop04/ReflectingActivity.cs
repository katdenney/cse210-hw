using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string>_questions = new List<string>();

    public ReflectingActivity()
    : base()
    {
        Console.WriteLine("used constructor with no arguments");
    }
    public ReflectingActivity(string name, string desc, int duration, string[] prompts, string[] questions)
    : base(name, desc, duration)
    {
        _prompts = new List<string>(questions);
    }
    public void Run()
    {

    }
    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}