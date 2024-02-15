using System;
using static Constants;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, int score)
    : base (name, description, points, score)
    {}
    public EternalGoal(StreamReader read) 
    : base(read)
    {}


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