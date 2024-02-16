using System;
using System.ComponentModel;
using System.Linq.Expressions;
using static Constants;

class Goal
{
    private string _shortName;
    private string _description;
    protected int _pointsForCompletion;
    protected bool _isCompleted = false;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _pointsForCompletion = points;
    }
    public Goal(string[] data)
    { 
            _shortName = data[0];
            _description = data[1];
            _pointsForCompletion =int.Parse(data[2]);
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPointsForCompletion()
    {
        return _pointsForCompletion;
    }
    public virtual void RecordEvent()
    {
        if(!_isCompleted)
        {
        _isCompleted = true;
        }
    }

    public virtual bool IsComplete()//This is where im stuck
    {
        return _isCompleted;   
    }
    protected string CompletedCheckbox()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }

    public string GetDetailsString()
    {
        return $"{_isCompleted}, {_shortName}, {_description}";
    }
    public virtual string GetStringRepresentation()
    {
        return $"goal{delimiter+_shortName+delimiter+_description+delimiter+_isCompleted}";
    }
}