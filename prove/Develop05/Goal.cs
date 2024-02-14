using System;
using System.ComponentModel;
using static Constants;

class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public string GetName()
    {
        return _shortName;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual int GetScore()
    {
        return 0;
    }

    public string GetDetailsString()
    {
        return $"{_shortName}{_description}{_points}";

    }
    public virtual string GetStringRepresentation()
    {
        return $"goal{delimiter+_shortName+delimiter+_description+delimiter+_points}";
    }

}