public class Specialist : Staff
{
    private string _speciality;


    public Specialist(string fname, string lname, string gender, string specialist) : base(fname, lname, gender)
    {
        _speciality = specialist;
    }

    public void Display()
    {
        Console.WriteLine($"Hello students, I am {GetProfName()}. I am a {_speciality} specialist.");
    }
}