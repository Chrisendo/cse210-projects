public class Swimming : Activity
{
    private int _laps;
    private double _metersPerLap;
    private double _metersPerMile;

    public Swimming(DateTime date, int durationInMinutes, string name, int laps) : base(date, durationInMinutes, name)
    {
        _laps = laps;
        _metersPerLap = 50;
        _metersPerMile = 1609.34;
        _nameOfActivity = "Swimming";
    }


}