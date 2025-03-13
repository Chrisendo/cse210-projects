using System.IO.Enumeration;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // public void AddEntry(newEntry, Entry)
    // {
        
    // }

    
    // public static void LoadFile()
    // {
    //     string filename = "PromptList.txt";
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split("~|~");

    //         string firstName = parts[0];
    //         string lastName = parts[1];
    //     }
    // }
    // THIS IS HOW TO CALL THE LOAD FUNCTION!!!!!
    // theJournal.LoadFile(filename);





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

    // public void SaveToFile()?
    //public void SaveToFile(file, string)?

    public void SaveToFile()
    {
        string fileName = "SavedStuff.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
            // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{e._author}-|-{e._date}-|-{e._promptQuestion}-|-{e._response}");
            }
                
        }


    }



    public void LoadFromFile()
    {
        // List<Entry> journalStuff = new List<Entry>();
        string filename = "SavedStuff.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-|-");

            Entry entryStuff = new Entry();

            entryStuff._author = parts[0];
            entryStuff._date = parts[1];
            entryStuff._promptQuestion = parts[2];
            entryStuff._response = parts[3];
        }
    }


    public void DisplayAll()
    {
        Console.WriteLine($"");

        foreach(Entry entryStuff in _entries)
        {
            entryStuff.Display();
        }
    }


    public void DisplaySavedFile()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();

            Console.WriteLine($"Author: {entry._author}");
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptQuestion}");
            Console.WriteLine($"Response: {entry._response}");

            Console.WriteLine();
        }
    }
                // THIS IS HOW TO CALL THE LOAD FUNCTION!!!!!
                // theJournal.LoadFile(filename);




        // public static List<Entry> ReadFromFile()
        // {
        //     List<Entry> journalStuff = new List<Entry>();
        //     string filename = "PromptList.txt";
        //     string[] lines = System.IO.File.ReadAllLines(filename);

        //     foreach (string line in lines)
        //     {
        //         string[] parts = line.Split("-|-");

        //         Entry entryStuff = new Entry();

        //         entryStuff._author = parts[0];
        //         entryStuff._date = parts[1];
        //         entryStuff._promptQuestion = parts[2];
        //         entryStuff._response = parts[3];
        //     }

        //     return journalStuff;
        // }
}



// save to file goes in this file. Goes through each entry in the list.Resume == Journal?
// Parse..?