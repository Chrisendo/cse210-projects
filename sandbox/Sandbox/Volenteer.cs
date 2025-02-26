public class Volenteer : Staff
{
    public Volenteer(string fname, string lname, string gender) : base(fname, lname, gender)
    {

    }


    public void Display()
    {
        Console.WriteLine($"Hello students, I am {GetProfName()}. I am a volenteer at the school.");
    }
}