public class ReflectionActivity : Activity
{
    private List<string> _reflectingPrompts = new List<string>();


    public ReflectionActivity(string startMessage, string name, int time, List<string> reflectingPrompts) : base(startMessage, name, time)
    {
        _reflectingPrompts = reflectingPrompts;
    }

    // Do I need void here?
    public void GetRandomReflectingPrompt()
    {

    }


    public void Run()
    {

    }
}