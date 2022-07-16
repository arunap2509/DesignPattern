namespace DesignPattern.Behavioural.Visitor;

public class ResidentialHouse
{
    private readonly string _streetName;
    private readonly string _houseName;
    private readonly (int x, int y) _coordinates;

    public ResidentialHouse(string streetName, string houseName, (int x, int y) coordinates)
    {
        _streetName = streetName;
        _houseName = houseName;
        _coordinates = coordinates;
    }

    public void Accept(IExportVistor vistor)
    {
        vistor.Export(this);
    }
}

