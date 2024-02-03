using System;
class Assignment
{
    private string _studentName;
    private string _topic;

//Create a constructor for this class that receives a student name and topic and sets the member variables.
    public Assignment(string name,string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;

    }
    public string GetTopic()
    {
        return _topic;
    }
    
    public string GetSummary()
    {
        //students name and the topic 
        return $"{_studentName} & {_topic}";
    }
}