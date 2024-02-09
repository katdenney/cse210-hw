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

    public void RecordEvent()
    {

    }
    public bool IsComplete()
    {
        return true;//fix this later

    }
    public string GetDetailsString()
    {
        return string.Empty;

    }
    public string GetStringRepresentation()
    {
        return string.Empty;

    }

}