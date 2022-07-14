namespace DesignPattern.Structural.Decorator;

public class DecoratorClient
{
    public static void Invoke()
    {
        IPizza margheritaPizza = new MargheritaPizza();
        var margheritaPizzaWithDoubleCheese = new DoubleCheese(margheritaPizza);

        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(margheritaPizzaWithDoubleCheese.GetPizza());
        Console.WriteLine(margheritaPizzaWithDoubleCheese.GetCost());

        var cornPizza = new SweetCornPizza();
        var cornWithDoubleCheese = new DoubleCheese(cornPizza);
        var cornWithDoubleCheeseAndMushroom = new Mushroom(cornWithDoubleCheese);

        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(cornWithDoubleCheeseAndMushroom.GetPizza());
        Console.WriteLine(cornWithDoubleCheeseAndMushroom.GetCost());
    }
}