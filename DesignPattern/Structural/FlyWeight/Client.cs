namespace DesignPattern.Structural.FlyWeight;

public class FlyweightClient
{
    public static void Invoke()
    {
        var forest = new Forest();

        forest.AddTree(10, 70, "brown");
        forest.AddTree(10, 71, "green");
        forest.AddTree(11, 70, "brown");

        forest.ListTreeTypes();
    }
}