namespace DesignPattern.Structural.Facade;

public class FacadeClient
{
    public static void Invoke()
    {
        ICar car = new CarFacade(new Engine(), new Wheel());
        var driver = new Driver(car);
        driver.Drive();
    }
}