namespace DesignPattern.Structural.Decorator;

public class MargheritaPizza : IPizza
{
    private readonly string _pizza;

    public MargheritaPizza()
    {
        _pizza = "Margherita Pizza";
    }

    public int GetCost()
    {
        return 200;
    }

    public string GetPizza()
    {
        return _pizza;
    }
}
