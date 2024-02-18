using System;
using System.Net;
using System.Reflection;
class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List <Comment> _commentList;

    public Video(string title,string author,int seconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = seconds;
        _commentList = new List<Comment>();
    }
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"The title is :{_title}");
        Console.WriteLine($"The author is :{_author}");
        Console.WriteLine($"The length in seconds is :{_lengthSeconds}");
        Console.WriteLine($"Number of Comments: {CommentCount()}");
    }
    public void DisplayCommentList()
    {
        Console.WriteLine($" Comments for {_title}");
        foreach (Comment comment in _commentList)
        {
            comment.DisplayComment();
        }
    }
    public int CommentCount()
    {
        return _commentList.Count();
    }
    public void AddComment(string nameOfCommenter,string commentString)
    {
        Comment newComment = new Comment(nameOfCommenter,commentString);
        _commentList.Add(newComment);
    }
}