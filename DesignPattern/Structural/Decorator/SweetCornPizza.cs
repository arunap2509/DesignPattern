namespace DesignPattern.Structural.Decorator;

public class SweetCornPizza : IPizza
{

    private readonly string _pizza;

    public SweetCornPizza()
    {
        _pizza = "Sweet Corn Pizza";
    }

    public int GetCost()
    {
        return 160;
    }

    public string GetPizza()
    {
        return _pizza;
    }
}
