public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void Display()
    {
        Console.WriteLine($"");


        foreach(Entry entryStuff in _entries)
        {
            entryStuff.Display();
        }
    }
}


// save to file goes in this file. Goes through each entry in the list.Resume == Journal?