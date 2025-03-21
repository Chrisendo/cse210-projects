public class Reception : Event
{
    private string _reservationEmail;


    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _reservationEmail = email;
    }


    public string ReceptionShortDescription()
    {
        return $"Event: Reception\nTitle: {_title}\nTime: {_date}";
    }


    public string ReceptionFullDetails()
    {
        return $"{StandardDetails()}\nReservation Email: {_reservationEmail}";
    }
}