namespace DesignPattern.Structural.Composite;

// leaf
public class H1Tag : ITag
{
    private readonly string _content;

    public H1Tag(string content)
    {
        _content = content;
    }

    public string CreateTag()
    {
        return $"<h1>{_content}</h1>";
    }
}
