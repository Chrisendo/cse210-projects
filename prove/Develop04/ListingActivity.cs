public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();


    public ListingActivity(string startMessage, string name, int time, List<string> listingPrompts) : base(startMessage, name, time)
    {
        _listingPrompts = listingPrompts;
    }


    // ResponseCount()..?


    public void GetRandomListingPrompt()
    {

    }


    public void Run()
    {

    }
}