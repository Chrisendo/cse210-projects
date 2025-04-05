public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, int durationInMinutes, double distanceInMiles) : base(date, durationInMinutes)
    {
        _distanceInMiles = distanceInMiles;
    }

    
}