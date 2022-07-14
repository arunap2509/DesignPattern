namespace DesignPattern.Structural.FlyWeight;

// intrinsic value
public class Tree
{
    private readonly string _color;
    private readonly int _height;

    public Tree(string color)
    {
        _color = color;
        _height = 10;
    }

    public string GetColor()
    {
        return _color;
    }

    public int GetHeight()
    {
        return _height;
    }
}