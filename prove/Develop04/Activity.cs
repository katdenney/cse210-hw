using System;
using System.ComponentModel;
class Activity 
{
    private string _name = "";
    private string _description = "";
    private int _duration = 0; 

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
    
    public Activity()
    {
        Console.WriteLine("used constructor with no arguments");
    }

    public Activity(string name, string desc, int duration)//constructor initializing class attributes
    {
        Console.WriteLine("New Activity created.");
        //if anything needs to be done to all the classes do it here.
        _name = name;
        _description = desc;
        _duration = duration;

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");

    }

    public void DisplayEndingMessage()
    {

    }

    //showingspinner void (int seconds)
    public void ShowSpinner(int seconds)
    {
        //loop 
        Console.Write("+");
        Thread.Sleep(500);
        Console.Write("\b \b");//erasing the +
        Console.Write("-");//replacing it with -

    }
}