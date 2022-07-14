namespace DesignPattern.Structural.FlyWeight;

public class Forest
{
    private readonly List<Tree> _trees;
    private readonly List<TreeLocation> _treeLocations;
    private readonly TreeFactory _treeFactory;

    public Forest()
    {
        _trees = new();
        _treeLocations = new();
        _treeFactory = new TreeFactory();
    }

    public void AddTree(int x, int y, string color)
    {
        var tree = _treeFactory.GetTree(color);

        _trees.Add(tree);
        _treeLocations.Add(new TreeLocation(x, y));

        PlantTree(_trees.Count - 1);
    }

    private void PlantTree(int index)
    {
        Console.WriteLine($"New {_trees[index].GetColor()} tree has " +
            $"been planted on {{{_treeLocations[index].GetX()}}},{{{_treeLocations[index].GetY()}}}");
    }

    public void ListTreeTypes()
    {
        _treeFactory.ListTreeTypes();
    }
}