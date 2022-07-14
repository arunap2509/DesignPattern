namespace DesignPattern.Structural.Bridge;

public abstract class Remote
{
    private readonly IDevice _device;

    public Remote(IDevice device)
    {
        _device = device;
    }

    public virtual void TurnOn()
    {
        _device.TurnOn();
    }

    public virtual void TurnOff()
    {
        _device.TurnOff();
    }

    public virtual void VolumeUp()
    {
        _device.VolumeUp();
    }

    public virtual void VolumeDown()
    {
        _device.VolumeDown();
    }
}
