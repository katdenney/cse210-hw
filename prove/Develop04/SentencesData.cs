using System;
using System.IO;
public class SentencesData
{
    public string [] _sentencesList;
    public string _sentencesFileName;
    public int _sentencesCount;

    //constructor
    public SentencesData(string fileName)
    {
        _sentencesFileName = fileName;
        //reading the lines from sentences.txt & storing them in the _sentencesList
        _sentencesList = System.IO.File.ReadAllLines(this._sentencesFileName);
        //Length gets the number of sentences from _sentencesList and puts it into the _sentencesCount feild 
        this._sentencesCount = _sentencesList.Length;
    }
    

    public string GetSentences() // Gets a random sentence from the list
    {
        Random rand_object = new Random();
        //selection is an int that holds the random number the Next method returns a non negative random integer
        int selection = rand_object.Next(0, this._sentencesCount);
        //printing the random number because I want to see it
        //Console.WriteLine(selection);
        //returning the sentences at the index of the randomly picked number
        return this._sentencesList[selection];
    }
}