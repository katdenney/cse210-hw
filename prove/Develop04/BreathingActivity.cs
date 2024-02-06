using System;

class BreathingActivity : Activity
{

    public BreathingActivity()
    : base()
    {
        Console.WriteLine("used constructor with no arguments");
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
            Console.Write("Breathe in....");
            SleepMethod(5000);//added this seeing if this works 
            //Thread.Sleep(sleepTime);
            Console.Clear();

            for (int j = 4; j > 0; j--)
                {
                    Console.Write($"Breathe in....{j}");
                    SleepMethod(1000);
                    Console.Clear();
                }
            Console.Write("Now breathe out...");
            SleepMethod(1000);
            Console.Clear();
            for (int k = 4; k > 0; k--)
            {
                Console.WriteLine($"Now breathe out....{k}");
                SleepMethod(1000);
                Console.Clear();
            }
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
        }
        
    }

}