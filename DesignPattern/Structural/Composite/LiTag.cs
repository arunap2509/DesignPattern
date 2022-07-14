namespace DesignPattern.Structural.Composite;

// leaf
public class LiTag : ITag
{
    private readonly string _content;

    public LiTag(string content)
    {
        _content = content;
    }

    public string CreateTag()
    {
        return $"<li>{_content}</li>";
    }
}
