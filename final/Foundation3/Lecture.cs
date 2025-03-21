public class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }


    public string LectureShortDescription()
    {
        return $"Event: Lecture\nTitle: {_title}\nTime: {_date}";
    }


    public string LectureFullDetails()
    {
        return $"{StandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}