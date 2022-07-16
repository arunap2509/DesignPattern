namespace DesignPattern.Behavioural.Visitor;

public class Industries
{
    private readonly string _streetName;
    private readonly string _industryName;
    private readonly (int x, int y) _coordinates;

    public Industries(string streetName, string industryName, (int x, int y) coordinates)
    {
        _streetName = streetName;
        _industryName = industryName;
        _coordinates = coordinates;
    }

    public void Accept(IExportVistor vistor)
    {
        vistor.Export(this);
    }
}

