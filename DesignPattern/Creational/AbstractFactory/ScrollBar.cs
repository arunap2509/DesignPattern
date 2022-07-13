namespace DesignPattern.Creational.AbstractFactory;

public interface IScrollBar
{
    void Scroll();
}

public class MacScrollBar : IScrollBar
{
    public void Scroll()
    {
        Console.WriteLine("scrolling in mac os");
    }
}

public class WindowsScrollBar : IScrollBar
{
    public void Scroll()
    {
        Console.WriteLine("scrolling in windows");
    }
}