using System;

/*Word: Keeps track of a single word
 and whether it is shown or hidden. A class for a Word will need a constructor as well. 
 This constructor should accept the text of the word to save it as an attribute. 
 In addition, the constructor will need to set the initial visibility of the word (whether it is shown or hidden). 
 Notice that you should not need to pass in the visibility of the word. It can be set to be visible by default.*/
class Word
{
    private string _word;
    private bool _isHidden;

    //constructor 
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide()
    {//sets _isHidden to true
        _isHidden = true;
    }

    public void Show()
    {//sets _isHidden to false
        _isHidden = false;
    }
    public bool IsHidden()
    {//looks to see if the word is hidden or not
        return _isHidden;
    }
    public string GetDisplayText()
    {//makes underscores for hidden word 
        if (_isHidden)
        {
            string underscores = new string('_',_word.Length);
            return underscores;// underscores for as many letters are in the word.
        }
        else
        {
            return _word;
        }
    }
}