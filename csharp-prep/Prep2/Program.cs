using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.WriteLine("Hello Prep2 World!"); */

        Console.Write("What is your final grade percentage? ");
        string finalgrade = Console.ReadLine();
        int grade = int.Parse(finalgrade);

        string gradeletter = "";

        if (grade >= 90)
        {
            gradeletter = "A";
        }
        else if (grade >= 80)
        {
            gradeletter = "B";
        }
        else if (grade >= 70)
        {
            gradeletter = "C";
        }
        else if (grade >= 60)
        {
            gradeletter = "D";
        }
        else
        {
            gradeletter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeletter}");
        
        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
    
}