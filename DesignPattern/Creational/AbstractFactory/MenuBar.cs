namespace DesignPattern.Creational.AbstractFactory;

public interface IMenuBar
{
    void DisplayMenu();
}

public class MacMenuBar : IMenuBar
{
    public void DisplayMenu()
    {
        Console.WriteLine("Displaying mac os menu bar");
    }
}

public class WindowsMenuBar : IMenuBar
{
    public void DisplayMenu()
    {
        Console.WriteLine("Displaying windows menu bar");
    }
}