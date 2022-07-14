namespace DesignPattern.Structural.FlyWeight;

public class TreeFactory
{
    private readonly Dictionary<string, Tree> _treeList;

    public TreeFactory()
    {
        _treeList = new();
    }

    public Tree GetTree(string color)
    {
        if (_treeList.ContainsKey(color))
        {
            return _treeList[color];
        }

        var tree = new Tree(color);
        _treeList.Add(color, tree);

        return tree;
    }

    public void ListTreeTypes()
    {
        foreach (var tree in _treeList)
        {
            Console.WriteLine($"{tree.Value.GetColor()} tree with height {tree.Value.GetHeight()}");
        }
    }
}