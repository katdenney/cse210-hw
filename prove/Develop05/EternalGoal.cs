using System;
using static Constants;

class EternalGoal : Goal
{
    private int _count;
     public EternalGoal(string name, string description, int points, int count)
    : base (name, description, points)
    {
        _count = count;
    }

    public void RecordEvent()
    {
        
    }
    public bool IsComplete()
    {
        return false;

    }
    public override string GetStringRepresentation()
    {
        return $"eternal{delimiter+base.GetName()+delimiter+base.GetDescription()+delimiter+base.GetPoints()}";
    }

}