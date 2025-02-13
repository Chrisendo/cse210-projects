using System;

public class Fraction
{
    private int _top;
    private int _bottom;



    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int topNum)
    {
        _top = topNum;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // Do I even need these???
    // public int GetTopNumber()
    // {
    //     return _top;
    // }

    // public void SetTopNumber(int top)
    // {
    //     _top = top;
    // }

    // public int GetBottomNumber()
    // {
    //     return _bottom;
    // }

    // public void SetBottomNumber(int bottom)
    // {
    //     _bottom = bottom;
    // }



    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}