using System;
using System.ComponentModel;

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

    public string GetDetailsString()
    {
        return $"{_shortName}{_description}{_points}";

    }
    public string GetStringRepresentation()
    {
        return $"{_shortName}{_description}{_points}";

    }

}