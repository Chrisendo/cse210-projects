public abstract class Activity
{
    protected string _date;
    protected int _durationInMinutes;
    protected string _nameOfActivity;

    public Activity(string date, int durationInMinutes, string name)
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

        return $"Date: {_date:dd MMM} {_nameOfActivity} ({_durationInMinutes} min) - Distance: {distance:F1} miles, Speed: {speed:F1} mph, Pace: {pace:F1} minutes per mile";
    }
}