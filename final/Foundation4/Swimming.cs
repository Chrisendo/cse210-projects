public class Swimming : Activity
{
    private int _laps;
    private double _metersPerLap;
    private double _metersPerMile;

    public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        _laps = laps;
        _metersPerLap = 50;
        _metersPerMile = 1609.34;
    }

    
}