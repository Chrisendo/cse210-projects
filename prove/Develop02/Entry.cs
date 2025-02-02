public class Entry
{
    public string _author;
    public string _date;
    public string _promptQuestion;
    public string _response;


    public void Display()
    {
        Console.WriteLine($"{_author}");

        Console.WriteLine($"{_date}");

        Console.WriteLine($"{_promptQuestion}");

        // Console.WriteLine(ReadFromFile());

        Console.WriteLine($"{_response}");

        Console.WriteLine();
    }

}