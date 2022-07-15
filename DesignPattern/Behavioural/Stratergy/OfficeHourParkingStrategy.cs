namespace DesignPattern.Behavioural.Stratergy;

public class OfficeHourParkingStrategy : IParkingStrategy
{
    public void Park()
    {
        Console.WriteLine("Park from one end, row by row");
    }
}
