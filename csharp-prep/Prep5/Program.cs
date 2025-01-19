using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        WelcomeMessage();

        string name = UserName();

        int number = UserFavoriteNumber();

        int squaredNum = FavoriteNumberSquared(number);

        EndScreen(name, squaredNum);

    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to this progoram!");
    }

    static string UserName()
    {
        Console.Write("What is your name?: ");
        string nameOfUser = Console.ReadLine();

        return nameOfUser;
    }

    static int UserFavoriteNumber()
    {
        Console.Write("What is your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int FavoriteNumberSquared(int favoriteNumber)
    {
        int squared = favoriteNumber * favoriteNumber;

        return squared;
    }

    static void EndScreen(string nameOfUser, int squared)
    {
        Console.WriteLine($"Hey {nameOfUser}! Your favorite number squared is {squared}");
    }
}