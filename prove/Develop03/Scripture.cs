using System;

/*Scripture: Keeps track of both the reference 
and the text of the scripture. Can hide words 
and get the rendered display of the text.*/
class Scripture
{
    private Reference _reference;
    private List<Word> _wordList = new List<Word>();

    //2 constructors 
    public Scripture(string book,int chapter,string verse,string text)
    {
        _reference = new Reference(book,chapter,verse);
        //need a list of words 


    }

    public void HideRandomWords(int numberToHide)
    {
        //prep3 uses random. 

    }

    public string GetDisplayText()
    {
        /*The "display text" refers to the text with some words shown normally, and some replaced by underscores.*/
        foreach (Word word in _wordList)
        {
            word.GetDisplayText();
        }

    }

    public bool IsCompletelyHidden()
    {
        //when to end the program

    }

}