using System;
using static Constants;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
    : base (name, description, points)
    {
        _isComplete = false;
    }

    public void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;

    }
    public override string GetStringRepresentation()
    {
        return $"simple{delimiter+base.GetStringRepresentation()+delimiter+_isComplete}";

    }
    public override int GetScore()
    {
        return base.GetPoints();
    }

}
