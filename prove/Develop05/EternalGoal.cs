using System;
using static Constants;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    : base (name, description, points)
    {}
    public EternalGoal(string[] baseData) 
    : base(baseData)
    {}

    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"eternal{delimiter+base.GetName()+delimiter+base.GetDescription()+delimiter+base.GetPointsForCompletion()}";
    }

}