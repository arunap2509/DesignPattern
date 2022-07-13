namespace DesignPattern.Creational.AbstractFactory;

public interface IWidgetFactory
{
    IMenuBar CreateMenuBar();
    IScrollBar CreateScrollBar();
}

public class MacWidgetFactory : IWidgetFactory
{
    public IMenuBar CreateMenuBar()
    {
        // can also pass in an argument and return object based on that if you have like
        // mac horizontal menu bar / vertical menu bar
        return new MacMenuBar();
    }

    public IScrollBar CreateScrollBar()
    {
        return new MacScrollBar();
    }
}

public class WindowsWidgetFactory : IWidgetFactory
{
    public IMenuBar CreateMenuBar()
    {
        return new WindowsMenuBar();
    }

    public IScrollBar CreateScrollBar()
    {
        return new WindowsScrollBar();
    }
}