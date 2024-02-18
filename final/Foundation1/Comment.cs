using System;
class Comment
{
    private string _nameOfCommenter;
    private string _commentString;

    public Comment(string name,string commentString)
    {
        _nameOfCommenter = name;
        _commentString = commentString;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"Name of Commenter: {_nameOfCommenter}");
        Console.WriteLine($"Comment:{_commentString}");
    }
}