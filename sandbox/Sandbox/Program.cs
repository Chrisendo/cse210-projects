using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        //int name = "john";
        Movie favoriteMovie = new Movie();
        favoriteMovie._title = "Star Wars";
        favoriteMovie._year = 1977;
        favoriteMovie._rating = "PG";
        favoriteMovie._runtime = 150;
        
        Movie otherMovie = new Movie();
        otherMovie._title = "Avatar";
        otherMovie._year = 2009;
        otherMovie._runtime = 162;
        otherMovie._rating = "PG-13";
        
        // Console.WriteLine(favoriteMovie._title);

        favoriteMovie.Display();
        otherMovie.Display();

        DisplayMovie(favoriteMovie);
        DisplayMovie(otherMovie);
    }

    static void DisplayMovie(Movie aMovie)
    {
        Console.WriteLine($"{aMovie._title} - {aMovie._year}");
    }
}







/*
// comment, or
        /* this comment */
       // string adjective = GetAdjective();
       // string noun = GetNoun();
       // int number = Multiply(3, 4);

       // Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}");
   // }

    //static int Multiply( int number1, int number2)
   // {
     //   int product = number1 * number2;
     //   return product;
   // }

  //  static string GetAdjective()
   // {
      //  List<string> words = new List<string>();
      //  words.Add("blue");
      //  words.Add("red");
      //  words.Add("orange");
      //  words.Add("purple");

       // string adjective = words [2];


        // string adjective = "yellow";
      //  return adjective;
   // }

    //static string GetNoun()
  //  {
     //   string word = "bird";
     //   return word;