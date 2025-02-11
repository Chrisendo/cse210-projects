using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
    }


    static void Main(string[] args)
    {
        PromptGenerator pg = new PromptGenerator();
        Journal theJournal = new Journal();
        bool keepRunning = true;

        while (keepRunning)
        {
            DisplayMenu();

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                // write a new entry

                Console.Write("Who is going to be the author of this journal entry? ");
                string author = Console.ReadLine();

                // Date

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // Prompt Question


                // Response

                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._author = author;
                newEntry._date = dateText;
                newEntry._promptQuestion = "This should be the prompt question";
                newEntry._response = response;

                theJournal._entries.Add(newEntry);

                List<Entry> en = new List<Entry>();
                en.Add(newEntry);
            }
            else if (choice == "2")
            {
                // Display the journal

                theJournal.DisplayAll();
            }
            else if (choice == "3")
            {

                theJournal.SaveToFile();

                // Save the journal to a file

                //theJournal.SaveToFile()
                //List<Entry> en = new List<Entry>();
                
                // theJournal.SaveToFile(en);

                // theJournal.SaveToFile();

                // SaveToFile(en);

                // SaveToFile();
            }
            else if (choice == "4")
            {
                // Load the journal from a file
            }
            else if (choice == "5")
            {
                // Quit

                keepRunning = false;
            }
            else
            {
                // unexpected input
                Console.WriteLine("Sorry, that is not valid. Please try again.");
            }
        }
        // SaveToFile(en);

    }

    // public static void SaveToFile(List<Entry> en)
    // {
    //     string filename = "SavedStuff.txt";

    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         foreach (Entry ent in en)
    //         {
    //             outputFile.WriteLine(ent._author);
    //         }
    //     }
    // }

}