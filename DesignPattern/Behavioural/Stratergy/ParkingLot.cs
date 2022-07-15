namespace DesignPattern.Behavioural.Stratergy;

public class ParkingLot
{
    private IParkingStrategy _strategy;

    public ParkingLot(IParkingStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Park()
    {
        _strategy.Park();
    }

    public void ChangeStrategy(IParkingStrategy strategy)
    {
        _strategy = strategy;
    }
}