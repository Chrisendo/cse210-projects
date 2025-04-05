public class Cycling : Activity
{
    private double _speedInMph;

    public Cycling(DateTime date, int durationInMinutes, string name, double speedInMph) : base(date, durationInMinutes, name)
    {
        _speedInMph = speedInMph;
        _nameOfActivity = "Cycling";
    }


}