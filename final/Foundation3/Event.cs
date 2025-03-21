public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;


    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    public string ShortDescription()
    {
        return $"Event: This should get replaced..?\nTitle: {_title}\nDate: {_date}";
    }


    public string StandardDetails()
    {
        // Yeahhhh, this didn't work. I thought I could get this to work
        // since I like this style much more, but I'll just do it the other way.

        // Console.WriteLine($"Title: {_title}");
        // Console.WriteLine($"Description: {_description}");
        // Console.WriteLine($"Date: {_date}");
        // Console.WriteLine($"Time: {_time}");
        // Console.WriteLine($"Address: {_address}");
        // return _title, _description, _date, _time, _address;

        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetWholeAddress()}";
    }


    public string FullDetail()
    {
        return StandardDetails();
    }
}