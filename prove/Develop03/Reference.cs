using System;

public class Reference
{
    // if _endVerse isn't needed, set it to -1 so it doesn't display.

    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {

    }


    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        
    }


    public Reference(string referenceText)
    {

    }


    public string GetDisplayContent()
    {
        return "ref GetDisplayContent";
        // throw new NotImplementedException();
    }
}