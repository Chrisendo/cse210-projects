public class Cycling : Activity
{
    private double _speedInMph;

    public Cycling(DateTime date, int durationInMinutes, double speedInMph) : base(date, durationInMinutes)
    {
        _speedInMph = speedInMph;
    }

    
}