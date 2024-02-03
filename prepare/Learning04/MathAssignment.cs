using System;
using System.IO.Pipes;
class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    //constructor that requires a value for each of the items that it stores student name,topic,textbook section, problems
    public MathAssignment(string name,string topic,string section,string problems)
    : base(name,topic)
    {
        _textbookSection = section;
        _problems = problems; 
    }
    public string GetHomeworkList()
    {
        //section number and problems
        return $"Section:{_textbookSection} & Problems{_problems}";
    }

}