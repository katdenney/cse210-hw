using System;

class ReflectingActivity : Activity
{
    SentencesData _prompts;
    SentencesData _questions;

    public ReflectingActivity()
    : base()
    {
        Console.WriteLine("ReflectingActivity: used constructor with no arguments");
        _prompts = new SentencesData("ReflectionPrompts.txt");
        _questions =  new SentencesData("ReflectionQuestions.txt");
    }
    public ReflectingActivity(string name, string description, int duration, string[] prompts, string[] questions)
    : base(name, description, duration)
    {
        _prompts = new SentencesData("ReflectionPrompts.txt");
        _questions =  new SentencesData("ReflectionQuestions.txt");
    }
    public void Run()
    {
        int duration = GetDuration();
        bool finished = false;
        string prompt = _prompts.GetSentences();
        Console.WriteLine(prompt);
        DateTime finishedTime = GetStartTime().AddSeconds(duration);
        int sleepTime = 1667; // this is Milliseconds
        while(!finished) //loop until time is reached
        {  
            string question = _questions.GetSentences();
            Console.WriteLine(question);
            Thread.Sleep(sleepTime);
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
            
        }
        Console.WriteLine($"Seconds was {duration}");    
    }
}