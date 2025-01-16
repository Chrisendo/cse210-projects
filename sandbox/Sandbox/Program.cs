using System;

class Program
{
    static void Main(string[] args)
    {
        // comment, or
        /* this comment */
        string adjective = GetAdjective();
        string noun = GetNoun();
        int number = Multiply(3, 4);

        Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}");
    }

    static int Multiply( int number1, int number2)
    {
        int product = number1 * number2;
        return product;
    }

    static string GetAdjective()
    {
        List<string> words = new List<string>();
        words.Add("blue");
        words.Add("red");
        words.Add("orange");
        words.Add("purple");

        string adjective = words [2];


        // string adjective = "yellow";
        return adjective;
    }

    static string GetNoun()
    {
        string word = "bird";
        return word;
    }
}