using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();

        job1._company = "Microsoft";
        job1._jobTitle = "developer";
        job1._startYear = 1980;
        job1._endYear = 2004;



        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Tester";
        job2._startYear = 2006;
        job2._endYear = 2024;

        //job1.Display();
        //job2.Display();



        Resume myResume = new Resume();

        myResume._name = "Chris";

        // I got stuck here, and had to look at the example.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

        // Not sure how to test Resume on it's own....
        // myResume._jobs[0]._jobTitle

        // Everything below that's commented out is how I tested code.

        //DisplayJob(job1);
        //DisplayJob(job2);
    }

    /* static void DisplayJob(Job aJob)
    {
        Console.WriteLine($"{aJob._company}");
    } */
}