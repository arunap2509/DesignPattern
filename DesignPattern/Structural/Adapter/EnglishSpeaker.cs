namespace DesignPattern.Structural.Adapter;

public class EnglishSpeaker : ISpeaker
{
    public void GreatInEnglish(string greet)
    {
        Console.WriteLine(greet);
    }
}
