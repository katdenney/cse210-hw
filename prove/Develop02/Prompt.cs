using System;
using System.IO;
public class Prompt
{
    //public List<string> _promptList = new List<string>();
    public string [] _promptList;
    public string _promptsFileName = "prompts.txt";
    public int _promptCount;

    //constructor
    public Prompt()
    {
        //reading the lines from prompts.txt & storing them in the _promptList
        _promptList = System.IO.File.ReadAllLines(this._promptsFileName);
        //Length gets the number of prompts from _promptList and puts it into the _promptCount feild 
        this._promptCount = _promptList.Length;
    }
    

    public string GetPrompt()
    {
        Random rand_object = new Random();
        //selection is an int that holds the random number the Next method returns a non negative random integer
        int selection = rand_object.Next(0, this._promptCount);
        //printing the random number because I want to see it
        //Console.WriteLine(selection);
        //returning the prompt at the index of the randomly picked number
        return this._promptList[selection];
    }
}