using System;
using System.IO;

/*Reference: Keeps track of the book, 
chapter, and verse information.*/
class Reference
{
    private string _book;
    private int _chapter;
    private string _startVerse;
    private string _endVerse;  // if no endverse its just the one verse

    public Reference(string book, int chapter,string verse)  //constructor#1
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }
    public Reference(string book, int chapter,string startVerse,string endVerse)//constructor#2 
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public string GetDisplayText()
    {
        string text = $"{_book} {_chapter}:{_startVerse}";  // 1 Nephi 3:12
        if(_endVerse != null)
            text += $"-{_endVerse}"; // 1 Nephi 3:12-13
        return text;
    }

}