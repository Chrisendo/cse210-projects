using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number. Type '0' when done: ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Calculating the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        Console.WriteLine($"Here is the sum: {sum}");

        // Calculating the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Here is the average: {average}");

        // Calculating the max
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Here is the max: {max}");
    }
}