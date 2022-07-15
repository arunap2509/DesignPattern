namespace DesignPattern.Behavioural.Stratergy;

public class NonPeakTimeParkingStrategy : IParkingStrategy
{
    public void Park()
    {
        Console.WriteLine("Park in empty place where you feel is comfortable for you");
    }
}
