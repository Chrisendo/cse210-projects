public abstract class Activity
{
    protected DateTime _date;
    protected int _durationInMinutes;
    protected string _nameOfActivity;

    public Activity(DateTime date, int durationInMinutes, string name)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
        _nameOfActivity = name;
    }

    public abstract double GetDistanceInMiles();
    public abstract double GetSpeedInMph();
    public abstract double GetMinPerMilePace();

    public virtual string GetSummary()
    {
        double distance = GetDistanceInMiles();
        double speed = GetSpeedInMph();
        double pace = GetMinPerMilePace();

        return $"Date: {_date} {_nameOfActivity} ({_durationInMinutes} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} minutes per mile";
    }
}