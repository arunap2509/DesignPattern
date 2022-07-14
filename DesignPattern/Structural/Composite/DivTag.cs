namespace DesignPattern.Structural.Composite;

// composite
public class DivTag : ITag
{
    private readonly List<ITag> _children;

    public DivTag(List<ITag> children)
    {
        _children = children;
    }

    public string CreateTag()
    {
        var element = "<div>";

        foreach (var child in _children)
        {
            element += child.CreateTag();
        }

        element += "</div>";

        return element;
    }
}