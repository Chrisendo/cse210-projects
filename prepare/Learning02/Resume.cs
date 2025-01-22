public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

     public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");

        // I got stuck here as well, and had to look at the example to finish.
        foreach(Job manyJobs in _jobs)
        {
            manyJobs.Display();
        }
    }
}