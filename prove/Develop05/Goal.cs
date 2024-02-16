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
            _isCompleted = bool.Parse(data[3]);
    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

    public virtual void RecordEvent() {}

    public virtual bool IsComplete()
    {
        return _isCompleted;   
    }
    protected string CompletedCheckbox()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }

    public virtual string GetDetailsString()
    {
        return $"{CompletedCheckbox()} {_shortName}, {_description}";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName+delimiter+_description+delimiter+_pointsForCompletion+delimiter+_isCompleted}";
    }

    public virtual int GetScore()//ternary conditional operator
    {
        return _isCompleted?_pointsForCompletion:0;
    }
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator

}