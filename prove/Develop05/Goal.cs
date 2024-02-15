using System;
using System.ComponentModel;
using static Constants;

class Goal
{
    private string _shortName;
    private string _description;
    protected int _pointsForCompletion;
    protected int _score = 0;
    protected bool _isCompleted = false;

    public Goal(string name, string description, int points, int score)
    {
        _shortName = name;
        _description = description;
        _pointsForCompletion = points;
        _score = score;
       

    }
    public Goal(StreamReader read)
    {
        _shortName = read.ReadLine();
        _description = read.ReadLine();
        _pointsForCompletion = int.Parse(read.ReadLine());
        _score = int.Parse(read.ReadLine());
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
    public void SetPointsForCompleation(int points)
    {
        _pointsForCompletion = points;
    }
    public void RecordEvent()
    {

    }
    /*public virtual bool Complete()
    {
        return _isCompleted;
    }*/
    public virtual bool IsComplete()//This is where im stopping for now 8:51pm
    {
        return _isCompleted;
    }
    protected string CompletedCheckbox()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }
    public virtual int GetScore()
    {
        return _score;
    }

    public string GetDetailsString()
    {
        return $"{_isCompleted}{_shortName}{_description}{_score}";

    }
    public virtual string GetStringRepresentation()
    {
        return $"goal{delimiter+_shortName+delimiter+_description+delimiter+_score+delimiter+_isCompleted}";
    }
    public virtual void WriteToStreamWriter(StreamWriter w)
    {
        w.WriteLine(_shortName);
        w.WriteLine(_description);
        w.WriteLine(_pointsForCompletion);
        w.WriteLine(_isCompleted);
        w.WriteLine(_score);
    }

}