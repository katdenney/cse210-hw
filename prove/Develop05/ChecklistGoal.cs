using System;
using System.Runtime.CompilerServices;
using static Constants;

class ChecklistGoal : Goal
{
    private int _target;
    private int _amountCompleted;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus, int count)
    : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = count;
    }
    public ChecklistGoal(string[] baseData, string[] data)
    : base(baseData)
    {
        _target = int.Parse(data[0]);
        _amountCompleted = int.Parse(data[1]);
        _bonus = int.Parse(data[2]);  
    }


    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if(_target == _amountCompleted)
            _isCompleted = true;
    }
    public override bool IsComplete()
    {
        if (_target == _amountCompleted)
        {
            return true;
        }
        else return false;
        //return _target == _amountCompleted; see if this works instead after everything is done
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public override string GetDetailsString()//default implementation only overriden by chercklistgoal
    {
        return $"{base.GetDetailsString()}, {_amountCompleted}/{_target}, {_bonus}";
    }
    public override string GetStringRepresentation()
    {
        return $"checklist{delimiter+base.GetStringRepresentation()+delimiter+_target+delimiter+_amountCompleted+delimiter+_bonus}";
    }

    public override int GetScore()
    {
        int score = 0;
        if(_target == _amountCompleted)
        {
            score += _bonus;
        }
        score += _pointsForCompletion * _amountCompleted;
        return score;
    }
}

