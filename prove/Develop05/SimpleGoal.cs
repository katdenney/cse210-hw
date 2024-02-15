using System;
using static Constants;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, int score)
    : base (name, description, points, score)
    {}
    //constructor that uses StreamReader for the LoadToFile
    public SimpleGoal(StreamReader read) :base(read)
    {}

    public void RecordEvent()
    {
        
    }
    public override bool IsComplete()//come back to this!!!!//This is where im stopping for now 9pm
    {
        if (!base._isCompleted)
        {
            return true;
            base._score += base._pointsForCompletion;
        }
        
    }
    public override string GetStringRepresentation()
    {
        return $"simple{delimiter+base.GetStringRepresentation()}";

    }
    public override int GetScore()
    {
        return base.GetPointsForCompletion();
    }

}
