using System;
using static Constants;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
    : base (name, description, points)
    {}
    
    public SimpleGoal(string[] baseData) :base(baseData)
    {}

    public override void RecordEvent() 
    {
        if(!_isCompleted)
        {
            _isCompleted = true;
        }
    }
    public override bool IsComplete()
    {
        return _isCompleted;
    }
    public override string GetStringRepresentation()
    {
        return $"simple{delimiter+base.GetStringRepresentation()}";

    }

    public override int GetScore()
    {
        return base.GetScore();
    }

}
