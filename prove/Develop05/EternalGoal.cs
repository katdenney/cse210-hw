using System;
using static Constants;

class EternalGoal : Goal
{
    private int _amountCompleted = 0;
    public EternalGoal(string name, string description, int points)
    : base (name, description, points)
    {}
    public EternalGoal(string[] baseData, string count) 
    : base(baseData)
    {
        _amountCompleted = int.Parse(count);
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"eternal{delimiter+base.GetStringRepresentation()+delimiter+_amountCompleted}";
    }

    public override int GetScore()
    {
        return _amountCompleted * _pointsForCompletion;
    }
}