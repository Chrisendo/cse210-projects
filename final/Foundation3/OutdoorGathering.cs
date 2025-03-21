public class OutdoorGathering : Event
{
    private string _weather;


    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }


    public string OutdoorGatheringShortDescription()
    {
        return $"Event: Outdoor Gathering\nTitle: {_title}\nTime: {_date}";
    }


    public string OutdoorGatheringFullDetails()
    {
        return $"{StandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weather}";
    }
}