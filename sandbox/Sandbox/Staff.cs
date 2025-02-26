public class Staff
{
    protected string _firstName;
    protected string _lastName;
    protected string _gender;

    public Staff(string fname, string lname, string gender)
    {
        _firstName = fname;
        _lastName = lname;
        _gender = gender;
    }


    public string GetTitle()
    {
        if (_gender == "Female")
        {
            return "Ms.";
        }

        else
        {
            return "Mr.";
        }
    }


    
    public string GetProfName()
    {
        string title = GetTitle();
        return title + " " + _lastName;
    }
}