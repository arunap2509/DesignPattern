namespace DesignPattern.Structural.Decorator;

public class Mushroom : IPizzaDecorator
{
    private readonly IPizza _pizza;
    private readonly string _toppings;

    public Mushroom(IPizza pizza)
    {
        _pizza = pizza;
        _toppings = "Mushroom";
    }

    public int GetCost()
    {
        return _pizza.GetCost() + 40;
    }

    public string GetPizza()
    {
        return $"{_pizza.GetPizza()},{_toppings}";
    }
}
