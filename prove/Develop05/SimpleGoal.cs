using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base (name, description, points)
    {
        //nothing new to initialize
    }

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;//fix this later

    }
    public string GetStringRepresentation()
    {
        return string.Empty;

    }


}