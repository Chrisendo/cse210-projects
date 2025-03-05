using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflect = new ReflectionActivity();
        ListingActivity list = new ListingActivity();


        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Quit");

            Console.WriteLine();

            choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                breathing.Run();
            }

            else if (choice == "2")
            {
                reflect.Run();
            }

            else if (choice == "3")
            {
                list.Run();
            }

            else if (choice == "4")
            {
                Console.WriteLine("Have a great day!");
            }

            else
            {
                Console.WriteLine("Not an option... choose again!");
            }
        }

    }
}