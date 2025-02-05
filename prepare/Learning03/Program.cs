using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");


        Fraction fractionOne = new Fraction();

        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());


        Fraction fractionTwo = new Fraction(5);

        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());



        Fraction fractionThree = new Fraction(6, 5);

        Console.WriteLine(fractionThree.GetFractionString());
        Console.WriteLine(fractionThree.GetDecimalValue());



        Fraction fractionFour = new Fraction(1, 3);

        Console.WriteLine(fractionFour.GetFractionString());
        Console.WriteLine(fractionFour.GetDecimalValue());
    }
}