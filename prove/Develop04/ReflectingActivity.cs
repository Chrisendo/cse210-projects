public class ReflectionActivity : Activity
{
    private List<string> _reflectingPrompts = new List<string>();


    public ReflectionActivity()
    {
        _reflectingPrompts.Add("prompt 1");
        _reflectingPrompts.Add("prompt 2");
        _reflectingPrompts.Add("prompt 3");
        _reflectingPrompts.Add("prompt 4");
        _reflectingPrompts.Add("prompt 5");
        _reflectingPrompts.Add("prompt 6");
        _reflectingPrompts.Add("prompt 7");
        _reflectingPrompts.Add("prompt 8");
        _reflectingPrompts.Add("prompt 9");
        _reflectingPrompts.Add("prompt 10");

        _name = "Reflecting Activity";
        _startingMessage = "This should be a discription of the reflecting activity";
    }

    // Do I need void here?
    public void GetRandomReflectingPrompt()
    {

    }


    public void Run()
    {

    }
}