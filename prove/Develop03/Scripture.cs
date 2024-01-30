using System;
using System.Collections.Generic;

/*Scripture: Keeps track of both the reference 
and the text of the scripture. Can hide words 
and get the rendered display of the text.*/
class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();
    private int _displayedCount = 0;  // how many times this scripture object has been printed.
    private bool _isDone = false;  
    public bool IsDone 
    {
        get { return _isDone; }
    }
    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        //build a list of words 
        BuildWordList(text);
    }
    private void BuildWordList(string text)
    {
        // cut the text into words and add to _words List<Word>
        string[] words = text.Split(' ');//splitting the input into an array of words using a space as the delimiter 

        // filling the List with word objects
        foreach (string wordText in words)
        {
            Word word = new Word(wordText);  
            _wordList.Add(word);
        }
    }
 
    public void HideRandomWords(int numberToHide)
    {
        int wordsToHide = numberToHide;
        int wordsLeft = _wordList.Count - HiddenCount();
        while (wordsToHide > 0 && wordsLeft > 0)
        {
            // looking for a word that isn't hidden, and call .Hide().
            Random rnd = new Random();
            int wordToHide = rnd.Next(_wordList.Count);
            if (_wordList[wordToHide].IsHidden() == false)
            {
                _wordList[wordToHide].Hide();
                wordsToHide--;  //decrement take away one
                wordsLeft--;    //decrement take away one
                if(wordsLeft==0)
                    _isDone = true;
            }
            else {  //no action so we just try another word. 
                Console.WriteLine("random word was already hidden.");
            } 
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        /*The "display text" refers to the text with some words shown normally, and some replaced by underscores.*/
        foreach (Word word in _wordList)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _wordList)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    // This returns the printed text of the scripture with the hidden words
    public string PrintScripture() 
    {
        // first time print everything.
        if (_displayedCount > 0)
        {
            // hide 3 random words in the _words List.
            HideRandomWords(3);
        }
        string output = "";
        int position = 0;
        foreach (Word w in _wordList)
        {
            output += w.GetDisplayText();
            if (position < _wordList.Count - 1)
            {
                output += " ";
            }
        }
        _displayedCount++;
        return output;
    }
    private int HiddenCount()
    {
        int x = 0;
        foreach (Word w in _wordList)
        {
            if (w.IsHidden())
            {
                x++;
            }
        }
        return x;
    }

}