using System;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture()
    {
        _words = new List<Word>();
    }


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
    }


    public void HideRandomWords()
    {

    }


    // public bool IsAllHidden()
    // {

    // }


    public void GetDisplayContent()
    {
        Console.WriteLine($"{_reference}..?");

        foreach (Word w in _words)
        {
            w.GetDisplayContent();
        }
    }


    // public void AddWord(Word, theWord)
    // {
    //     _words.Add(theWord);
    // }
}


// Doctrine and Covenants 18:10-11
// Remember the worth of souls is great in the sight of God;
// For, behold, the Lord your Redeemer suffered death in the flesh; wherefore he suffered the pain of all men, that all med might repent and come unto him.