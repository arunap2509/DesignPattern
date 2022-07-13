namespace DesignPattern.Creational.AbstractFactory;

public class AbstractFactoryClient
{ 
    public static void Invoke()
    {

        IWidgetFactory macWidgetFactory = new MacWidgetFactory();
        IWidgetFactory windowsWidgetFactory = new WindowsWidgetFactory();

        IMenuBar macMenuBar = macWidgetFactory.CreateMenuBar();
        IMenuBar windowsMenuBar = windowsWidgetFactory.CreateMenuBar();

        macMenuBar.DisplayMenu();
        windowsMenuBar.DisplayMenu();

        IScrollBar macScrollBar = macWidgetFactory.CreateScrollBar();
        IScrollBar windowsScrollBar = windowsWidgetFactory.CreateScrollBar();

        macScrollBar.Scroll();
        windowsScrollBar.Scroll();
    }
}