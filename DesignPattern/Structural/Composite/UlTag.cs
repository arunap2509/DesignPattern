namespace DesignPattern.Structural.Composite;

// composite
public class UlTag : ITag
{
    private readonly List<ITag> _children;

    public UlTag(List<ITag> children)
    {
        _children = children;
    }

    public string CreateTag()
    {
        var element = "<ul>";

        foreach (var child in _children)
        {
            element += child.CreateTag();
        }

        element += "</ul>";

        return element;
    }
}
