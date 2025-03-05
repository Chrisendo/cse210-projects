public class ListingActivity : Activity
{
    private List<string> _listingPrompts = new List<string>();


    public ListingActivity()
    {
        _listingPrompts.Add("prompt 1");
        _listingPrompts.Add("prompt 2");
        _listingPrompts.Add("prompt 3");
        _listingPrompts.Add("prompt 4");
        _listingPrompts.Add("prompt 5");
        _listingPrompts.Add("prompt 6");
        _listingPrompts.Add("prompt 7");
        _listingPrompts.Add("prompt 8");
        _listingPrompts.Add("prompt 9");
        _listingPrompts.Add("prompt 10");
        
        _name = "Listing Activity";
        _startingMessage = "This should be a discription of the listing activity";

    }


    // ResponseCount()..?


    public void GetRandomListingPrompt()
    {

    }


    public void Run()
    {
        _timesRun++;
        
    }
}