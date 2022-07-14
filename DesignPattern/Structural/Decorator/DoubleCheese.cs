namespace DesignPattern.Structural.Decorator;

public class DoubleCheese : IPizzaDecorator
{
    private readonly IPizza _pizza;
    private readonly string _toppings;

    public DoubleCheese(IPizza pizza)
    {
        _pizza = pizza;
        _toppings = "Double Cheese";
    }

    public int GetCost()
    {
        return _pizza.GetCost() + 50;
    }

    public string GetPizza()
    {
        return $"{_pizza.GetPizza()},{_toppings}";
    }
}
