using System;
class WritingAssignment : Assignment
{
    private string _title;

    //constructor for student name topic title for assignment 
    public WritingAssignment(string name,string topic,string title) 
    : base( name,topic)
    //self reminder we dont need to set other variables only the ones specific to this class
    {
        _title = title;
    }
    
    public string GetWritingInformation()
    {
        //call the getter
        string name = GetStudentName();
        //  _name from Assignments = name
        return $"{_title}by: {name}";

    }

}