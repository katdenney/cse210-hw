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
    public ChecklistGoal(StreamReader read)
    : base(read)
    {
        _target = int.Parse(read.ReadLine());
        _amountCompleted = int.Parse(read.ReadLine());
        _bonus = int.Parse(read.ReadLine());  
    }


    public void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public bool IsComplete()
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
    public string GetDetailsString()//default implementation only overriden by chercklistgoal
    {
        return string.Empty;

    }
    public override string GetStringRepresentation()
    {
        return $"checklist{delimiter+ base.GetStringRepresentation()+delimiter+_target+delimiter+_bonus}";
    }



}