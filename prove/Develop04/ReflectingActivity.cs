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
    public ReflectingActivity(string name, string description, int duration, int sleepTime, int seconds, string[] prompts, string[] questions)
    : base(name, description, duration, sleepTime, seconds)
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
        Console.WriteLine("Press Enter to continue...");
        string shouldJustBeEnterKey = Console.ReadLine();
        //Console.WriteLine($"---- user hit: {shouldJustBeEnterKey}");
        DateTime finishedTime = GetStartTime().AddSeconds(duration);
        while(!finished) //loop until time is reached
        {  
            string question = _questions.GetSentences();
            Console.WriteLine(question);
            ShowSpinner(5);
            SleepMethod(5000);//just added this dont know if its working
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
            
        }   
    }
}