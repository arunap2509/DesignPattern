namespace DesignPattern.Structural.Facade;

public class CarFacade: ICar
{
    private readonly Engine _engine;
    private readonly Wheel _wheel;

    public CarFacade(Engine engine, Wheel wheel)
    {
        _engine = engine;
        _wheel = wheel;
    }

    public void Start()
    {
        _engine.Start();
    }

    public void Stop()
    {
        _engine.Stop();
    }

    public void TurnLeft()
    {
        _wheel.TurnLeft();
    }

    public void TurnRight()
    {
        _wheel.TurnRight();
    }
}
