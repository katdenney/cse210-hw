using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 Scripture memorizer World!");

        Console.Write("Please enter a book of scripture.");
        string book = Console.ReadLine();
        Console.WriteLine("The book you entered is: "+ book);

        Console.Write("Please enter a chapter of scripture.");
        string chapterInput = Console.ReadLine();
        int chapter = int.Parse(chapterInput);
        Console.WriteLine("The chapter you entered is: "+ chapter);

        Console.Write("Please enter a verse number or verses of scripture.");
        string verseString = Console.ReadLine();
        Console.WriteLine("The verse(s) you entered are: "+ verseString);

        Console.WriteLine("Please enter the text of your scripture.");
        string text = Console.ReadLine();
        Console.WriteLine("The text you entered is: "+ text);

        //Reference instance
        //turn the string to int, for Reference(string, int, int)
    
        Reference reference = new Reference(book, chapter, verseString);


        Scripture scripture;
        if (verseString.IndexOf('-', 0, verseString.Length - 1) == -1)//checking if verseString has a -
        {
            scripture = new Scripture(reference, text);//no hyphen
        }
        else
        {
            string[] verses = verseString.Split('-');//with hyphen split into array 
            int count = verses.Count();
            if (count <= 1 || count > 2)//one or two parts
            {
                //  Error condition
                Console.WriteLine("the string[] Count was not 2");
                Console.WriteLine("Exiting, please start over.");
                return;
            }
            else
            {
                // Count is 2 creating scripture object with the second scripture constructor
                string verseFirst = verses[0];
                string verseLast = verses[1];
                scripture = new Scripture(reference, text);
            }
            //just checking.
            if (scripture is null)
            {
                Console.WriteLine("We didn't get a Scripture object");
                Console.WriteLine("Exiting, please start over.");
                return;
            }

        }

        bool quit =false;
        while (!quit)
        {
            //Console.Clear();
            string reference1 = reference.GetDisplayText();
            Console.WriteLine(reference1);
            string output = scripture.GetDisplayText();
            Console.WriteLine(output);
            if (scripture.IsDone)  // if all words are hidden get out....
                quit = true;
            Console.WriteLine("|-- Type quit and enter to QUIT, or just Enter to continue.");
            string answer = Console.ReadLine();
            Console.WriteLine(answer);
            if (answer.ToLower() == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideRandomWords(3);
                Console.WriteLine("------------------------------------");
            }
        }
        
       

       
    }
}