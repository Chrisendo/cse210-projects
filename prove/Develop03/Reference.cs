using System;

public class Reference
{
    // if _endVerse isn't needed, set it to -1 so it doesn't display.

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    public Reference()
    {
        _book = "Unknown";
        _chapter = 0;
        _startVerse = 0;
        _endVerse = -1;
    }


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }


    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }


    public Reference(string referenceText)
    {

    }


    public void SetEndVerse(int endVerse)
    {
        if (endVerse >= 0)
        {
            _endVerse = endVerse;
        }
        else
        {
            _endVerse = 0;
        }
    }


    public string GetDisplayContent()
    {
        return "ref GetDisplayContent";
        // throw new NotImplementedException();
    }
}