using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activity = new List<Activity>();

        activity.Add(new Running("November 03, 2022", 30, "Running", 3.0));
        activity.Add(new Cycling("November 03, 2022", 45, "Cycling", 15.0));
        activity.Add(new Swimming("November 03, 2022", 40, "Swimming", 60));

        foreach (var active in activity)
        {
            Console.WriteLine(active.GetSummary());
        }
    }
}