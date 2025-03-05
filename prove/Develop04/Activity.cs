public class Activity
{
    protected string _startingMessage; // discription
    protected string _name; // name of activity
    protected int _time; // duration
    protected int _timesRun = 0;


    // public Activity()
    // {
        
    // }

    


    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Hello! Welcome to the {_name} activity");
        Console.WriteLine($"{_startingMessage}");

        Console.WriteLine("How long would you like to go for?");

        _time = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done! You have completed another {_time} seconds of the {_name}");
    }
}