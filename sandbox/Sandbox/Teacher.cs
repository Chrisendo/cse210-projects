public class Teacher : Staff
{
    private int _roomNumber;


    public Teacher(string fname, string lname, string gender, int roomNumber) : base(fname, lname, gender)
    {
        _roomNumber = roomNumber;
    }


    public void Display()
    {
        Console.WriteLine($"Hello students, I am {GetProfName()}. I teach in room {_roomNumber}.");
    }
}