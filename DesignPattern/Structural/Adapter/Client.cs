namespace DesignPattern.Structural.Adapter;

public class AdapterClient
{
    public static void Invoke()
    {
        ISpeaker speaker = new EnglishSpeaker();
        speaker.GreatInEnglish("hey hello, welcome");

        var germanSpeaker = new GermanSpeaker();
        var englishToGerman = new EnglishToGermanAdapter(germanSpeaker);
        englishToGerman.GreatInEnglish("hey hello, welcome");
    }
}