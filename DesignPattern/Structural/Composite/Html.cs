namespace DesignPattern.Structural.Composite;

public class Html
{
    private readonly List<ITag> _tags;

    public Html()
    {
        _tags = new();
    }

    public void AddTag(ITag tag)
    {
        _tags.Add(tag);
    }

    public void Render()
    {
        var html = "<html>";

        foreach (var item in _tags)
        {
            html += item.CreateTag();
        }

        html += "</html>";

        Console.WriteLine(html);
    }
}