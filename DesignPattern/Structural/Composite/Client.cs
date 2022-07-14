namespace DesignPattern.Structural.Composite;

public class CompositeClient
{
    public static void Invoke()
    {
        var html = new Html();

        html.AddTag(new H1Tag("Indian Restaurant"));

        var li1 = new LiTag("Pizza");
        var li2 = new LiTag("Burger");
        var li3 = new LiTag("Sandwich");
        var ul = new UlTag(new List<ITag> { li1, li2, li3 });

        html.AddTag(ul);

        var locationli1Tag = new LiTag("Chennai");
        var locationli2Tag = new LiTag("Bangalore");
        var locationUlTag = new UlTag(new List<ITag> { locationli1Tag, locationli2Tag });
        var locationHeader = new H1Tag("We are available In");
        var locationDiv = new DivTag(new List<ITag> { locationHeader, locationUlTag });

        html.AddTag(locationDiv);

        html.Render();
    }
}