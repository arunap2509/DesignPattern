namespace DesignPattern.Structural.Bridge;

public class Radio : IDevice
{
    private int _volume;

    public Radio()
    {
        _volume = 5;
    }

    public void TurnOff()
    {
        Console.WriteLine("radio turned off");
    }

    public void TurnOn()
    {
        Console.WriteLine("radio turned on");
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