public class Running : Activity
{
    private double _distanceInMiles;

    public Running(DateTime date, int durationInMinutes, string name, double distanceInMiles) : base(date, durationInMinutes, name)
    {
        _distanceInMiles = distanceInMiles;
        _nameOfActivity = "Running";
    
    }


}