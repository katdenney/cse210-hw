using System;

class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

     public ChecklistGoal(string name, string description, int points, int target, int bonus)
    : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;//fix this later

    }
    public string GetDetailsString()
    {
        return string.Empty;

    }
    public string GetStringRepresentation()
    {
        return string.Empty;

    }



}