public class Running : Activity
{
    private double _distanceInMiles;

    public Running(string date, int durationInMinutes, string name, double distanceInMiles) : base(date, durationInMinutes, name)
    {
        _distanceInMiles = distanceInMiles;
        _nameOfActivity = "Running";
    
    }

    public override double GetDistanceInMiles()
    {
        return _distanceInMiles;
    }

    public override double GetSpeedInMph()
    {
        if (_durationInMinutes > 0)
        {
            return _distanceInMiles / _durationInMinutes * 60;
        }
        return 0;
    }

    public override double GetMinPerMilePace()
    {
        if (_distanceInMiles > 0)
        {
            return (double)_durationInMinutes / _distanceInMiles;
        }
        return 0;
    }
}