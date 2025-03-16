

public class Video
{
    private string _title;
    private string _author;
    private int _timeSeconds;
    public List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int time)
    {
        _title = title;
        _author = author;
        _timeSeconds = time;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($" '{_title}' by {_author}, video length: {_timeSeconds} seconds. ");
        // Console.WriteLine($"Author: {_author}");
        // Console.WriteLine($"Video length (in seconds): {_timeSeconds}");
        Console.WriteLine($"");
        Console.WriteLine($"Comments: ");


        foreach (Comment manyComments in _comments)
        {
            manyComments.DisplayComments();
        }
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }
}