namespace DesignPattern.Structural.Bridge;

public class Tv : IDevice
{
    private int _volume;

    public Tv()
    {
        _volume = 10;
    }

    public void TurnOff()
    {
        Console.WriteLine("tv turned off");
    }

    public void TurnOn()
    {
        Console.WriteLine("tv turned on");
    }

    public void VolumeDown()
    {
        if (_volume > 1)
        {
            _volume--;
        }

        Console.WriteLine($"volume: {_volume}");
    }

    public void VolumeUp()
    {
        if (_volume < 100)
        {
            _volume++;
        }

        Console.WriteLine($"volume: {_volume}");
    }
}
