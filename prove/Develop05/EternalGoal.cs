using System;

class EternalGoal : Goal
{
     public EternalGoal(string name, string description, int points)
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
        return $"{base.GetName}{base.GetDescription}{base.GetPoints}";

    }

}