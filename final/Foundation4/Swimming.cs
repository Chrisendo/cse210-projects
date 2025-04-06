public class Swimming : Activity
{
    private int _laps;
    private double _metersPerLap;
    private double _metersPerMile;

    public Swimming(string date, int durationInMinutes, string name, int laps) : base(date, durationInMinutes, name)
    {
        _laps = laps;
        _metersPerLap = 50;
        _metersPerMile = 1609.34;
        _nameOfActivity = "Swimming";
    }

    public override double GetDistanceInMiles()
    {
        return _laps * _metersPerLap / _metersPerMile;
    }

    public override double GetSpeedInMph()
    {
        double distanceMilesForSpeed = GetDistanceInMiles();
        if (_durationInMinutes > 0)
        {
            return distanceMilesForSpeed / _durationInMinutes * 60;
        }
        return 0;
    }

    public override double GetMinPerMilePace()
    {
        double distanceMilesForSpeed = GetDistanceInMiles();
        if (distanceMilesForSpeed > 0)
        {
            return (double)_durationInMinutes / distanceMilesForSpeed;
        }
        return 0;
    }
}