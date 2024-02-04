using System;

class BreathingActivity : Activity
{

    public BreathingActivity()
    : base()
    {
        Console.WriteLine("used constructor with no arguments");
    }

    public BreathingActivity(string name, string desc, int duration)
    : base(name, desc, duration)
    {

    }
    
    public void Run()
    {
        int duration = GetDuration();
        bool finished = false;
        DateTime finishedTime = GetStartTime().AddSeconds(duration);
        while(!finished) // durations seconds haven't passed yet.
        {
            int sleepTime = 250; // this is Milliseconds
            Console.Write("Breathe in....");
            Thread.Sleep(sleepTime);
            Console.Clear();

            for (int j = 6; j > 0; j--)
                {
                    Console.Write($"Breathe in....{j}");
                    Thread.Sleep(sleepTime);
                    Console.Clear();
                }
            Console.Write("Now breathe out...");
            Thread.Sleep(sleepTime);
            Console.Clear();
            for (int k = 6; k > 0; k--)
            {
                Console.WriteLine($"Now breathe out....{k}");
                Thread.Sleep(sleepTime);
                Console.Clear();
            }
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
        }
        Console.WriteLine($"Seconds was {duration}");
    }

}