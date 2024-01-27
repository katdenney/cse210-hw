using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 Scripture memorizer World!");

        Console.Write("Please enter a book of scripture.");
        string book = Console.ReadLine();
        Console.WriteLine("The book you entered is: "+book);

        Console.Write("Please enter a chapter of scripture.");
        string chapterInput = Console.ReadLine();
        int chapter = int.Parse(chapterInput);
        Console.WriteLine("The chapter you entered is: "+chapter);

        Console.Write("Please enter a verse number or verses of scripture.");
        string verseString = Console.ReadLine();
        Console.WriteLine("The verse/verses you entered are: "+verseString);

        Console.WriteLine("Please enter the text of your scripture.");
        string text = Console.ReadLine();
        Console.WriteLine("The text you entered is: "+text);
    }
}