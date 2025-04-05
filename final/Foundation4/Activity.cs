public abstract class Activity
{
    protected DateTime _date;
    protected int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        _date = date;
        _durationInMinutes = durationInMinutes;
    }

    public abstract double GetDistanceInMiles();
    public abstract double GetSpeedInMph();
    public abstract double GetMinPerMilePace();

    public virtual string GetSummary()
    {
        double distance = GetDistanceInMiles();
        double speed = GetSpeedInMph();
        double pace = GetMinPerMilePace();

        return $"Date: {_date} Running ({_durationInMinutes} min) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} minutes per mile";
    }
}