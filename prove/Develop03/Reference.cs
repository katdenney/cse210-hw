using System;
using System.IO;

/*Reference: Keeps track of the book, 
chapter, and verse information.*/
class Reference
{
    private string _book;
    private int _chapter;
    private string _verse;

    public Reference(string book, int chapter,string verse)
    {//constructor#1
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter,string verseFirst,string verseLast)//using string for verse becuase I dont think I need to do math with the verse numbers
    {//constructor#2
        _book = book;
        _chapter = chapter;
        _verse = verseFirst + "-" + verseLast;
    }

    public string GetDisplayText()
    {
        string text = $"{_book}{_chapter}{_verse}";
        return text;
    }
     /*public void GetReference()//just an idea to pull it from a file
    {
        //prove2 uses read text from file 
        ill come back to this if I have time.
    }*/
}