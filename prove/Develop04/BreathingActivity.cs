using System;
using System.Security.Cryptography.X509Certificates;

class BreathingActivity : Activity
{

    public BreathingActivity()
    : base()
    {

    }

    public BreathingActivity(string name, string desc, int duration)
    : base(name, desc, duration)
    {

    }
    
    public void Run()
    {
        Console.WriteLine("Breathe in....");
        Console.Write("\b \b");
        Thread.Sleep(1000);
        Console.WriteLine("Breathe in....6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Breathe in....5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Breathe in....4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Breathe in....3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Breathe in....2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Breathe in....1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Now breathe out....");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Now breathe out....6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("Now breathe out....5");
        Thread.Sleep(1000);



    }

}