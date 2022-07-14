namespace DesignPattern.Structural.Adapter;

public class EnglishToGermanAdapter : ISpeaker
{
    private readonly GermanSpeaker _germanSpeaker;

    public EnglishToGermanAdapter(GermanSpeaker germanSpeaker)
    {
        _germanSpeaker = germanSpeaker;
    }

    // adapter is mostly a wrapper to the unsupported interface the code have with your expected one
    // in most cases you just simply call the adaptee objects method, here just for this context added a
    // convert method
    public void GreatInEnglish(string greet)
    {
        _germanSpeaker.GreatInGerman(Convert(greet));
    }

    private string Convert(string text)
    {
        return "Hallo, willkommen";
    }
}
