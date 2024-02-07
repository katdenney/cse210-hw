using System;

class BreathingActivity : Activity
{

    public BreathingActivity()
    : base()
    {
        //Console.WriteLine("used constructor with no arguments");
    }

    public BreathingActivity(string name, string desc, int duration,int sleepTime, int seconds)
    : base(name, desc, duration, sleepTime, seconds)
    {

    }
    
    public void Run()
    {
        int duration = GetDuration();
        bool finished = false;
        DateTime finishedTime = GetStartTime().AddSeconds(duration);
        while(!finished) // durations seconds haven't passed yet.
        {
            Console.Clear();
            Console.Write("Breathe in....");
            ShowCountDown(6);
            SleepMethod(1000); 
            Console.Write("   ");
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            SleepMethod(1000);
            Console.Write("   ");
            SleepMethod(1000);
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
        }
        
    }

}