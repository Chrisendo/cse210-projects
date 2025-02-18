using System;

public class Word
{
    private string _text;
    private bool _isHidden;



    public Word(string text, bool isHidden)
    {
        _text = text;
        _isHidden = isHidden;
    }


    public void Hide()
    {

    }


    // public void IsHidden()
    // {
        
    // }


    public void GetDisplayContent()
    {
        Console.WriteLine($"This should be the text: {_text}");
    }
}