namespace DesignPattern.Structural.Bridge;

public class BridgeClient
{
    public static void Invoke()
    {
        IDevice tv = new Tv();
        Remote remote = new TvRemote(tv);

        remote.TurnOn();
        remote.VolumeUp();
        remote.VolumeDown();
        remote.TurnOff();

        IDevice radio = new Radio();
        remote = new RadioRemote(radio);

        remote.TurnOn();
        remote.TurnOff();
    }
}