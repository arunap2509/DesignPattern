namespace DesignPattern.Structural.Facade;

public class Driver
{
    private readonly ICar _car;

    public Driver(ICar car)
    {
        _car = car;
    }

    public void Drive()
    {
        _car.Start();
        _car.TurnRight();
        _car.TurnLeft();
        _car.Stop();
    }
}