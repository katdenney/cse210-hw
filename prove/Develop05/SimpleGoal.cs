using System;
using static Constants;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
    : base (name, description, points)
    {}
    //constructor that uses StreamReader for the LoadToFile
    public SimpleGoal(StreamReader read) :base(read)
    {}

    public void RecordEvent()
    {
        
    }
    public override bool IsComplete()//come back to this!!!!//This is where im stopping for now 9pm
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            _score += _pointsForCompletion;
        }
        return _isCompleted;
    }
    public override string GetStringRepresentation()
    {
        return $"simple{delimiter+base.GetStringRepresentation()}";

    }

}
