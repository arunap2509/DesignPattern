namespace DesignPattern.Structural.Decorator;

public class Broccoli : IPizzaDecorator
{
    private readonly IPizza _pizza;
    private readonly string _toppings;

    public Broccoli(IPizza pizza)
    {
        _pizza = pizza;
        _toppings = "Broccoli";
    }

    public int GetCost()
    {
        return _pizza.GetCost() + 35;
    }

    public string GetPizza()
    {
        return $"{_pizza.GetPizza()},{_toppings}";
    }
}