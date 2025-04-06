public class Cycling : Activity
{
    private double _speedInMph;

    public Cycling(string date, int durationInMinutes, string name, double speedInMph) : base(date, durationInMinutes, name)
    {
        _speedInMph = speedInMph;
        _nameOfActivity = "Cycling";
    }

    public override double GetDistanceInMiles()
    {
        return _speedInMph * _durationInMinutes / 60;
    }

    public override double GetSpeedInMph()
    {
        return _speedInMph;
    }

    public override double GetMinPerMilePace()
    {
        double speed = GetSpeedInMph();
        if (speed > 0)
        {
            return 60 / speed;
        }
        return 0;
    }
}