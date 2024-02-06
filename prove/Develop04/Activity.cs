using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
class Activity 
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0; 
    private int _sleepTime = 0; // this is Milliseconds  (just added this)
    private int _seconds = 0; //(just added this)

    private DateTime _startTime;
    private DateTime _finishedTime;
    //private DateTime _startSpin;//added this dont know if its right yet
    

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetSeconds()//added this dont know if its right yet
    {
        return _seconds;
    }
    public void SetSeconds(int seconds)//added this dont know if its right yet
    {
        _seconds = seconds;
    }
    public int GetSleepTime()//added this dont know if its right yet
    {
        return _sleepTime;
    }
    public void SetSleeptime(int sleepTime)//added this dont know if its right yet
    {
        _sleepTime = sleepTime;
    }
    public DateTime GetStartTime()
    {
        return _startTime;
    }
    public void SetStartTime(DateTime dateTime)
    {
        _startTime = dateTime;
    }
    public DateTime GetFinishedTime()//added this dont know if its right yet
    {
        return _finishedTime;
    }
    public void SetFinishedTime(DateTime finishedTime)//added this dont know if its right yet
    {
        _finishedTime = finishedTime;
    }
    
    public Activity()
    {
        Console.WriteLine("Activity: used constructor with no arguments");
    }

    public Activity(string name, string description, int duration,int sleepTime, int seconds)//constructor initializing class attributes
    {
        Console.WriteLine("New Activity created.");
        //if anything needs to be done to all the classes do it here.
        _name = name;
        _description = description;
        _duration = duration;
        _sleepTime = sleepTime;
        _seconds = seconds;

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Get ready...");
        SleepMethod(1000);
        ShowSpinner(10);
        Console.WriteLine("does the spinner work?");
        SleepMethod(1000);
        Console.WriteLine($"Welcome to the {_name} Activity.");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        SleepMethod(_sleepTime);
        Console.WriteLine($"Seconds was {_duration}");

    }

    public void SleepMethod(int sleepTime)//just added this 
    {
        Thread.Sleep(sleepTime);
    }

    public void ShowCountDown(int seconds)//added this dont know if its right yet
    {
        bool finished = false;
        DateTime finishedTime = GetStartTime().AddSeconds(seconds);
        while(!finished)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"{i}");
                SleepMethod(_sleepTime);
                Console.Clear();
            }
            if(DateTime.Now > finishedTime)
            {
                finished = true;
                continue;
            }
        }
    }
    //showingspinner void (int seconds)
    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("spinner");
        DateTime _startSpin = DateTime.Now;
        
        //loop 
        while ((DateTime.Now - _startSpin).TotalSeconds < seconds)
        {
        Console.Write("/");  // Frame 1
            Thread.Sleep(200);
            Console.Write("\b"); // Move cursor back
            Console.Write("-");  // Frame 2
            Thread.Sleep(200);
            Console.Write("\b"); // Move cursor back
            Console.Write("\\"); // Frame 3
            Thread.Sleep(200);
            Console.Write("\b"); // Move cursor back
            Console.Write("|");  // Frame 4
            Thread.Sleep(200);
            Console.Write("\b"); // Move cursor back
        }
        

    }
}